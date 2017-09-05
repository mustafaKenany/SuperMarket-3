namespace Rresturant
{
    partial class Invoice_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel_MainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_items = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CancelInvoice = new System.Windows.Forms.Button();
            this.button_printInvoice = new System.Windows.Forms.Button();
            this.button_postBill = new System.Windows.Forms.Button();
            this.button_DeptRepayment = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_invoiceNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_customerName = new System.Windows.Forms.TextBox();
            this.maskedTextBox_BarCode = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel_SecondaryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_itemsWithoutBarcode = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_CategWithoutBarcode = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_displayItems = new System.Windows.Forms.DataGridView();
            this.Column_GridNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PcsQunatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_itemtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_inPostBill = new System.Windows.Forms.Button();
            this.txt_savedMoney = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label_invoiceTotalAmount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_invoiceDiscount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label_invoiceTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button_newInvoice = new System.Windows.Forms.Button();
            this.button_displayInPostBill = new System.Windows.Forms.Button();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.tableLayoutPanel_MainContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_SecondaryPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayItems)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.panel_Header.Size = new System.Drawing.Size(1300, 45);
            this.panel_Header.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(614, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "المبيـــعات";
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
            // tableLayoutPanel_MainContainer
            // 
            this.tableLayoutPanel_MainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tableLayoutPanel_MainContainer.ColumnCount = 3;
            this.tableLayoutPanel_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel_MainContainer.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_MainContainer.Controls.Add(this.tableLayoutPanel_SecondaryPanel, 1, 0);
            this.tableLayoutPanel_MainContainer.Controls.Add(this.tableLayoutPanel1, 2, 0);
            this.tableLayoutPanel_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MainContainer.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel_MainContainer.Name = "tableLayoutPanel_MainContainer";
            this.tableLayoutPanel_MainContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel_MainContainer.RowCount = 1;
            this.tableLayoutPanel_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MainContainer.Size = new System.Drawing.Size(1300, 705);
            this.tableLayoutPanel_MainContainer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.button_displayInPostBill);
            this.panel1.Controls.Add(this.button_newInvoice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.listBox_items);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_CancelInvoice);
            this.panel1.Controls.Add(this.button_printInvoice);
            this.panel1.Controls.Add(this.button_postBill);
            this.panel1.Controls.Add(this.button_DeptRepayment);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_invoiceNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_customerName);
            this.panel1.Controls.Add(this.maskedTextBox_BarCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(978, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 699);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "أســــــــم الـــــمــــــادة";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "أســـــــــــم الـــــــــزبــــــــــون";
            // 
            // listBox_items
            // 
            this.listBox_items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox_items.Enabled = false;
            this.listBox_items.Font = new System.Drawing.Font("Changa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.listBox_items.FormattingEnabled = true;
            this.listBox_items.HorizontalScrollbar = true;
            this.listBox_items.ItemHeight = 27;
            this.listBox_items.Location = new System.Drawing.Point(9, 227);
            this.listBox_items.Name = "listBox_items";
            this.listBox_items.ScrollAlwaysVisible = true;
            this.listBox_items.Size = new System.Drawing.Size(288, 193);
            this.listBox_items.TabIndex = 23;
            this.listBox_items.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_items_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقـــم الــباركـــود/BarCode";
            // 
            // button_CancelInvoice
            // 
            this.button_CancelInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_CancelInvoice.AutoSize = true;
            this.button_CancelInvoice.Enabled = false;
            this.button_CancelInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CancelInvoice.FlatAppearance.BorderSize = 2;
            this.button_CancelInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.button_CancelInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CancelInvoice.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CancelInvoice.ForeColor = System.Drawing.Color.White;
            this.button_CancelInvoice.Location = new System.Drawing.Point(188, 630);
            this.button_CancelInvoice.Name = "button_CancelInvoice";
            this.button_CancelInvoice.Size = new System.Drawing.Size(115, 62);
            this.button_CancelInvoice.TabIndex = 22;
            this.button_CancelInvoice.Text = "الغاء الفاتورة";
            this.button_CancelInvoice.UseVisualStyleBackColor = true;
            this.button_CancelInvoice.Click += new System.EventHandler(this.button_CancelInvoice_Click);
            // 
            // button_printInvoice
            // 
            this.button_printInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_printInvoice.AutoSize = true;
            this.button_printInvoice.Enabled = false;
            this.button_printInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_printInvoice.FlatAppearance.BorderSize = 2;
            this.button_printInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.button_printInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_printInvoice.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_printInvoice.ForeColor = System.Drawing.Color.White;
            this.button_printInvoice.Location = new System.Drawing.Point(26, 630);
            this.button_printInvoice.Name = "button_printInvoice";
            this.button_printInvoice.Size = new System.Drawing.Size(153, 62);
            this.button_printInvoice.TabIndex = 21;
            this.button_printInvoice.Text = "طباعة الفاتورة";
            this.button_printInvoice.UseVisualStyleBackColor = true;
            // 
            // button_postBill
            // 
            this.button_postBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_postBill.AutoSize = true;
            this.button_postBill.Enabled = false;
            this.button_postBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_postBill.FlatAppearance.BorderSize = 2;
            this.button_postBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.button_postBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_postBill.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_postBill.ForeColor = System.Drawing.Color.White;
            this.button_postBill.Location = new System.Drawing.Point(11, 556);
            this.button_postBill.Name = "button_postBill";
            this.button_postBill.Size = new System.Drawing.Size(153, 62);
            this.button_postBill.TabIndex = 20;
            this.button_postBill.Text = "ترحيل الفاتورة";
            this.button_postBill.UseVisualStyleBackColor = true;
            this.button_postBill.Click += new System.EventHandler(this.button_postBill_Click);
            // 
            // button_DeptRepayment
            // 
            this.button_DeptRepayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_DeptRepayment.AutoSize = true;
            this.button_DeptRepayment.Enabled = false;
            this.button_DeptRepayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DeptRepayment.FlatAppearance.BorderSize = 2;
            this.button_DeptRepayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.button_DeptRepayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeptRepayment.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeptRepayment.ForeColor = System.Drawing.Color.White;
            this.button_DeptRepayment.Location = new System.Drawing.Point(187, 556);
            this.button_DeptRepayment.Name = "button_DeptRepayment";
            this.button_DeptRepayment.Size = new System.Drawing.Size(115, 62);
            this.button_DeptRepayment.TabIndex = 19;
            this.button_DeptRepayment.Text = "تسديد الديون";
            this.button_DeptRepayment.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 514);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "0";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Changa Medium", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(188, 514);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 29);
            this.label14.TabIndex = 17;
            this.label14.Text = "الحساب السابق";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Changa Medium", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "مصطفى";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Changa Medium", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(212, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "المـــحاسب";
            // 
            // label_invoiceNo
            // 
            this.label_invoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_invoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_invoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label_invoiceNo.ForeColor = System.Drawing.Color.White;
            this.label_invoiceNo.Location = new System.Drawing.Point(26, 439);
            this.label_invoiceNo.Name = "label_invoiceNo";
            this.label_invoiceNo.Size = new System.Drawing.Size(181, 29);
            this.label_invoiceNo.TabIndex = 10;
            this.label_invoiceNo.Text = "000000";
            this.label_invoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Changa Medium", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(211, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "فاتورة رقم";
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_customerName.Enabled = false;
            this.textBox_customerName.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.textBox_customerName.Location = new System.Drawing.Point(9, 103);
            this.textBox_customerName.Multiline = true;
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.Size = new System.Drawing.Size(288, 36);
            this.textBox_customerName.TabIndex = 8;
            this.textBox_customerName.Text = "مستطرق";
            // 
            // maskedTextBox_BarCode
            // 
            this.maskedTextBox_BarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_BarCode.BeepOnError = true;
            this.maskedTextBox_BarCode.Culture = new System.Globalization.CultureInfo("ar-IQ");
            this.maskedTextBox_BarCode.Enabled = false;
            this.maskedTextBox_BarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_BarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.maskedTextBox_BarCode.Location = new System.Drawing.Point(9, 166);
            this.maskedTextBox_BarCode.Mask = "00000000000000000000";
            this.maskedTextBox_BarCode.Name = "maskedTextBox_BarCode";
            this.maskedTextBox_BarCode.ResetOnPrompt = false;
            this.maskedTextBox_BarCode.ResetOnSpace = false;
            this.maskedTextBox_BarCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox_BarCode.Size = new System.Drawing.Size(288, 29);
            this.maskedTextBox_BarCode.TabIndex = 4;
            this.maskedTextBox_BarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_BarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // tableLayoutPanel_SecondaryPanel
            // 
            this.tableLayoutPanel_SecondaryPanel.ColumnCount = 1;
            this.tableLayoutPanel_SecondaryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SecondaryPanel.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel_SecondaryPanel.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel_SecondaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_SecondaryPanel.Location = new System.Drawing.Point(562, 3);
            this.tableLayoutPanel_SecondaryPanel.Name = "tableLayoutPanel_SecondaryPanel";
            this.tableLayoutPanel_SecondaryPanel.RowCount = 2;
            this.tableLayoutPanel_SecondaryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SecondaryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_SecondaryPanel.Size = new System.Drawing.Size(410, 699);
            this.tableLayoutPanel_SecondaryPanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBox2.Controls.Add(this.flowLayoutPanel_itemsWithoutBarcode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Changa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مواد بدون باركود";
            // 
            // flowLayoutPanel_itemsWithoutBarcode
            // 
            this.flowLayoutPanel_itemsWithoutBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_itemsWithoutBarcode.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanel_itemsWithoutBarcode.Name = "flowLayoutPanel_itemsWithoutBarcode";
            this.flowLayoutPanel_itemsWithoutBarcode.Size = new System.Drawing.Size(398, 310);
            this.flowLayoutPanel_itemsWithoutBarcode.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBox1.Controls.Add(this.flowLayoutPanel_CategWithoutBarcode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Changa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المجاميع";
            // 
            // flowLayoutPanel_CategWithoutBarcode
            // 
            this.flowLayoutPanel_CategWithoutBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CategWithoutBarcode.Enabled = false;
            this.flowLayoutPanel_CategWithoutBarcode.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanel_CategWithoutBarcode.Name = "flowLayoutPanel_CategWithoutBarcode";
            this.flowLayoutPanel_CategWithoutBarcode.Size = new System.Drawing.Size(398, 309);
            this.flowLayoutPanel_CategWithoutBarcode.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 699);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBox3.Controls.Add(this.dataGridView_displayItems);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Changa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(547, 588);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المواد";
            // 
            // dataGridView_displayItems
            // 
            this.dataGridView_displayItems.AllowUserToAddRows = false;
            this.dataGridView_displayItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Changa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_displayItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_displayItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_GridNo,
            this.Column_itemName,
            this.Column_PcsQunatity,
            this.Column_itemPrice,
            this.Column_itemtotal,
            this.Column});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Changa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_displayItems.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView_displayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_displayItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridView_displayItems.Location = new System.Drawing.Point(3, 31);
            this.dataGridView_displayItems.Name = "dataGridView_displayItems";
            this.dataGridView_displayItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_displayItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Changa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView_displayItems.RowHeadersWidth = 35;
            this.dataGridView_displayItems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_displayItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridView_displayItems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dataGridView_displayItems.RowTemplate.Height = 35;
            this.dataGridView_displayItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_displayItems.Size = new System.Drawing.Size(541, 554);
            this.dataGridView_displayItems.TabIndex = 0;
            this.dataGridView_displayItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_displayItems_CellContentClick);
            this.dataGridView_displayItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_displayItems_CellValueChanged);
            // 
            // Column_GridNo
            // 
            this.Column_GridNo.HeaderText = "ت";
            this.Column_GridNo.Name = "Column_GridNo";
            this.Column_GridNo.ReadOnly = true;
            this.Column_GridNo.Width = 50;
            // 
            // Column_itemName
            // 
            this.Column_itemName.HeaderText = "المادة";
            this.Column_itemName.Name = "Column_itemName";
            this.Column_itemName.ReadOnly = true;
            this.Column_itemName.Width = 175;
            // 
            // Column_PcsQunatity
            // 
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            this.Column_PcsQunatity.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column_PcsQunatity.HeaderText = "الكمية";
            this.Column_PcsQunatity.Name = "Column_PcsQunatity";
            this.Column_PcsQunatity.Width = 65;
            // 
            // Column_itemPrice
            // 
            dataGridViewCellStyle18.Format = "C0";
            dataGridViewCellStyle18.NullValue = "0";
            this.Column_itemPrice.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column_itemPrice.HeaderText = "السعر";
            this.Column_itemPrice.Name = "Column_itemPrice";
            this.Column_itemPrice.ReadOnly = true;
            this.Column_itemPrice.Width = 65;
            // 
            // Column_itemtotal
            // 
            this.Column_itemtotal.HeaderText = "المجموع";
            this.Column_itemtotal.Name = "Column_itemtotal";
            this.Column_itemtotal.ReadOnly = true;
            this.Column_itemtotal.Width = 65;
            // 
            // Column
            // 
            this.Column.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column.HeaderText = "حذف";
            this.Column.Name = "Column";
            this.Column.Text = "حذف";
            this.Column.UseColumnTextForButtonValue = true;
            this.Column.Width = 65;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_inPostBill);
            this.groupBox4.Controls.Add(this.txt_savedMoney);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label_invoiceTotalAmount);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txt_invoiceDiscount);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label_invoiceTotal);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 597);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(547, 99);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // button_inPostBill
            // 
            this.button_inPostBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_inPostBill.Enabled = false;
            this.button_inPostBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_inPostBill.FlatAppearance.BorderSize = 2;
            this.button_inPostBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.button_inPostBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inPostBill.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inPostBill.ForeColor = System.Drawing.Color.White;
            this.button_inPostBill.Location = new System.Drawing.Point(3, 16);
            this.button_inPostBill.Name = "button_inPostBill";
            this.button_inPostBill.Size = new System.Drawing.Size(84, 80);
            this.button_inPostBill.TabIndex = 25;
            this.button_inPostBill.Text = "تعليق قائمة";
            this.button_inPostBill.UseVisualStyleBackColor = true;
            // 
            // txt_savedMoney
            // 
            this.txt_savedMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_savedMoney.Enabled = false;
            this.txt_savedMoney.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_savedMoney.Location = new System.Drawing.Point(93, 56);
            this.txt_savedMoney.Name = "txt_savedMoney";
            this.txt_savedMoney.Size = new System.Drawing.Size(117, 26);
            this.txt_savedMoney.TabIndex = 24;
            this.txt_savedMoney.Text = "0";
            this.txt_savedMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(212, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 26);
            this.label15.TabIndex = 23;
            this.label15.Text = "المبلغ المسدد";
            // 
            // label_invoiceTotalAmount
            // 
            this.label_invoiceTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_invoiceTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_invoiceTotalAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_invoiceTotalAmount.ForeColor = System.Drawing.Color.White;
            this.label_invoiceTotalAmount.Location = new System.Drawing.Point(93, 15);
            this.label_invoiceTotalAmount.Name = "label_invoiceTotalAmount";
            this.label_invoiceTotalAmount.Size = new System.Drawing.Size(117, 37);
            this.label_invoiceTotalAmount.TabIndex = 22;
            this.label_invoiceTotalAmount.Text = "0";
            this.label_invoiceTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(210, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 26);
            this.label16.TabIndex = 21;
            this.label16.Text = "صافي الفاتورة";
            // 
            // txt_invoiceDiscount
            // 
            this.txt_invoiceDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceDiscount.Enabled = false;
            this.txt_invoiceDiscount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceDiscount.Location = new System.Drawing.Point(309, 57);
            this.txt_invoiceDiscount.Name = "txt_invoiceDiscount";
            this.txt_invoiceDiscount.Size = new System.Drawing.Size(117, 26);
            this.txt_invoiceDiscount.TabIndex = 17;
            this.txt_invoiceDiscount.Text = "0";
            this.txt_invoiceDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(440, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 26);
            this.label17.TabIndex = 20;
            this.label17.Text = "مبلغ الخصم";
            // 
            // label_invoiceTotal
            // 
            this.label_invoiceTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_invoiceTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_invoiceTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_invoiceTotal.ForeColor = System.Drawing.Color.White;
            this.label_invoiceTotal.Location = new System.Drawing.Point(310, 15);
            this.label_invoiceTotal.Name = "label_invoiceTotal";
            this.label_invoiceTotal.Size = new System.Drawing.Size(117, 37);
            this.label_invoiceTotal.TabIndex = 18;
            this.label_invoiceTotal.Text = "0";
            this.label_invoiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(428, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 26);
            this.label18.TabIndex = 19;
            this.label18.Text = "اجمالي الفاتورة";
            // 
            // button_newInvoice
            // 
            this.button_newInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_newInvoice.AutoSize = true;
            this.button_newInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_newInvoice.FlatAppearance.BorderSize = 2;
            this.button_newInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.button_newInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newInvoice.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newInvoice.ForeColor = System.Drawing.Color.White;
            this.button_newInvoice.Location = new System.Drawing.Point(192, 11);
            this.button_newInvoice.Name = "button_newInvoice";
            this.button_newInvoice.Size = new System.Drawing.Size(115, 62);
            this.button_newInvoice.TabIndex = 24;
            this.button_newInvoice.Text = "فاتورة جديدة";
            this.button_newInvoice.UseVisualStyleBackColor = true;
            this.button_newInvoice.Click += new System.EventHandler(this.button_newInvoice_Click);
            // 
            // button_displayInPostBill
            // 
            this.button_displayInPostBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_displayInPostBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_displayInPostBill.FlatAppearance.BorderSize = 2;
            this.button_displayInPostBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.button_displayInPostBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_displayInPostBill.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_displayInPostBill.ForeColor = System.Drawing.Color.White;
            this.button_displayInPostBill.Location = new System.Drawing.Point(10, 11);
            this.button_displayInPostBill.Name = "button_displayInPostBill";
            this.button_displayInPostBill.Size = new System.Drawing.Size(112, 62);
            this.button_displayInPostBill.TabIndex = 25;
            this.button_displayInPostBill.Text = "عرض القوائم المعلقة";
            this.button_displayInPostBill.UseVisualStyleBackColor = true;
            // 
            // Invoice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.tableLayoutPanel_MainContainer);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.tableLayoutPanel_MainContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel_SecondaryPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayItems)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MainContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_BarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_customerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_postBill;
        private System.Windows.Forms.Button button_DeptRepayment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_invoiceNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_CancelInvoice;
        private System.Windows.Forms.Button button_printInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SecondaryPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_itemsWithoutBarcode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CategWithoutBarcode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_displayItems;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_savedMoney;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_invoiceTotalAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_invoiceDiscount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_invoiceTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listBox_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_GridNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PcsQunatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_itemtotal;
        private System.Windows.Forms.DataGridViewButtonColumn Column;
        private System.Windows.Forms.Button button_inPostBill;
        private System.Windows.Forms.Button button_newInvoice;
        private System.Windows.Forms.Button button_displayInPostBill;
    }
}