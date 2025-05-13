using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Pharmacy
{
    public static class DatabaseManager
    {
        public static string dbPath;
        
        public static string CreateDatabase()
        {
            using(var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "SQLite Database (*.sqlite)|*.sqlite";
                saveFileDialog.Title = "Создать новую базу данных";
                saveFileDialog.DefaultExt = ".sqlite";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dbPath = saveFileDialog.FileName;
                    SQLiteConnection.CreateFile(dbPath);
                    string connectionString = $"Datasource={dbPath};Version=3;";
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Лекарства (
                        Препарат TEXT NOT NULL UNIQUE,
                        Болезнь TEXT NOT NULL,
                        Цена REAL NOT NULL,
                        Количество INTEGER NOT NULL,
                        Производитель TEXT NOT NULL

                    );";

                        using (var command = new SQLiteCommand(createTableQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    return connectionString;
                }

            }
            return null;
        }

        public static void DeleteDatabase()
        {
            if (File.Exists(dbPath))
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        File.Delete(dbPath);
                        return;
                    }
                    catch (IOException)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Файл не существует. Перед удалением создайте/откройте базу данных");
            }
        }

        public static string SelectDatabase()
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
                selectFileDialog.Filter = "SQLite Database (*.sqlite)|*.sqlite";
                selectFileDialog.Title = "Выбрать базу данных";
                selectFileDialog.DefaultExt = ".sqlite";
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dbPath = selectFileDialog.FileName;
                    string connectionString = $"DataSource={dbPath};Version=3;";
                    return connectionString;
                }
            }
            return null;
        }

        public static void CreateReport(DataGridView sourceTable)
        {
            if (sourceTable.DataSource == null) throw new InvalidOperationException("Невозможно создать отчет. Создайте/откройте базу данных");
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Сохранить отчет";
                saveFileDialog.DefaultExt = ".pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using(FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document(iTextSharp.text.PageSize.Letter, 10, 10, 42, 35);
                        PdfWriter.GetInstance(doc, fs);
                        doc.Open();
                        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                        BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        Font titleFont = new Font(baseFont, 14, Font.BOLD);
                        Font cellFont = new Font(baseFont, 12);
                        Paragraph title = new Paragraph("Аптечный учет", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20f;
                        doc.Add(title);
                        PdfPTable table = new PdfPTable(sourceTable.Columns.Count);
                        for (int i = 0; i < sourceTable.Columns.Count; ++i)
                        {
                            table.AddCell(new Phrase(sourceTable.Columns[i].HeaderText, cellFont));
                        }
                        for (int i = 0; i < sourceTable.Rows.Count; ++i)
                        {
                            for (int j = 0; j < sourceTable.Columns.Count; ++j)
                            {
                                table.AddCell(new Phrase(sourceTable.Rows[i].Cells[j].Value.ToString(), cellFont));
                            }
                        }
                        doc.Add(table);
                        doc.Close();
                    }
                }
            }
        }
    }
}
