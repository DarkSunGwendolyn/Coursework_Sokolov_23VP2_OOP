using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class MainForm : Form
    {
        private string currentConnection;

        private MedicineService service;
        public MainForm()
        {
            InitializeComponent();
            filterParam.SelectedIndex = 0;
            sortParams.SelectedIndex = 0;
        }

        private void CreateDB_Click(object sender, EventArgs e)
        {
            string newConnection = DatabaseManager.CreateDatabase();
            if (newConnection == null) return;
            currentConnection = newConnection;
            service = new MedicineService(currentConnection);
            RecordTable.DataSource = service.GetAllMedicines();
            RecordTable.Columns["Name"].HeaderText = "Препарат";
            RecordTable.Columns["Disease"].HeaderText = "Болезнь";
            RecordTable.Columns["Price"].HeaderText = "Цена";
            RecordTable.Columns["Quantity"].HeaderText = "Количество";
            RecordTable.Columns["Manufacturer"].HeaderText = "Производитель";
            RecordTable.Columns["Price"].DefaultCellStyle.Format = "n2";

        }

        private void OpenDB_Click(object sender, EventArgs e)
        {
            string newConnection = DatabaseManager.SelectDatabase();
            if (newConnection == null) return;
            currentConnection = newConnection;
            service = new MedicineService(currentConnection);
            RecordTable.DataSource = service.GetAllMedicines();
            RecordTable.Columns["Name"].HeaderText = "Препарат";
            RecordTable.Columns["Disease"].HeaderText = "Болезнь";
            RecordTable.Columns["Price"].HeaderText = "Цена";
            RecordTable.Columns["Quantity"].HeaderText = "Количество";
            RecordTable.Columns["Manufacturer"].HeaderText = "Производитель";
            RecordTable.Columns["Price"].DefaultCellStyle.Format = "n2";
        }

        private void ReportDB_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.CreateReport(RecordTable);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка при создании отчета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteDB_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.DeleteDatabase();
                service = null;
                currentConnection = null;
                RecordTable.DataSource = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            if (service == null)
            {
                MessageBox.Show("Откройте или создайте базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string name = addName.Text.ToString();
                decimal price = addPrice.Value;
                string disease = addDisease.Text.ToString();
                int quantity = (int)addQuantity.Value;
                string producer = addProducer.Text.ToString();
                service.AddMedicine(name, price, disease, quantity, producer);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка при добавлении записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            if (service == null)
            {
                MessageBox.Show("Откройте или создайте базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string name = deleteName.Text.ToString();
                service.DeleteMedicine(name);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка при удалении записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindRecord_Click(object sender, EventArgs e)
        {
            if (service == null)
            {
                MessageBox.Show("Откройте или создайте базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string name = findName.Text.ToString();
                Medicine medicine = service.FindByName(name);
                for (int i = 0; i < RecordTable.RowCount; ++i)
                {
                    if (RecordTable.Rows[i].Cells[0].Value.Equals(medicine.Name))
                    {
                        RecordTable.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка поиска записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterRecord_Click(object sender, EventArgs e)
        {
            if (service == null)
            {
                MessageBox.Show("Откройте или создайте базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string param = filterParam.SelectedItem.ToString();
                BindingList<Medicine> filtredList;
                if (param == "Цена" || param == "Количество на складе")
                {
                    decimal lowerBarrier = lowerBound.Value;
                    decimal upperBarrier = higherBound.Value;
                    filtredList = service.FiltredMedicine(lowerBarrier, upperBarrier, param);
                }
                else
                {
                    string compWord = filterWord.Text;
                    filtredList = service.FiltredMedicine(compWord, param);
                }
                BindingList<Medicine> allRecords = service.GetAllMedicines();
                int hiddenRecords = allRecords.Count - filtredList.Count;
                RecordTable.DataSource = filtredList;
                MessageBox.Show($"Скрыто записей: {hiddenRecords}", "Информация о фильтрации");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка фильтрации записей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SortRecord_Click(object sender, EventArgs e)
        {
            if (service == null)
            {
                MessageBox.Show("Откройте или создайте базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string param = sortParams.SelectedItem.ToString();
                BindingList<Medicine> sortedList;
                if (decreasingOrder.Checked)
                {
                    sortedList = service.SortedDecreaseMedicine(param);
                }
                else
                {
                    sortedList = service.SortedIncreaseMedicine(param);
                }
                RecordTable.DataSource = sortedList;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка сортировки записей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            if (service == null)
            {
                MessageBox.Show("Откройте или создайте базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string findName = search.Text.ToString();
                string uploadDisease = editDisease.Text.ToString();
                decimal uploadPrice = editPrice.Value;
                int uploadQuantity = (int)editQuantity.Value;
                string uploadManufacturer = editProducer.Text.ToString();
                service.UpdateMedicine(findName, uploadDisease, uploadPrice, uploadQuantity, uploadManufacturer);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка редактирования записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelFilter_Click(object sender, EventArgs e)
        {
            if (service == null) return;
            RecordTable.DataSource = service.GetAllMedicines();
        }

        private void CancelSort_Click(object sender, EventArgs e)
        {
            if (service == null) return;
            RecordTable.DataSource = service.GetAllMedicines();
        }

        private void CancelFind_Click(object sender, EventArgs e)
        {
            if (service == null) return;
            foreach (DataGridViewRow row in RecordTable.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void filterParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedParam = filterParam.SelectedItem.ToString();
            if (selectedParam != "Цена" && selectedParam != "Количество на складе")
            {
                lowerBound.Visible = false;
                higherBound.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label15.Visible = true;
                filterWord.Visible = true;
            }
            else
            {
                lowerBound.Visible = true;
                higherBound.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label15.Visible = false;
                filterWord.Visible = false;
            }
        }
    }
}