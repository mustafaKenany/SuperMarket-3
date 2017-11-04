namespace Rresturant
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_allcategories = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_BarCode = new System.Windows.Forms.MaskedTextBox();
            this.txt_searchByitemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_listitems = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_displayitems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Deyoon = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_savedMoney = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label_invoiceTotalAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_invoiceDiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_invoiceTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_NoCash = new System.Windows.Forms.RadioButton();
            this.radioButton_CashMoney = new System.Windows.Forms.RadioButton();
            this.txt_coustomerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_saveWithout = new System.Windows.Forms.Button();
            this.label_invoiceNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_saveinvoice = new System.Windows.Forms.Button();
            this.maskedTextBox_invoicedate = new System.Windows.Forms.MaskedTextBox();
            this.btn_newinvoice = new System.Windows.Forms.Button();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayitems)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.panel_Header.Controls.Add(this.label2);
            this.panel_Header.Controls.Add(this.Exit);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_Header.Size = new System.Drawing.Size(1000, 45);
            this.panel_Header.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "المشتريات";
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(0, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(43, 45);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 1;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Changa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 680);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "فواتير شراء";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 543);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_allcategories);
            this.groupBox1.Controls.Add(this.maskedTextBox_BarCode);
            this.groupBox1.Controls.Add(this.txt_searchByitemName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listBox_listitems);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(694, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختيار مادة";
            // 
            // comboBox_allcategories
            // 
            this.comboBox_allcategories.Enabled = false;
            this.comboBox_allcategories.FormattingEnabled = true;
            this.comboBox_allcategories.ItemHeight = 26;
            this.comboBox_allcategories.Location = new System.Drawing.Point(37, 207);
            this.comboBox_allcategories.Name = "comboBox_allcategories";
            this.comboBox_allcategories.Size = new System.Drawing.Size(230, 34);
            this.comboBox_allcategories.TabIndex = 7;
            this.comboBox_allcategories.DropDown += new System.EventHandler(this.comboBox_allcategories_DropDown);
            this.comboBox_allcategories.SelectedIndexChanged += new System.EventHandler(this.comboBox_allcategories_SelectedIndexChanged);
            // 
            // maskedTextBox_BarCode
            // 
            this.maskedTextBox_BarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_BarCode.BeepOnError = true;
            this.maskedTextBox_BarCode.Culture = new System.Globalization.CultureInfo("ar-IQ");
            this.maskedTextBox_BarCode.Enabled = false;
            this.maskedTextBox_BarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_BarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.maskedTextBox_BarCode.Location = new System.Drawing.Point(37, 62);
            this.maskedTextBox_BarCode.Mask = "00000000000000000000";
            this.maskedTextBox_BarCode.Name = "maskedTextBox_BarCode";
            this.maskedTextBox_BarCode.ResetOnPrompt = false;
            this.maskedTextBox_BarCode.ResetOnSpace = false;
            this.maskedTextBox_BarCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox_BarCode.Size = new System.Drawing.Size(230, 29);
            this.maskedTextBox_BarCode.TabIndex = 2;
            this.maskedTextBox_BarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_BarCode_KeyDown);
            // 
            // txt_searchByitemName
            // 
            this.txt_searchByitemName.Enabled = false;
            this.txt_searchByitemName.Location = new System.Drawing.Point(37, 130);
            this.txt_searchByitemName.Name = "txt_searchByitemName";
            this.txt_searchByitemName.Size = new System.Drawing.Size(230, 33);
            this.txt_searchByitemName.TabIndex = 3;
            this.txt_searchByitemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_searchByitemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_searchByitemName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "اسم المادة";
            // 
            // listBox_listitems
            // 
            this.listBox_listitems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_listitems.Enabled = false;
            this.listBox_listitems.FormattingEnabled = true;
            this.listBox_listitems.HorizontalScrollbar = true;
            this.listBox_listitems.ItemHeight = 26;
            this.listBox_listitems.Location = new System.Drawing.Point(37, 287);
            this.listBox_listitems.Name = "listBox_listitems";
            this.listBox_listitems.Size = new System.Drawing.Size(230, 236);
            this.listBox_listitems.TabIndex = 5;
            this.listBox_listitems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_listitems_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "المواد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "المجموعة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "باركود المادة/Barcode";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 537);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_displayitems);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 423);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "القائمة";
            // 
            // dataGridView_displayitems
            // 
            this.dataGridView_displayitems.AllowUserToAddRows = false;
            this.dataGridView_displayitems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_displayitems.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Changa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayitems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_displayitems.ColumnHeadersHeight = 40;
            this.dataGridView_displayitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView_displayitems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_displayitems.Enabled = false;
            this.dataGridView_displayitems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridView_displayitems.Location = new System.Drawing.Point(3, 27);
            this.dataGridView_displayitems.MultiSelect = false;
            this.dataGridView_displayitems.Name = "dataGridView_displayitems";
            this.dataGridView_displayitems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_displayitems.RowHeadersVisible = false;
            this.dataGridView_displayitems.RowHeadersWidth = 45;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.RowTemplate.Height = 40;
            this.dataGridView_displayitems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_displayitems.Size = new System.Drawing.Size(673, 393);
            this.dataGridView_displayitems.TabIndex = 6;
            this.dataGridView_displayitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_displayitems_CellContentClick);
            this.dataGridView_displayitems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_displayitems_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ت";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الـــــمادة";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الكمية";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سعر الشراء";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "المجموع";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Column6.HeaderText = "حــــذف";
            this.Column6.Name = "Column6";
            this.Column6.Text = "حــــذف";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Deyoon);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_savedMoney);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label_invoiceTotalAmount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_invoiceDiscount);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label_invoiceTotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 102);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label_Deyoon
            // 
            this.label_Deyoon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Deyoon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Deyoon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_Deyoon.ForeColor = System.Drawing.Color.White;
            this.label_Deyoon.Location = new System.Drawing.Point(6, 43);
            this.label_Deyoon.Name = "label_Deyoon";
            this.label_Deyoon.Size = new System.Drawing.Size(97, 37);
            this.label_Deyoon.TabIndex = 18;
            this.label_Deyoon.Text = "0";
            this.label_Deyoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(109, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 24);
            this.label15.TabIndex = 17;
            this.label15.Text = "طلب سابق";
            // 
            // txt_savedMoney
            // 
            this.txt_savedMoney.Enabled = false;
            this.txt_savedMoney.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_savedMoney.Location = new System.Drawing.Point(197, 64);
            this.txt_savedMoney.Name = "txt_savedMoney";
            this.txt_savedMoney.Size = new System.Drawing.Size(117, 26);
            this.txt_savedMoney.TabIndex = 16;
            this.txt_savedMoney.Text = "0";
            this.txt_savedMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_savedMoney.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_savedMoney_MouseDoubleClick);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(323, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "المبلغ المسدد";
            // 
            // label_invoiceTotalAmount
            // 
            this.label_invoiceTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_invoiceTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_invoiceTotalAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_invoiceTotalAmount.ForeColor = System.Drawing.Color.White;
            this.label_invoiceTotalAmount.Location = new System.Drawing.Point(196, 22);
            this.label_invoiceTotalAmount.Name = "label_invoiceTotalAmount";
            this.label_invoiceTotalAmount.Size = new System.Drawing.Size(117, 37);
            this.label_invoiceTotalAmount.TabIndex = 14;
            this.label_invoiceTotalAmount.Text = "0";
            this.label_invoiceTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(319, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "صافي الفاتورة";
            // 
            // txt_invoiceDiscount
            // 
            this.txt_invoiceDiscount.Enabled = false;
            this.txt_invoiceDiscount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceDiscount.Location = new System.Drawing.Point(438, 64);
            this.txt_invoiceDiscount.Name = "txt_invoiceDiscount";
            this.txt_invoiceDiscount.Size = new System.Drawing.Size(117, 26);
            this.txt_invoiceDiscount.TabIndex = 7;
            this.txt_invoiceDiscount.Text = "0";
            this.txt_invoiceDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_invoiceDiscount.TextChanged += new System.EventHandler(this.txt_invoiceDiscount_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(575, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "مبلغ الخصم";
            // 
            // label_invoiceTotal
            // 
            this.label_invoiceTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_invoiceTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_invoiceTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_invoiceTotal.ForeColor = System.Drawing.Color.White;
            this.label_invoiceTotal.Location = new System.Drawing.Point(438, 22);
            this.label_invoiceTotal.Name = "label_invoiceTotal";
            this.label_invoiceTotal.Size = new System.Drawing.Size(117, 37);
            this.label_invoiceTotal.TabIndex = 11;
            this.label_invoiceTotal.Text = "0";
            this.label_invoiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(561, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "اجمالي الفاتورة";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_NoCash);
            this.panel1.Controls.Add(this.radioButton_CashMoney);
            this.panel1.Controls.Add(this.txt_coustomerName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_saveWithout);
            this.panel1.Controls.Add(this.label_invoiceNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_saveinvoice);
            this.panel1.Controls.Add(this.maskedTextBox_invoicedate);
            this.panel1.Controls.Add(this.btn_newinvoice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 94);
            this.panel1.TabIndex = 4;
            // 
            // radioButton_NoCash
            // 
            this.radioButton_NoCash.AutoSize = true;
            this.radioButton_NoCash.Enabled = false;
            this.radioButton_NoCash.ForeColor = System.Drawing.Color.White;
            this.radioButton_NoCash.Location = new System.Drawing.Point(252, 63);
            this.radioButton_NoCash.Name = "radioButton_NoCash";
            this.radioButton_NoCash.Size = new System.Drawing.Size(48, 28);
            this.radioButton_NoCash.TabIndex = 12;
            this.radioButton_NoCash.TabStop = true;
            this.radioButton_NoCash.Text = "اجل";
            this.radioButton_NoCash.UseVisualStyleBackColor = true;
            this.radioButton_NoCash.CheckedChanged += new System.EventHandler(this.radioButton_NoCash_CheckedChanged);
            // 
            // radioButton_CashMoney
            // 
            this.radioButton_CashMoney.AutoSize = true;
            this.radioButton_CashMoney.Enabled = false;
            this.radioButton_CashMoney.ForeColor = System.Drawing.Color.White;
            this.radioButton_CashMoney.Location = new System.Drawing.Point(560, 62);
            this.radioButton_CashMoney.Name = "radioButton_CashMoney";
            this.radioButton_CashMoney.Size = new System.Drawing.Size(46, 28);
            this.radioButton_CashMoney.TabIndex = 11;
            this.radioButton_CashMoney.TabStop = true;
            this.radioButton_CashMoney.Text = "نقد";
            this.radioButton_CashMoney.UseVisualStyleBackColor = true;
            this.radioButton_CashMoney.CheckedChanged += new System.EventHandler(this.radioButton_CashMoney_CheckedChanged);
            // 
            // txt_coustomerName
            // 
            this.txt_coustomerName.Enabled = false;
            this.txt_coustomerName.Location = new System.Drawing.Point(670, 19);
            this.txt_coustomerName.Name = "txt_coustomerName";
            this.txt_coustomerName.Size = new System.Drawing.Size(230, 31);
            this.txt_coustomerName.TabIndex = 7;
            this.txt_coustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_coustomerName.Leave += new System.EventHandler(this.txt_coustomerName_Leave);
            this.txt_coustomerName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_coustomerName_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(906, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "اسم المجهز";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(112, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "تاريخ فاتورة";
            // 
            // button_saveWithout
            // 
            this.button_saveWithout.AutoSize = true;
            this.button_saveWithout.Enabled = false;
            this.button_saveWithout.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_saveWithout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button_saveWithout.Location = new System.Drawing.Point(400, 10);
            this.button_saveWithout.Name = "button_saveWithout";
            this.button_saveWithout.Size = new System.Drawing.Size(115, 40);
            this.button_saveWithout.TabIndex = 7;
            this.button_saveWithout.Text = "حفظ بدون ترحيل";
            this.button_saveWithout.UseVisualStyleBackColor = true;
            this.button_saveWithout.Click += new System.EventHandler(this.button_saveWithout_Click);
            // 
            // label_invoiceNumber
            // 
            this.label_invoiceNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_invoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_invoiceNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_invoiceNumber.ForeColor = System.Drawing.Color.White;
            this.label_invoiceNumber.Location = new System.Drawing.Point(6, 64);
            this.label_invoiceNumber.Name = "label_invoiceNumber";
            this.label_invoiceNumber.Size = new System.Drawing.Size(97, 18);
            this.label_invoiceNumber.TabIndex = 0;
            this.label_invoiceNumber.Text = "0";
            this.label_invoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "فاتورة رقم";
            // 
            // btn_saveinvoice
            // 
            this.btn_saveinvoice.AutoSize = true;
            this.btn_saveinvoice.Enabled = false;
            this.btn_saveinvoice.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_saveinvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_saveinvoice.Location = new System.Drawing.Point(300, 10);
            this.btn_saveinvoice.Name = "btn_saveinvoice";
            this.btn_saveinvoice.Size = new System.Drawing.Size(94, 40);
            this.btn_saveinvoice.TabIndex = 8;
            this.btn_saveinvoice.Text = "ترحيل فاتورة";
            this.btn_saveinvoice.UseVisualStyleBackColor = true;
            this.btn_saveinvoice.Click += new System.EventHandler(this.btn_saveinvoice_Click);
            // 
            // maskedTextBox_invoicedate
            // 
            this.maskedTextBox_invoicedate.Location = new System.Drawing.Point(6, 19);
            this.maskedTextBox_invoicedate.Mask = "00/00/0000";
            this.maskedTextBox_invoicedate.Name = "maskedTextBox_invoicedate";
            this.maskedTextBox_invoicedate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox_invoicedate.Size = new System.Drawing.Size(100, 31);
            this.maskedTextBox_invoicedate.TabIndex = 1;
            this.maskedTextBox_invoicedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_invoicedate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBox_invoicedate.ValidatingType = typeof(System.DateTime);
            // 
            // btn_newinvoice
            // 
            this.btn_newinvoice.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_newinvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_newinvoice.Location = new System.Drawing.Point(521, 10);
            this.btn_newinvoice.Name = "btn_newinvoice";
            this.btn_newinvoice.Size = new System.Drawing.Size(75, 40);
            this.btn_newinvoice.TabIndex = 1;
            this.btn_newinvoice.Text = "جديد";
            this.btn_newinvoice.UseVisualStyleBackColor = true;
            this.btn_newinvoice.Click += new System.EventHandler(this.btn_newinvoice_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 725);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SalesForm";
            this.Activated += new System.EventHandler(this.SalesForm_Activated);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayitems)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_invoicedate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saveinvoice;
        private System.Windows.Forms.Button btn_newinvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_listitems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_searchByitemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_displayitems;
        private System.Windows.Forms.Label label_invoiceNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_saveWithout;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_BarCode;
        private System.Windows.Forms.TextBox txt_coustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_Deyoon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_savedMoney;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_invoiceTotalAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_invoiceDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_invoiceTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton_NoCash;
        private System.Windows.Forms.RadioButton radioButton_CashMoney;
        private System.Windows.Forms.ComboBox comboBox_allcategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}