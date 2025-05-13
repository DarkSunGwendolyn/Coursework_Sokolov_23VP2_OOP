namespace Pharmacy
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddRecord = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addProducer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addDisease = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.deleteName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CancelFind = new System.Windows.Forms.Button();
            this.FindRecord = new System.Windows.Forms.Button();
            this.findName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.filterWord = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.filterParam = new System.Windows.Forms.ComboBox();
            this.CancelFilter = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.higherBound = new System.Windows.Forms.NumericUpDown();
            this.lowerBound = new System.Windows.Forms.NumericUpDown();
            this.FilterRecord = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sortParams = new System.Windows.Forms.ComboBox();
            this.CancelSort = new System.Windows.Forms.Button();
            this.SortRecord = new System.Windows.Forms.Button();
            this.decreasingOrder = new System.Windows.Forms.RadioButton();
            this.increasingOrder = new System.Windows.Forms.RadioButton();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.editPrice = new System.Windows.Forms.NumericUpDown();
            this.editProducer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.editDisease = new System.Windows.Forms.TextBox();
            this.editQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EditRecord = new System.Windows.Forms.Button();
            this.OpenDB = new System.Windows.Forms.Button();
            this.ReportDB = new System.Windows.Forms.Button();
            this.DeleteDB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateDB = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.RecordTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPrice)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.higherBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBound)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.AddRecord);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(522, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            // 
            // AddRecord
            // 
            this.AddRecord.BackColor = System.Drawing.Color.SeaGreen;
            this.AddRecord.ForeColor = System.Drawing.Color.White;
            this.AddRecord.Location = new System.Drawing.Point(95, 399);
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(327, 38);
            this.AddRecord.TabIndex = 12;
            this.AddRecord.Text = "Добавить запись";
            this.AddRecord.UseVisualStyleBackColor = false;
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.addProducer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.addQuantity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addDisease);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addName);
            this.groupBox2.Location = new System.Drawing.Point(22, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 343);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о лекарстве";
            // 
            // addProducer
            // 
            this.addProducer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProducer.Location = new System.Drawing.Point(224, 276);
            this.addProducer.Name = "addProducer";
            this.addProducer.Size = new System.Drawing.Size(234, 24);
            this.addProducer.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Производитель";
            // 
            // addQuantity
            // 
            this.addQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuantity.Location = new System.Drawing.Point(227, 218);
            this.addQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.addQuantity.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(233, 24);
            this.addQuantity.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Количество на складе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Название заболевания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 5;
            // 
            // addDisease
            // 
            this.addDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDisease.Location = new System.Drawing.Point(226, 161);
            this.addDisease.Name = "addDisease";
            this.addDisease.Size = new System.Drawing.Size(234, 24);
            this.addDisease.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Стоимость препарата";
            // 
            // addPrice
            // 
            this.addPrice.DecimalPlaces = 2;
            this.addPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPrice.Location = new System.Drawing.Point(225, 103);
            this.addPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.addPrice.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(233, 24);
            this.addPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название препарата";
            // 
            // addName
            // 
            this.addName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addName.Location = new System.Drawing.Point(223, 50);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(234, 24);
            this.addName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(522, 495);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Удаление";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.DeleteRecord);
            this.groupBox3.Controls.Add(this.deleteName);
            this.groupBox3.Location = new System.Drawing.Point(81, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 135);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Название лекарства удаляемой записи";
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.SeaGreen;
            this.DeleteRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteRecord.Location = new System.Drawing.Point(96, 80);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(146, 37);
            this.DeleteRecord.TabIndex = 1;
            this.DeleteRecord.Text = "Удалить";
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // deleteName
            // 
            this.deleteName.Location = new System.Drawing.Point(29, 40);
            this.deleteName.Name = "deleteName";
            this.deleteName.Size = new System.Drawing.Size(275, 24);
            this.deleteName.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(522, 495);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Поиск";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.CancelFind);
            this.groupBox4.Controls.Add(this.FindRecord);
            this.groupBox4.Controls.Add(this.findName);
            this.groupBox4.Location = new System.Drawing.Point(81, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 141);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Название лекарства искомой записи";
            // 
            // CancelFind
            // 
            this.CancelFind.BackColor = System.Drawing.Color.SeaGreen;
            this.CancelFind.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelFind.Location = new System.Drawing.Point(210, 88);
            this.CancelFind.Name = "CancelFind";
            this.CancelFind.Size = new System.Drawing.Size(121, 33);
            this.CancelFind.TabIndex = 2;
            this.CancelFind.Text = "Скрыть";
            this.CancelFind.UseVisualStyleBackColor = false;
            this.CancelFind.Click += new System.EventHandler(this.CancelFind_Click);
            // 
            // FindRecord
            // 
            this.FindRecord.BackColor = System.Drawing.Color.SeaGreen;
            this.FindRecord.ForeColor = System.Drawing.SystemColors.Control;
            this.FindRecord.Location = new System.Drawing.Point(23, 88);
            this.FindRecord.Name = "FindRecord";
            this.FindRecord.Size = new System.Drawing.Size(126, 33);
            this.FindRecord.TabIndex = 1;
            this.FindRecord.Text = "Найти";
            this.FindRecord.UseVisualStyleBackColor = false;
            this.FindRecord.Click += new System.EventHandler(this.FindRecord_Click);
            // 
            // findName
            // 
            this.findName.Location = new System.Drawing.Point(23, 42);
            this.findName.Name = "findName";
            this.findName.Size = new System.Drawing.Size(308, 24);
            this.findName.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(522, 495);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Фильтр";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.filterWord);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.filterParam);
            this.groupBox5.Controls.Add(this.CancelFilter);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.higherBound);
            this.groupBox5.Controls.Add(this.lowerBound);
            this.groupBox5.Controls.Add(this.FilterRecord);
            this.groupBox5.Location = new System.Drawing.Point(62, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(403, 231);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Параметры фильтрации";
            // 
            // filterWord
            // 
            this.filterWord.Location = new System.Drawing.Point(117, 105);
            this.filterWord.Name = "filterWord";
            this.filterWord.Size = new System.Drawing.Size(254, 24);
            this.filterWord.TabIndex = 9;
            this.filterWord.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 18);
            this.label15.TabIndex = 8;
            this.label15.Text = "Фильтр";
            this.label15.Visible = false;
            // 
            // filterParam
            // 
            this.filterParam.FormattingEnabled = true;
            this.filterParam.Items.AddRange(new object[] {
            "Цена",
            "Болезнь",
            "Название",
            "Количество на складе",
            "Производитель"});
            this.filterParam.Location = new System.Drawing.Point(18, 37);
            this.filterParam.Name = "filterParam";
            this.filterParam.Size = new System.Drawing.Size(353, 26);
            this.filterParam.TabIndex = 7;
            this.filterParam.SelectedIndexChanged += new System.EventHandler(this.filterParam_SelectedIndexChanged);
            // 
            // CancelFilter
            // 
            this.CancelFilter.BackColor = System.Drawing.Color.SeaGreen;
            this.CancelFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelFilter.Location = new System.Drawing.Point(212, 177);
            this.CancelFilter.Name = "CancelFilter";
            this.CancelFilter.Size = new System.Drawing.Size(159, 29);
            this.CancelFilter.TabIndex = 6;
            this.CancelFilter.Text = "Снять фильтр";
            this.CancelFilter.UseVisualStyleBackColor = false;
            this.CancelFilter.Click += new System.EventHandler(this.CancelFilter_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "от";
            // 
            // higherBound
            // 
            this.higherBound.Location = new System.Drawing.Point(166, 125);
            this.higherBound.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.higherBound.Name = "higherBound";
            this.higherBound.Size = new System.Drawing.Size(89, 24);
            this.higherBound.TabIndex = 3;
            // 
            // lowerBound
            // 
            this.lowerBound.Location = new System.Drawing.Point(166, 86);
            this.lowerBound.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.lowerBound.Name = "lowerBound";
            this.lowerBound.Size = new System.Drawing.Size(89, 24);
            this.lowerBound.TabIndex = 2;
            // 
            // FilterRecord
            // 
            this.FilterRecord.BackColor = System.Drawing.Color.SeaGreen;
            this.FilterRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilterRecord.Location = new System.Drawing.Point(18, 177);
            this.FilterRecord.Name = "FilterRecord";
            this.FilterRecord.Size = new System.Drawing.Size(159, 29);
            this.FilterRecord.TabIndex = 1;
            this.FilterRecord.Text = "Фильтровать";
            this.FilterRecord.UseVisualStyleBackColor = false;
            this.FilterRecord.Click += new System.EventHandler(this.FilterRecord_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(522, 495);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Сортировка";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.sortParams);
            this.groupBox6.Controls.Add(this.CancelSort);
            this.groupBox6.Controls.Add(this.SortRecord);
            this.groupBox6.Controls.Add(this.decreasingOrder);
            this.groupBox6.Controls.Add(this.increasingOrder);
            this.groupBox6.Location = new System.Drawing.Point(80, 146);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(354, 210);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Параметры сортировки лекарств";
            // 
            // sortParams
            // 
            this.sortParams.FormattingEnabled = true;
            this.sortParams.Items.AddRange(new object[] {
            "Название",
            "Болезнь",
            "Цена",
            "Количество на складе",
            "Производитель"});
            this.sortParams.Location = new System.Drawing.Point(32, 37);
            this.sortParams.Name = "sortParams";
            this.sortParams.Size = new System.Drawing.Size(290, 26);
            this.sortParams.TabIndex = 4;
            // 
            // CancelSort
            // 
            this.CancelSort.BackColor = System.Drawing.Color.SeaGreen;
            this.CancelSort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelSort.Location = new System.Drawing.Point(190, 142);
            this.CancelSort.Name = "CancelSort";
            this.CancelSort.Size = new System.Drawing.Size(132, 32);
            this.CancelSort.TabIndex = 3;
            this.CancelSort.Text = "Отменить";
            this.CancelSort.UseVisualStyleBackColor = false;
            this.CancelSort.Click += new System.EventHandler(this.CancelSort_Click);
            // 
            // SortRecord
            // 
            this.SortRecord.BackColor = System.Drawing.Color.SeaGreen;
            this.SortRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SortRecord.Location = new System.Drawing.Point(32, 142);
            this.SortRecord.Name = "SortRecord";
            this.SortRecord.Size = new System.Drawing.Size(132, 32);
            this.SortRecord.TabIndex = 2;
            this.SortRecord.Text = "Сортировать";
            this.SortRecord.UseVisualStyleBackColor = false;
            this.SortRecord.Click += new System.EventHandler(this.SortRecord_Click);
            // 
            // decreasingOrder
            // 
            this.decreasingOrder.AutoSize = true;
            this.decreasingOrder.Location = new System.Drawing.Point(41, 103);
            this.decreasingOrder.Name = "decreasingOrder";
            this.decreasingOrder.Size = new System.Drawing.Size(123, 22);
            this.decreasingOrder.TabIndex = 1;
            this.decreasingOrder.Text = "По убыванию";
            this.decreasingOrder.UseVisualStyleBackColor = true;
            // 
            // increasingOrder
            // 
            this.increasingOrder.AutoSize = true;
            this.increasingOrder.Checked = true;
            this.increasingOrder.Location = new System.Drawing.Point(41, 77);
            this.increasingOrder.Name = "increasingOrder";
            this.increasingOrder.Size = new System.Drawing.Size(144, 22);
            this.increasingOrder.TabIndex = 0;
            this.increasingOrder.TabStop = true;
            this.increasingOrder.Text = "По возрастанию";
            this.increasingOrder.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage6.Controls.Add(this.panel2);
            this.tabPage6.Controls.Add(this.panel1);
            this.tabPage6.Controls.Add(this.EditRecord);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(522, 495);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "Редактирование";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.editPrice);
            this.panel2.Controls.Add(this.editProducer);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.editDisease);
            this.panel2.Controls.Add(this.editQuantity);
            this.panel2.Location = new System.Drawing.Point(22, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 259);
            this.panel2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Стоимость препарата";
            // 
            // editPrice
            // 
            this.editPrice.DecimalPlaces = 2;
            this.editPrice.Location = new System.Drawing.Point(218, 25);
            this.editPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.editPrice.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.editPrice.Name = "editPrice";
            this.editPrice.Size = new System.Drawing.Size(224, 24);
            this.editPrice.TabIndex = 1;
            // 
            // editProducer
            // 
            this.editProducer.Location = new System.Drawing.Point(218, 181);
            this.editProducer.Name = "editProducer";
            this.editProducer.Size = new System.Drawing.Size(224, 24);
            this.editProducer.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 18);
            this.label14.TabIndex = 11;
            this.label14.Text = "Производитель";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Название заболевания";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Количество на складе";
            // 
            // editDisease
            // 
            this.editDisease.Location = new System.Drawing.Point(218, 72);
            this.editDisease.Name = "editDisease";
            this.editDisease.Size = new System.Drawing.Size(224, 24);
            this.editDisease.TabIndex = 2;
            // 
            // editQuantity
            // 
            this.editQuantity.Location = new System.Drawing.Point(218, 126);
            this.editQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.editQuantity.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.editQuantity.Name = "editQuantity";
            this.editQuantity.Size = new System.Drawing.Size(224, 24);
            this.editQuantity.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(22, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 72);
            this.panel1.TabIndex = 13;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(218, 19);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(224, 24);
            this.search.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Название препарата";
            // 
            // EditRecord
            // 
            this.EditRecord.BackColor = System.Drawing.Color.SeaGreen;
            this.EditRecord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditRecord.Location = new System.Drawing.Point(160, 391);
            this.EditRecord.Name = "EditRecord";
            this.EditRecord.Size = new System.Drawing.Size(200, 41);
            this.EditRecord.TabIndex = 12;
            this.EditRecord.Text = "Редактировать запись";
            this.EditRecord.UseVisualStyleBackColor = false;
            this.EditRecord.Click += new System.EventHandler(this.EditRecord_Click);
            // 
            // OpenDB
            // 
            this.OpenDB.BackColor = System.Drawing.Color.SeaGreen;
            this.OpenDB.FlatAppearance.BorderSize = 0;
            this.OpenDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDB.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.OpenDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenDB.Location = new System.Drawing.Point(246, -4);
            this.OpenDB.Name = "OpenDB";
            this.OpenDB.Size = new System.Drawing.Size(224, 42);
            this.OpenDB.TabIndex = 1;
            this.OpenDB.Text = "Открыть";
            this.OpenDB.UseVisualStyleBackColor = false;
            this.OpenDB.Click += new System.EventHandler(this.OpenDB_Click);
            // 
            // ReportDB
            // 
            this.ReportDB.BackColor = System.Drawing.Color.SeaGreen;
            this.ReportDB.FlatAppearance.BorderSize = 0;
            this.ReportDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportDB.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.ReportDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReportDB.Location = new System.Drawing.Point(465, -5);
            this.ReportDB.Name = "ReportDB";
            this.ReportDB.Size = new System.Drawing.Size(363, 42);
            this.ReportDB.TabIndex = 2;
            this.ReportDB.Text = "Сформировать отчет";
            this.ReportDB.UseVisualStyleBackColor = false;
            this.ReportDB.Click += new System.EventHandler(this.ReportDB_Click);
            // 
            // DeleteDB
            // 
            this.DeleteDB.BackColor = System.Drawing.Color.SeaGreen;
            this.DeleteDB.FlatAppearance.BorderSize = 0;
            this.DeleteDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDB.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.DeleteDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteDB.Location = new System.Drawing.Point(822, -5);
            this.DeleteDB.Name = "DeleteDB";
            this.DeleteDB.Size = new System.Drawing.Size(194, 42);
            this.DeleteDB.TabIndex = 3;
            this.DeleteDB.Text = "Удалить";
            this.DeleteDB.UseVisualStyleBackColor = false;
            this.DeleteDB.Click += new System.EventHandler(this.DeleteDB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.CreateDB);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.OpenDB);
            this.groupBox1.Controls.Add(this.DeleteDB);
            this.groupBox1.Controls.Add(this.ReportDB);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code SemiLight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 37);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CreateDB
            // 
            this.CreateDB.BackColor = System.Drawing.Color.SeaGreen;
            this.CreateDB.FlatAppearance.BorderSize = 0;
            this.CreateDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateDB.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateDB.Location = new System.Drawing.Point(0, -5);
            this.CreateDB.Name = "CreateDB";
            this.CreateDB.Size = new System.Drawing.Size(248, 42);
            this.CreateDB.TabIndex = 5;
            this.CreateDB.Text = "Создать";
            this.CreateDB.UseVisualStyleBackColor = false;
            this.CreateDB.Click += new System.EventHandler(this.CreateDB_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.SeaGreen;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1013, -5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(213, 43);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RecordTable
            // 
            this.RecordTable.AllowUserToAddRows = false;
            this.RecordTable.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.RecordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordTable.Location = new System.Drawing.Point(560, 91);
            this.RecordTable.Name = "RecordTable";
            this.RecordTable.ReadOnly = true;
            this.RecordTable.RowHeadersVisible = false;
            this.RecordTable.RowHeadersWidth = 51;
            this.RecordTable.RowTemplate.Height = 24;
            this.RecordTable.Size = new System.Drawing.Size(678, 495);
            this.RecordTable.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(750, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "База данных \"Аптечный учет\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1269, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecordTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Аптечный учет";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPrice)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.higherBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBound)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OpenDB;
        private System.Windows.Forms.Button ReportDB;
        private System.Windows.Forms.Button DeleteDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView RecordTable;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addDisease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addProducer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown addQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddRecord;
        private System.Windows.Forms.Button CreateDB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.TextBox deleteName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button FindRecord;
        private System.Windows.Forms.TextBox findName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button FilterRecord;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown higherBound;
        private System.Windows.Forms.NumericUpDown lowerBound;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton decreasingOrder;
        private System.Windows.Forms.RadioButton increasingOrder;
        private System.Windows.Forms.Button SortRecord;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox editDisease;
        private System.Windows.Forms.NumericUpDown editPrice;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox editProducer;
        private System.Windows.Forms.NumericUpDown editQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button EditRecord;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancelFilter;
        private System.Windows.Forms.Button CancelSort;
        private System.Windows.Forms.Button CancelFind;
        private System.Windows.Forms.ComboBox sortParams;
        private System.Windows.Forms.ComboBox filterParam;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox filterWord;
    }
}