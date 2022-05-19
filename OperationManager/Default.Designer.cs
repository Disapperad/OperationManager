namespace OperationManager
{
    partial class Default
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_Accounts = new System.Windows.Forms.DataGridView();
            this.Grid_Accounts_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Accounts_AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Accounts_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Accounts_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Accounts_Remove = new System.Windows.Forms.Button();
            this.Accounts_Add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Accounts_Search_RadioM = new System.Windows.Forms.RadioButton();
            this.Accounts_Search_RadioB = new System.Windows.Forms.RadioButton();
            this.Accounts_Search = new System.Windows.Forms.Button();
            this.Accounts_Search_Cash = new System.Windows.Forms.TextBox();
            this.Accounts_Search_FullName = new System.Windows.Forms.TextBox();
            this.Accounts_Search_Account = new System.Windows.Forms.TextBox();
            this.Accounts_Search_ID = new System.Windows.Forms.TextBox();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Grid_Operations = new System.Windows.Forms.DataGridView();
            this.Operations_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operations_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operations_AccountFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operations_AccountTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operations_OperationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operations_OperationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operations_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Operations_Button_Add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Operations_CheckBox = new System.Windows.Forms.CheckBox();
            this.Operations_Search_Date = new System.Windows.Forms.DateTimePicker();
            this.Operations_Search_Date2 = new System.Windows.Forms.DateTimePicker();
            this.Operations_Search_To = new System.Windows.Forms.TextBox();
            this.Operations_RadioM = new System.Windows.Forms.RadioButton();
            this.Operations_RadioB = new System.Windows.Forms.RadioButton();
            this.Operations_Search = new System.Windows.Forms.Button();
            this.Operations_Search_Cash = new System.Windows.Forms.TextBox();
            this.Operations_Search_From = new System.Windows.Forms.TextBox();
            this.Operations_Search_Number = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Accounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Operations)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_Accounts
            // 
            this.Grid_Accounts.AllowUserToAddRows = false;
            this.Grid_Accounts.AllowUserToDeleteRows = false;
            this.Grid_Accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Accounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid_Accounts.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid_Accounts_ID,
            this.Grid_Accounts_AccountID,
            this.Grid_Accounts_FullName,
            this.Grid_Accounts_Cash});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Accounts.DefaultCellStyle = dataGridViewCellStyle10;
            this.Grid_Accounts.EnableHeadersVisualStyles = false;
            this.Grid_Accounts.Location = new System.Drawing.Point(6, 6);
            this.Grid_Accounts.MultiSelect = false;
            this.Grid_Accounts.Name = "Grid_Accounts";
            this.Grid_Accounts.ReadOnly = true;
            this.Grid_Accounts.RowHeadersVisible = false;
            this.Grid_Accounts.RowHeadersWidth = 51;
            this.Grid_Accounts.RowTemplate.Height = 29;
            this.Grid_Accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Accounts.ShowCellErrors = false;
            this.Grid_Accounts.ShowCellToolTips = false;
            this.Grid_Accounts.ShowEditingIcon = false;
            this.Grid_Accounts.ShowRowErrors = false;
            this.Grid_Accounts.Size = new System.Drawing.Size(946, 330);
            this.Grid_Accounts.TabIndex = 0;
            // 
            // Grid_Accounts_ID
            // 
            this.Grid_Accounts_ID.HeaderText = "ID";
            this.Grid_Accounts_ID.MinimumWidth = 6;
            this.Grid_Accounts_ID.Name = "Grid_Accounts_ID";
            this.Grid_Accounts_ID.ReadOnly = true;
            // 
            // Grid_Accounts_AccountID
            // 
            this.Grid_Accounts_AccountID.HeaderText = "Номер счёта";
            this.Grid_Accounts_AccountID.MinimumWidth = 6;
            this.Grid_Accounts_AccountID.Name = "Grid_Accounts_AccountID";
            this.Grid_Accounts_AccountID.ReadOnly = true;
            // 
            // Grid_Accounts_FullName
            // 
            this.Grid_Accounts_FullName.HeaderText = "Полное имя";
            this.Grid_Accounts_FullName.MinimumWidth = 6;
            this.Grid_Accounts_FullName.Name = "Grid_Accounts_FullName";
            this.Grid_Accounts_FullName.ReadOnly = true;
            // 
            // Grid_Accounts_Cash
            // 
            this.Grid_Accounts_Cash.HeaderText = "Количество денежных средств";
            this.Grid_Accounts_Cash.MinimumWidth = 6;
            this.Grid_Accounts_Cash.Name = "Grid_Accounts_Cash";
            this.Grid_Accounts_Cash.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Accounts_Remove);
            this.groupBox1.Controls.Add(this.Accounts_Add);
            this.groupBox1.Location = new System.Drawing.Point(6, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1280, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа со счетами";
            // 
            // Accounts_Remove
            // 
            this.Accounts_Remove.Location = new System.Drawing.Point(6, 61);
            this.Accounts_Remove.Name = "Accounts_Remove";
            this.Accounts_Remove.Size = new System.Drawing.Size(290, 29);
            this.Accounts_Remove.TabIndex = 1;
            this.Accounts_Remove.Text = "Удалить счёт";
            this.Accounts_Remove.UseVisualStyleBackColor = true;
            this.Accounts_Remove.Click += new System.EventHandler(this.Accounts_Remove_Click);
            // 
            // Accounts_Add
            // 
            this.Accounts_Add.Location = new System.Drawing.Point(6, 26);
            this.Accounts_Add.Name = "Accounts_Add";
            this.Accounts_Add.Size = new System.Drawing.Size(290, 29);
            this.Accounts_Add.TabIndex = 0;
            this.Accounts_Add.Text = "Добавить счёт";
            this.Accounts_Add.UseVisualStyleBackColor = true;
            this.Accounts_Add.Click += new System.EventHandler(this.Accounts_Add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Accounts_Search_RadioM);
            this.groupBox2.Controls.Add(this.Accounts_Search_RadioB);
            this.groupBox2.Controls.Add(this.Accounts_Search);
            this.groupBox2.Controls.Add(this.Accounts_Search_Cash);
            this.groupBox2.Controls.Add(this.Accounts_Search_FullName);
            this.groupBox2.Controls.Add(this.Accounts_Search_Account);
            this.groupBox2.Controls.Add(this.Accounts_Search_ID);
            this.groupBox2.Location = new System.Drawing.Point(958, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // Accounts_Search_RadioM
            // 
            this.Accounts_Search_RadioM.AutoSize = true;
            this.Accounts_Search_RadioM.Location = new System.Drawing.Point(6, 188);
            this.Accounts_Search_RadioM.Name = "Accounts_Search_RadioM";
            this.Accounts_Search_RadioM.Size = new System.Drawing.Size(184, 24);
            this.Accounts_Search_RadioM.TabIndex = 6;
            this.Accounts_Search_RadioM.TabStop = true;
            this.Accounts_Search_RadioM.Text = "<= Денежных средств";
            this.Accounts_Search_RadioM.UseVisualStyleBackColor = true;
            // 
            // Accounts_Search_RadioB
            // 
            this.Accounts_Search_RadioB.AutoSize = true;
            this.Accounts_Search_RadioB.Checked = true;
            this.Accounts_Search_RadioB.Location = new System.Drawing.Point(6, 158);
            this.Accounts_Search_RadioB.Name = "Accounts_Search_RadioB";
            this.Accounts_Search_RadioB.Size = new System.Drawing.Size(184, 24);
            this.Accounts_Search_RadioB.TabIndex = 5;
            this.Accounts_Search_RadioB.TabStop = true;
            this.Accounts_Search_RadioB.Text = ">= Денежных средств";
            this.Accounts_Search_RadioB.UseVisualStyleBackColor = true;
            // 
            // Accounts_Search
            // 
            this.Accounts_Search.Location = new System.Drawing.Point(6, 214);
            this.Accounts_Search.Name = "Accounts_Search";
            this.Accounts_Search.Size = new System.Drawing.Size(322, 32);
            this.Accounts_Search.TabIndex = 4;
            this.Accounts_Search.Text = "Поиск";
            this.Accounts_Search.UseVisualStyleBackColor = true;
            this.Accounts_Search.Click += new System.EventHandler(this.Accounts_Search_Click);
            // 
            // Accounts_Search_Cash
            // 
            this.Accounts_Search_Cash.Location = new System.Drawing.Point(6, 125);
            this.Accounts_Search_Cash.Name = "Accounts_Search_Cash";
            this.Accounts_Search_Cash.PlaceholderText = "Количество денежных средств";
            this.Accounts_Search_Cash.Size = new System.Drawing.Size(322, 27);
            this.Accounts_Search_Cash.TabIndex = 3;
            // 
            // Accounts_Search_FullName
            // 
            this.Accounts_Search_FullName.Location = new System.Drawing.Point(6, 92);
            this.Accounts_Search_FullName.Name = "Accounts_Search_FullName";
            this.Accounts_Search_FullName.PlaceholderText = "Полное имя";
            this.Accounts_Search_FullName.Size = new System.Drawing.Size(322, 27);
            this.Accounts_Search_FullName.TabIndex = 2;
            // 
            // Accounts_Search_Account
            // 
            this.Accounts_Search_Account.Location = new System.Drawing.Point(6, 59);
            this.Accounts_Search_Account.Name = "Accounts_Search_Account";
            this.Accounts_Search_Account.PlaceholderText = "Номер счёта";
            this.Accounts_Search_Account.Size = new System.Drawing.Size(322, 27);
            this.Accounts_Search_Account.TabIndex = 1;
            // 
            // Accounts_Search_ID
            // 
            this.Accounts_Search_ID.Location = new System.Drawing.Point(6, 26);
            this.Accounts_Search_ID.Name = "Accounts_Search_ID";
            this.Accounts_Search_ID.PlaceholderText = "Номер записи";
            this.Accounts_Search_ID.Size = new System.Drawing.Size(322, 27);
            this.Accounts_Search_ID.TabIndex = 0;
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Location = new System.Drawing.Point(12, 12);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1306, 543);
            this.tabcontrol.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Grid_Operations);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1298, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Операции";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Grid_Operations
            // 
            this.Grid_Operations.AllowUserToAddRows = false;
            this.Grid_Operations.AllowUserToDeleteRows = false;
            this.Grid_Operations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Operations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid_Operations.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Operations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Grid_Operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Operations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operations_ID,
            this.Operations_Type,
            this.Operations_AccountFrom,
            this.Operations_AccountTo,
            this.Operations_OperationDate,
            this.Operations_OperationTime,
            this.Operations_Cash});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Operations.DefaultCellStyle = dataGridViewCellStyle12;
            this.Grid_Operations.EnableHeadersVisualStyles = false;
            this.Grid_Operations.Location = new System.Drawing.Point(4, 6);
            this.Grid_Operations.MultiSelect = false;
            this.Grid_Operations.Name = "Grid_Operations";
            this.Grid_Operations.ReadOnly = true;
            this.Grid_Operations.RowHeadersVisible = false;
            this.Grid_Operations.RowHeadersWidth = 51;
            this.Grid_Operations.RowTemplate.Height = 29;
            this.Grid_Operations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Operations.ShowCellErrors = false;
            this.Grid_Operations.ShowCellToolTips = false;
            this.Grid_Operations.ShowEditingIcon = false;
            this.Grid_Operations.ShowRowErrors = false;
            this.Grid_Operations.Size = new System.Drawing.Size(951, 330);
            this.Grid_Operations.TabIndex = 3;
            // 
            // Operations_ID
            // 
            this.Operations_ID.HeaderText = "Номер";
            this.Operations_ID.MinimumWidth = 6;
            this.Operations_ID.Name = "Operations_ID";
            this.Operations_ID.ReadOnly = true;
            // 
            // Operations_Type
            // 
            this.Operations_Type.HeaderText = "Тип операции";
            this.Operations_Type.MinimumWidth = 6;
            this.Operations_Type.Name = "Operations_Type";
            this.Operations_Type.ReadOnly = true;
            // 
            // Operations_AccountFrom
            // 
            this.Operations_AccountFrom.HeaderText = "Откуда";
            this.Operations_AccountFrom.MinimumWidth = 6;
            this.Operations_AccountFrom.Name = "Operations_AccountFrom";
            this.Operations_AccountFrom.ReadOnly = true;
            // 
            // Operations_AccountTo
            // 
            this.Operations_AccountTo.HeaderText = "Куда";
            this.Operations_AccountTo.MinimumWidth = 6;
            this.Operations_AccountTo.Name = "Operations_AccountTo";
            this.Operations_AccountTo.ReadOnly = true;
            // 
            // Operations_OperationDate
            // 
            this.Operations_OperationDate.HeaderText = "Дата";
            this.Operations_OperationDate.MinimumWidth = 6;
            this.Operations_OperationDate.Name = "Operations_OperationDate";
            this.Operations_OperationDate.ReadOnly = true;
            // 
            // Operations_OperationTime
            // 
            this.Operations_OperationTime.HeaderText = "Время";
            this.Operations_OperationTime.MinimumWidth = 6;
            this.Operations_OperationTime.Name = "Operations_OperationTime";
            this.Operations_OperationTime.ReadOnly = true;
            // 
            // Operations_Cash
            // 
            this.Operations_Cash.HeaderText = "Количество средств";
            this.Operations_Cash.MinimumWidth = 6;
            this.Operations_Cash.Name = "Operations_Cash";
            this.Operations_Cash.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Operations_Button_Add);
            this.groupBox3.Location = new System.Drawing.Point(4, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 162);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Работа с операциями";
            // 
            // Operations_Button_Add
            // 
            this.Operations_Button_Add.Location = new System.Drawing.Point(6, 26);
            this.Operations_Button_Add.Name = "Operations_Button_Add";
            this.Operations_Button_Add.Size = new System.Drawing.Size(290, 29);
            this.Operations_Button_Add.TabIndex = 0;
            this.Operations_Button_Add.Text = "Совершить операцию";
            this.Operations_Button_Add.UseVisualStyleBackColor = true;
            this.Operations_Button_Add.Click += new System.EventHandler(this.Operations_Button_Add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.Operations_Search_To);
            this.groupBox4.Controls.Add(this.Operations_RadioM);
            this.groupBox4.Controls.Add(this.Operations_RadioB);
            this.groupBox4.Controls.Add(this.Operations_Search);
            this.groupBox4.Controls.Add(this.Operations_Search_Cash);
            this.groupBox4.Controls.Add(this.Operations_Search_From);
            this.groupBox4.Controls.Add(this.Operations_Search_Number);
            this.groupBox4.Location = new System.Drawing.Point(955, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 498);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Опциональный строгий поиск";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Operations_CheckBox);
            this.groupBox5.Controls.Add(this.Operations_Search_Date);
            this.groupBox5.Controls.Add(this.Operations_Search_Date2);
            this.groupBox5.Location = new System.Drawing.Point(6, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 131);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выбор между датами";
            // 
            // Operations_CheckBox
            // 
            this.Operations_CheckBox.AutoSize = true;
            this.Operations_CheckBox.Location = new System.Drawing.Point(6, 26);
            this.Operations_CheckBox.Name = "Operations_CheckBox";
            this.Operations_CheckBox.Size = new System.Drawing.Size(89, 24);
            this.Operations_CheckBox.TabIndex = 10;
            this.Operations_CheckBox.Text = "Активно";
            this.Operations_CheckBox.UseVisualStyleBackColor = true;
            this.Operations_CheckBox.CheckedChanged += new System.EventHandler(this.Operations_CheckBox_CheckedChanged);
            // 
            // Operations_Search_Date
            // 
            this.Operations_Search_Date.Enabled = false;
            this.Operations_Search_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Operations_Search_Date.Location = new System.Drawing.Point(6, 89);
            this.Operations_Search_Date.Name = "Operations_Search_Date";
            this.Operations_Search_Date.Size = new System.Drawing.Size(304, 27);
            this.Operations_Search_Date.TabIndex = 8;
            // 
            // Operations_Search_Date2
            // 
            this.Operations_Search_Date2.Enabled = false;
            this.Operations_Search_Date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Operations_Search_Date2.Location = new System.Drawing.Point(6, 56);
            this.Operations_Search_Date2.Name = "Operations_Search_Date2";
            this.Operations_Search_Date2.Size = new System.Drawing.Size(304, 27);
            this.Operations_Search_Date2.TabIndex = 9;
            // 
            // Operations_Search_To
            // 
            this.Operations_Search_To.Location = new System.Drawing.Point(6, 92);
            this.Operations_Search_To.Name = "Operations_Search_To";
            this.Operations_Search_To.PlaceholderText = "Счёт куда";
            this.Operations_Search_To.Size = new System.Drawing.Size(322, 27);
            this.Operations_Search_To.TabIndex = 7;
            // 
            // Operations_RadioM
            // 
            this.Operations_RadioM.AutoSize = true;
            this.Operations_RadioM.Location = new System.Drawing.Point(6, 329);
            this.Operations_RadioM.Name = "Operations_RadioM";
            this.Operations_RadioM.Size = new System.Drawing.Size(184, 24);
            this.Operations_RadioM.TabIndex = 6;
            this.Operations_RadioM.TabStop = true;
            this.Operations_RadioM.Text = "<= Денежных средств";
            this.Operations_RadioM.UseVisualStyleBackColor = true;
            // 
            // Operations_RadioB
            // 
            this.Operations_RadioB.AutoSize = true;
            this.Operations_RadioB.Checked = true;
            this.Operations_RadioB.Location = new System.Drawing.Point(6, 299);
            this.Operations_RadioB.Name = "Operations_RadioB";
            this.Operations_RadioB.Size = new System.Drawing.Size(184, 24);
            this.Operations_RadioB.TabIndex = 5;
            this.Operations_RadioB.TabStop = true;
            this.Operations_RadioB.Text = ">= Денежных средств";
            this.Operations_RadioB.UseVisualStyleBackColor = true;
            // 
            // Operations_Search
            // 
            this.Operations_Search.Location = new System.Drawing.Point(6, 359);
            this.Operations_Search.Name = "Operations_Search";
            this.Operations_Search.Size = new System.Drawing.Size(322, 32);
            this.Operations_Search.TabIndex = 4;
            this.Operations_Search.Text = "Поиск";
            this.Operations_Search.UseVisualStyleBackColor = true;
            this.Operations_Search.Click += new System.EventHandler(this.Operations_Search_Click);
            // 
            // Operations_Search_Cash
            // 
            this.Operations_Search_Cash.Location = new System.Drawing.Point(6, 266);
            this.Operations_Search_Cash.Name = "Operations_Search_Cash";
            this.Operations_Search_Cash.PlaceholderText = "Количество денежных средств";
            this.Operations_Search_Cash.Size = new System.Drawing.Size(322, 27);
            this.Operations_Search_Cash.TabIndex = 3;
            // 
            // Operations_Search_From
            // 
            this.Operations_Search_From.Location = new System.Drawing.Point(6, 59);
            this.Operations_Search_From.Name = "Operations_Search_From";
            this.Operations_Search_From.PlaceholderText = "Счёт откуда";
            this.Operations_Search_From.Size = new System.Drawing.Size(322, 27);
            this.Operations_Search_From.TabIndex = 1;
            // 
            // Operations_Search_Number
            // 
            this.Operations_Search_Number.Location = new System.Drawing.Point(6, 26);
            this.Operations_Search_Number.Name = "Operations_Search_Number";
            this.Operations_Search_Number.PlaceholderText = "Номер записи";
            this.Operations_Search_Number.Size = new System.Drawing.Size(322, 27);
            this.Operations_Search_Number.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Grid_Accounts);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1298, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счета";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 567);
            this.Controls.Add(this.tabcontrol);
            this.Name = "Default";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Accounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Operations)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Grid_Accounts;
        private GroupBox groupBox1;
        private Button Accounts_Remove;
        private Button Accounts_Add;
        private GroupBox groupBox2;
        private Button Accounts_Search;
        private TextBox Accounts_Search_Cash;
        private TextBox Accounts_Search_FullName;
        private TextBox Accounts_Search_Account;
        private TextBox Accounts_Search_ID;
        private TabControl tabcontrol;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private DataGridViewTextBoxColumn Grid_Accounts_ID;
        private DataGridViewTextBoxColumn Grid_Accounts_AccountID;
        private DataGridViewTextBoxColumn Grid_Accounts_FullName;
        private DataGridViewTextBoxColumn Grid_Accounts_Cash;
        private RadioButton Accounts_Search_RadioM;
        private RadioButton Accounts_Search_RadioB;
        private DataGridView Grid_Operations;
        private GroupBox groupBox3;
        private Button Operations_Button_Add;
        private GroupBox groupBox4;
        private RadioButton Operations_RadioM;
        private RadioButton Operations_RadioB;
        private Button Operations_Search;
        private TextBox Operations_Search_Cash;
        private TextBox Operations_Search_From;
        private TextBox Operations_Search_Number;
        private DateTimePicker Operations_Search_Date;
        private TextBox Operations_Search_To;
        private DateTimePicker Operations_Search_Date2;
        private GroupBox groupBox5;
        private CheckBox Operations_CheckBox;
        private DataGridViewTextBoxColumn Operations_ID;
        private DataGridViewTextBoxColumn Operations_Type;
        private DataGridViewTextBoxColumn Operations_AccountFrom;
        private DataGridViewTextBoxColumn Operations_AccountTo;
        private DataGridViewTextBoxColumn Operations_OperationDate;
        private DataGridViewTextBoxColumn Operations_OperationTime;
        private DataGridViewTextBoxColumn Operations_Cash;
    }
}