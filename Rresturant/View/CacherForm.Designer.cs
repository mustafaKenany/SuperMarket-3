namespace Rresturant.View
{
    partial class CacherForm
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
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.buttonCreateInvoice = new System.Windows.Forms.Button();
            this.tableLayoutPanelMainControl = new System.Windows.Forms.TableLayoutPanel();
            this.labelBarcodeItem = new System.Windows.Forms.Label();
            this.textBoxBarCodeItem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelCreateInvoice = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInpostInvoices = new System.Windows.Forms.Button();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.listBoxitemsWithoutBarcode = new System.Windows.Forms.ListBox();
            this.labelInvoiceNo = new System.Windows.Forms.Label();
            this.textBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelOperations = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInvoicePause = new System.Windows.Forms.Button();
            this.buttonInvoiceSave = new System.Windows.Forms.Button();
            this.buttonInvoicePrint = new System.Windows.Forms.Button();
            this.buttonInvoiceCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelCategories = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelitemsWithoutBar = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelGridView = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletebtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCriticalRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelInvoiceSummery = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxTotalSaveAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPercentageTransfer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDollarSaveAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLocalSaveAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInvoiceTotal = new System.Windows.Forms.Label();
            this.textBoxTotalInvoice = new System.Windows.Forms.TextBox();
            this.radioButtonPercentageDiscount = new System.Windows.Forms.RadioButton();
            this.radioButtonDiscountAmount = new System.Windows.Forms.RadioButton();
            this.textBoxDiscountPercentage = new System.Windows.Forms.TextBox();
            this.textBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFinalAmount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelSummery2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelStockQuantity = new System.Windows.Forms.Label();
            this.textBoxStockQuantity = new System.Windows.Forms.TextBox();
            this.labelCriticalRange = new System.Windows.Forms.Label();
            this.textBoxCritiCalRange = new System.Windows.Forms.TextBox();
            this.labelExpireDate = new System.Windows.Forms.Label();
            this.textBoxExpireDate = new System.Windows.Forms.TextBox();
            this.buttonDailyReport = new System.Windows.Forms.Button();
            this.labelReminderMoney = new System.Windows.Forms.Label();
            this.textBoxReminderMoney = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.tableLayoutPanelMainControl.SuspendLayout();
            this.tableLayoutPanelCreateInvoice.SuspendLayout();
            this.tableLayoutPanelOperations.SuspendLayout();
            this.tableLayoutPanelCategories.SuspendLayout();
            this.tableLayoutPanelGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.tableLayoutPanelInvoiceSummery.SuspendLayout();
            this.tableLayoutPanelSummery2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panelTitle.Controls.Add(this.labelExit);
            this.panelTitle.Controls.Add(this.labelTitleForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1350, 30);
            this.panelTitle.TabIndex = 0;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Changa Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(1325, 1);
            this.labelExit.Margin = new System.Windows.Forms.Padding(0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(20, 27);
            this.labelExit.TabIndex = 2;
            this.labelExit.Text = "X";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Location = new System.Drawing.Point(630, 4);
            this.labelTitleForm.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(59, 22);
            this.labelTitleForm.TabIndex = 1;
            this.labelTitleForm.Text = "بيع مباشر";
            this.labelTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateInvoice
            // 
            this.buttonCreateInvoice.AutoSize = true;
            this.buttonCreateInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateInvoice.Location = new System.Drawing.Point(105, 5);
            this.buttonCreateInvoice.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCreateInvoice.Name = "buttonCreateInvoice";
            this.buttonCreateInvoice.Size = new System.Drawing.Size(90, 50);
            this.buttonCreateInvoice.TabIndex = 0;
            this.buttonCreateInvoice.Text = "فاتورة جديدة";
            this.buttonCreateInvoice.UseVisualStyleBackColor = true;
            this.buttonCreateInvoice.Click += new System.EventHandler(this.buttonCreateInvoice_Click);
            // 
            // tableLayoutPanelMainControl
            // 
            this.tableLayoutPanelMainControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelMainControl.ColumnCount = 1;
            this.tableLayoutPanelMainControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainControl.Controls.Add(this.labelBarcodeItem, 0, 3);
            this.tableLayoutPanelMainControl.Controls.Add(this.textBoxBarCodeItem, 0, 4);
            this.tableLayoutPanelMainControl.Controls.Add(this.tableLayoutPanelCreateInvoice, 0, 0);
            this.tableLayoutPanelMainControl.Controls.Add(this.labelCustomerName, 0, 1);
            this.tableLayoutPanelMainControl.Controls.Add(this.textBoxCustomerName, 0, 2);
            this.tableLayoutPanelMainControl.Controls.Add(this.labelItemName, 0, 5);
            this.tableLayoutPanelMainControl.Controls.Add(this.listBoxitemsWithoutBarcode, 0, 6);
            this.tableLayoutPanelMainControl.Controls.Add(this.labelInvoiceNo, 0, 7);
            this.tableLayoutPanelMainControl.Controls.Add(this.textBoxInvoiceNo, 0, 8);
            this.tableLayoutPanelMainControl.Controls.Add(this.labelUserName, 0, 9);
            this.tableLayoutPanelMainControl.Controls.Add(this.textBoxUserName, 0, 10);
            this.tableLayoutPanelMainControl.Controls.Add(this.labelInvoiceDate, 0, 11);
            this.tableLayoutPanelMainControl.Controls.Add(this.dateTimePickerInvoiceDate, 0, 12);
            this.tableLayoutPanelMainControl.Controls.Add(this.tableLayoutPanelOperations, 0, 13);
            this.tableLayoutPanelMainControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelMainControl.Location = new System.Drawing.Point(1150, 30);
            this.tableLayoutPanelMainControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMainControl.Name = "tableLayoutPanelMainControl";
            this.tableLayoutPanelMainControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanelMainControl.RowCount = 14;
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelMainControl.Size = new System.Drawing.Size(200, 703);
            this.tableLayoutPanelMainControl.TabIndex = 2;
            // 
            // labelBarcodeItem
            // 
            this.labelBarcodeItem.AutoSize = true;
            this.labelBarcodeItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBarcodeItem.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelBarcodeItem.Location = new System.Drawing.Point(2, 122);
            this.labelBarcodeItem.Margin = new System.Windows.Forms.Padding(2);
            this.labelBarcodeItem.Name = "labelBarcodeItem";
            this.labelBarcodeItem.Size = new System.Drawing.Size(196, 21);
            this.labelBarcodeItem.TabIndex = 6;
            this.labelBarcodeItem.Text = "بـــاركود المادة";
            this.labelBarcodeItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBarCodeItem
            // 
            this.textBoxBarCodeItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBarCodeItem.Enabled = false;
            this.textBoxBarCodeItem.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxBarCodeItem.Location = new System.Drawing.Point(3, 148);
            this.textBoxBarCodeItem.Multiline = true;
            this.textBoxBarCodeItem.Name = "textBoxBarCodeItem";
            this.textBoxBarCodeItem.Size = new System.Drawing.Size(194, 29);
            this.textBoxBarCodeItem.TabIndex = 5;
            this.textBoxBarCodeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBarCodeItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarCodeItem_KeyDown);
            // 
            // tableLayoutPanelCreateInvoice
            // 
            this.tableLayoutPanelCreateInvoice.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelCreateInvoice.ColumnCount = 2;
            this.tableLayoutPanelCreateInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCreateInvoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCreateInvoice.Controls.Add(this.buttonInpostInvoices, 1, 0);
            this.tableLayoutPanelCreateInvoice.Controls.Add(this.buttonCreateInvoice, 0, 0);
            this.tableLayoutPanelCreateInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCreateInvoice.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCreateInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCreateInvoice.Name = "tableLayoutPanelCreateInvoice";
            this.tableLayoutPanelCreateInvoice.RowCount = 1;
            this.tableLayoutPanelCreateInvoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCreateInvoice.Size = new System.Drawing.Size(200, 60);
            this.tableLayoutPanelCreateInvoice.TabIndex = 0;
            // 
            // buttonInpostInvoices
            // 
            this.buttonInpostInvoices.AutoSize = true;
            this.buttonInpostInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInpostInvoices.Enabled = false;
            this.buttonInpostInvoices.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInpostInvoices.Location = new System.Drawing.Point(5, 5);
            this.buttonInpostInvoices.Margin = new System.Windows.Forms.Padding(5);
            this.buttonInpostInvoices.Name = "buttonInpostInvoices";
            this.buttonInpostInvoices.Size = new System.Drawing.Size(90, 50);
            this.buttonInpostInvoices.TabIndex = 1;
            this.buttonInpostInvoices.Text = "فواتير معلقة";
            this.buttonInpostInvoices.UseVisualStyleBackColor = true;
            this.buttonInpostInvoices.Click += new System.EventHandler(this.buttonInpostInvoices_Click);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCustomerName.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(2, 62);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(196, 21);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "أســــم الــــزبون";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCustomerName.Enabled = false;
            this.textBoxCustomerName.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxCustomerName.Location = new System.Drawing.Point(3, 88);
            this.textBoxCustomerName.Multiline = true;
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(194, 29);
            this.textBoxCustomerName.TabIndex = 3;
            this.textBoxCustomerName.Text = "زبون خارجي";
            this.textBoxCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelItemName.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(2, 182);
            this.labelItemName.Margin = new System.Windows.Forms.Padding(2);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(196, 21);
            this.labelItemName.TabIndex = 7;
            this.labelItemName.Text = "أســـــم الــــــــمـــــــــــادة";
            this.labelItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxitemsWithoutBarcode
            // 
            this.listBoxitemsWithoutBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxitemsWithoutBarcode.Enabled = false;
            this.listBoxitemsWithoutBarcode.FormattingEnabled = true;
            this.listBoxitemsWithoutBarcode.ItemHeight = 22;
            this.listBoxitemsWithoutBarcode.Location = new System.Drawing.Point(5, 210);
            this.listBoxitemsWithoutBarcode.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxitemsWithoutBarcode.Name = "listBoxitemsWithoutBarcode";
            this.listBoxitemsWithoutBarcode.Size = new System.Drawing.Size(190, 215);
            this.listBoxitemsWithoutBarcode.TabIndex = 8;
            this.listBoxitemsWithoutBarcode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxitemsWithoutBarcode_MouseDoubleClick);
            // 
            // labelInvoiceNo
            // 
            this.labelInvoiceNo.AutoSize = true;
            this.labelInvoiceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInvoiceNo.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelInvoiceNo.Location = new System.Drawing.Point(2, 432);
            this.labelInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.labelInvoiceNo.Name = "labelInvoiceNo";
            this.labelInvoiceNo.Size = new System.Drawing.Size(196, 21);
            this.labelInvoiceNo.TabIndex = 9;
            this.labelInvoiceNo.Text = "رقم القائمة";
            this.labelInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInvoiceNo
            // 
            this.textBoxInvoiceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInvoiceNo.Location = new System.Drawing.Point(2, 457);
            this.textBoxInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.ReadOnly = true;
            this.textBoxInvoiceNo.Size = new System.Drawing.Size(196, 30);
            this.textBoxInvoiceNo.TabIndex = 10;
            this.textBoxInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserName.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(2, 487);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(196, 21);
            this.labelUserName.TabIndex = 11;
            this.labelUserName.Text = "المستخدم";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserName.Location = new System.Drawing.Point(2, 512);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(196, 30);
            this.textBoxUserName.TabIndex = 12;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInvoiceDate.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelInvoiceDate.Location = new System.Drawing.Point(2, 542);
            this.labelInvoiceDate.Margin = new System.Windows.Forms.Padding(2);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(196, 21);
            this.labelInvoiceDate.TabIndex = 13;
            this.labelInvoiceDate.Text = "تــاريــخ الـقائــمة";
            this.labelInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerInvoiceDate.Enabled = false;
            this.dateTimePickerInvoiceDate.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(2, 567);
            this.dateTimePickerInvoiceDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerInvoiceDate.RightToLeftLayout = true;
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(196, 31);
            this.dateTimePickerInvoiceDate.TabIndex = 14;
            // 
            // tableLayoutPanelOperations
            // 
            this.tableLayoutPanelOperations.ColumnCount = 2;
            this.tableLayoutPanelOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOperations.Controls.Add(this.buttonInvoicePause, 0, 0);
            this.tableLayoutPanelOperations.Controls.Add(this.buttonInvoiceSave, 0, 1);
            this.tableLayoutPanelOperations.Controls.Add(this.buttonInvoicePrint, 1, 1);
            this.tableLayoutPanelOperations.Controls.Add(this.buttonInvoiceCancel, 1, 0);
            this.tableLayoutPanelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOperations.Enabled = false;
            this.tableLayoutPanelOperations.Location = new System.Drawing.Point(3, 598);
            this.tableLayoutPanelOperations.Name = "tableLayoutPanelOperations";
            this.tableLayoutPanelOperations.RowCount = 2;
            this.tableLayoutPanelOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOperations.Size = new System.Drawing.Size(194, 114);
            this.tableLayoutPanelOperations.TabIndex = 15;
            // 
            // buttonInvoicePause
            // 
            this.buttonInvoicePause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInvoicePause.Location = new System.Drawing.Point(100, 3);
            this.buttonInvoicePause.Name = "buttonInvoicePause";
            this.buttonInvoicePause.Size = new System.Drawing.Size(91, 51);
            this.buttonInvoicePause.TabIndex = 3;
            this.buttonInvoicePause.Text = "تعليق";
            this.buttonInvoicePause.UseVisualStyleBackColor = true;
            this.buttonInvoicePause.Click += new System.EventHandler(this.buttonInvoicePause_Click);
            // 
            // buttonInvoiceSave
            // 
            this.buttonInvoiceSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInvoiceSave.Location = new System.Drawing.Point(100, 60);
            this.buttonInvoiceSave.Name = "buttonInvoiceSave";
            this.buttonInvoiceSave.Size = new System.Drawing.Size(91, 51);
            this.buttonInvoiceSave.TabIndex = 0;
            this.buttonInvoiceSave.Text = "حفظ";
            this.buttonInvoiceSave.UseVisualStyleBackColor = true;
            this.buttonInvoiceSave.Click += new System.EventHandler(this.buttonInvoiceSave_Click);
            // 
            // buttonInvoicePrint
            // 
            this.buttonInvoicePrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInvoicePrint.Location = new System.Drawing.Point(3, 60);
            this.buttonInvoicePrint.Name = "buttonInvoicePrint";
            this.buttonInvoicePrint.Size = new System.Drawing.Size(91, 51);
            this.buttonInvoicePrint.TabIndex = 1;
            this.buttonInvoicePrint.Text = "طباعة";
            this.buttonInvoicePrint.UseVisualStyleBackColor = true;
            this.buttonInvoicePrint.Click += new System.EventHandler(this.buttonInvoicePrint_Click);
            // 
            // buttonInvoiceCancel
            // 
            this.buttonInvoiceCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInvoiceCancel.Location = new System.Drawing.Point(3, 3);
            this.buttonInvoiceCancel.Name = "buttonInvoiceCancel";
            this.buttonInvoiceCancel.Size = new System.Drawing.Size(91, 51);
            this.buttonInvoiceCancel.TabIndex = 2;
            this.buttonInvoiceCancel.Text = "الغاء";
            this.buttonInvoiceCancel.UseVisualStyleBackColor = true;
            this.buttonInvoiceCancel.Click += new System.EventHandler(this.buttonInvoiceCancel_Click);
            // 
            // tableLayoutPanelCategories
            // 
            this.tableLayoutPanelCategories.ColumnCount = 1;
            this.tableLayoutPanelCategories.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCategories.Controls.Add(this.flowLayoutPanelCategories, 0, 0);
            this.tableLayoutPanelCategories.Controls.Add(this.flowLayoutPanelitemsWithoutBar, 0, 1);
            this.tableLayoutPanelCategories.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelCategories.Enabled = false;
            this.tableLayoutPanelCategories.Location = new System.Drawing.Point(675, 30);
            this.tableLayoutPanelCategories.Name = "tableLayoutPanelCategories";
            this.tableLayoutPanelCategories.RowCount = 2;
            this.tableLayoutPanelCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCategories.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCategories.Size = new System.Drawing.Size(475, 703);
            this.tableLayoutPanelCategories.TabIndex = 3;
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(108)))));
            this.flowLayoutPanelCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCategories.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(469, 345);
            this.flowLayoutPanelCategories.TabIndex = 0;
            // 
            // flowLayoutPanelitemsWithoutBar
            // 
            this.flowLayoutPanelitemsWithoutBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(108)))));
            this.flowLayoutPanelitemsWithoutBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelitemsWithoutBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelitemsWithoutBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelitemsWithoutBar.Location = new System.Drawing.Point(3, 354);
            this.flowLayoutPanelitemsWithoutBar.Name = "flowLayoutPanelitemsWithoutBar";
            this.flowLayoutPanelitemsWithoutBar.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanelitemsWithoutBar.Size = new System.Drawing.Size(469, 346);
            this.flowLayoutPanelitemsWithoutBar.TabIndex = 1;
            // 
            // tableLayoutPanelGridView
            // 
            this.tableLayoutPanelGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.tableLayoutPanelGridView.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelGridView.ColumnCount = 1;
            this.tableLayoutPanelGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGridView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelGridView.Controls.Add(this.dataGridViewItems, 0, 0);
            this.tableLayoutPanelGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelGridView.Enabled = false;
            this.tableLayoutPanelGridView.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanelGridView.Name = "tableLayoutPanelGridView";
            this.tableLayoutPanelGridView.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanelGridView.RowCount = 1;
            this.tableLayoutPanelGridView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGridView.Size = new System.Drawing.Size(675, 450);
            this.tableLayoutPanelGridView.TabIndex = 4;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCounter,
            this.ColumnItemName,
            this.ColumnItemQuantity,
            this.ColumnItemPrice,
            this.ColumnTotal,
            this.ColumnDeletebtn,
            this.ColumnExpireDate,
            this.ColumnStockQuantity,
            this.ColumnCriticalRange});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.RowHeadersWidth = 50;
            this.dataGridViewItems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewItems.RowTemplate.Height = 40;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(661, 436);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            this.dataGridViewItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellValueChanged);
            this.dataGridViewItems.SelectionChanged += new System.EventHandler(this.dataGridViewItems_SelectionChanged);
            // 
            // ColumnCounter
            // 
            this.ColumnCounter.HeaderText = "تسلسل";
            this.ColumnCounter.Name = "ColumnCounter";
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.HeaderText = "أسم المادة";
            this.ColumnItemName.Name = "ColumnItemName";
            this.ColumnItemName.Width = 175;
            // 
            // ColumnItemQuantity
            // 
            this.ColumnItemQuantity.HeaderText = "الكمية";
            this.ColumnItemQuantity.Name = "ColumnItemQuantity";
            // 
            // ColumnItemPrice
            // 
            this.ColumnItemPrice.HeaderText = "السعر";
            this.ColumnItemPrice.Name = "ColumnItemPrice";
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "المجموع";
            this.ColumnTotal.Name = "ColumnTotal";
            // 
            // ColumnDeletebtn
            // 
            this.ColumnDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDeletebtn.HeaderText = "حذف";
            this.ColumnDeletebtn.Name = "ColumnDeletebtn";
            this.ColumnDeletebtn.Text = "حذف";
            this.ColumnDeletebtn.UseColumnTextForButtonValue = true;
            this.ColumnDeletebtn.Width = 75;
            // 
            // ColumnExpireDate
            // 
            this.ColumnExpireDate.HeaderText = "تاريخ الصلاحية";
            this.ColumnExpireDate.Name = "ColumnExpireDate";
            this.ColumnExpireDate.Visible = false;
            // 
            // ColumnStockQuantity
            // 
            this.ColumnStockQuantity.HeaderText = "الرصيد المخزني";
            this.ColumnStockQuantity.Name = "ColumnStockQuantity";
            this.ColumnStockQuantity.Visible = false;
            // 
            // ColumnCriticalRange
            // 
            this.ColumnCriticalRange.HeaderText = "الرصيد الحرج";
            this.ColumnCriticalRange.Name = "ColumnCriticalRange";
            this.ColumnCriticalRange.Visible = false;
            // 
            // tableLayoutPanelInvoiceSummery
            // 
            this.tableLayoutPanelInvoiceSummery.ColumnCount = 4;
            this.tableLayoutPanelInvoiceSummery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInvoiceSummery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInvoiceSummery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInvoiceSummery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.textBoxTotalSaveAmount, 3, 3);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.textBoxPercentageTransfer, 3, 2);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.textBoxDollarSaveAmount, 3, 1);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.textBoxLocalSaveAmount, 3, 0);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.labelInvoiceTotal, 0, 0);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.textBoxTotalInvoice, 1, 0);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.radioButtonPercentageDiscount, 0, 1);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.radioButtonDiscountAmount, 0, 2);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.textBoxDiscountPercentage, 1, 1);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.textBoxDiscountAmount, 1, 2);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanelInvoiceSummery.Controls.Add(this.textBoxFinalAmount, 1, 3);
            this.tableLayoutPanelInvoiceSummery.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelInvoiceSummery.Enabled = false;
            this.tableLayoutPanelInvoiceSummery.Location = new System.Drawing.Point(0, 480);
            this.tableLayoutPanelInvoiceSummery.Name = "tableLayoutPanelInvoiceSummery";
            this.tableLayoutPanelInvoiceSummery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanelInvoiceSummery.RowCount = 4;
            this.tableLayoutPanelInvoiceSummery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInvoiceSummery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInvoiceSummery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInvoiceSummery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInvoiceSummery.Size = new System.Drawing.Size(675, 125);
            this.tableLayoutPanelInvoiceSummery.TabIndex = 5;
            // 
            // textBoxTotalSaveAmount
            // 
            this.textBoxTotalSaveAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTotalSaveAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxTotalSaveAmount.ForeColor = System.Drawing.Color.Red;
            this.textBoxTotalSaveAmount.Location = new System.Drawing.Point(1, 94);
            this.textBoxTotalSaveAmount.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxTotalSaveAmount.Name = "textBoxTotalSaveAmount";
            this.textBoxTotalSaveAmount.ReadOnly = true;
            this.textBoxTotalSaveAmount.Size = new System.Drawing.Size(169, 33);
            this.textBoxTotalSaveAmount.TabIndex = 17;
            this.textBoxTotalSaveAmount.Text = "0";
            this.textBoxTotalSaveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "مجموع مبالغ مسددة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPercentageTransfer
            // 
            this.textBoxPercentageTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPercentageTransfer.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxPercentageTransfer.ForeColor = System.Drawing.Color.Red;
            this.textBoxPercentageTransfer.Location = new System.Drawing.Point(1, 63);
            this.textBoxPercentageTransfer.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPercentageTransfer.Name = "textBoxPercentageTransfer";
            this.textBoxPercentageTransfer.ReadOnly = true;
            this.textBoxPercentageTransfer.Size = new System.Drawing.Size(169, 31);
            this.textBoxPercentageTransfer.TabIndex = 15;
            this.textBoxPercentageTransfer.Text = "0";
            this.textBoxPercentageTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "نسبة التحويل";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDollarSaveAmount
            // 
            this.textBoxDollarSaveAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDollarSaveAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxDollarSaveAmount.ForeColor = System.Drawing.Color.Red;
            this.textBoxDollarSaveAmount.Location = new System.Drawing.Point(1, 32);
            this.textBoxDollarSaveAmount.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxDollarSaveAmount.Name = "textBoxDollarSaveAmount";
            this.textBoxDollarSaveAmount.Size = new System.Drawing.Size(169, 33);
            this.textBoxDollarSaveAmount.TabIndex = 13;
            this.textBoxDollarSaveAmount.Text = "0";
            this.textBoxDollarSaveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDollarSaveAmount.TextChanged += new System.EventHandler(this.textBoxDollarSaveAmount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "مبلغ مسدد عملة اجنبية$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLocalSaveAmount
            // 
            this.textBoxLocalSaveAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLocalSaveAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxLocalSaveAmount.ForeColor = System.Drawing.Color.Red;
            this.textBoxLocalSaveAmount.Location = new System.Drawing.Point(1, 1);
            this.textBoxLocalSaveAmount.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLocalSaveAmount.Name = "textBoxLocalSaveAmount";
            this.textBoxLocalSaveAmount.Size = new System.Drawing.Size(169, 33);
            this.textBoxLocalSaveAmount.TabIndex = 11;
            this.textBoxLocalSaveAmount.Text = "0";
            this.textBoxLocalSaveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLocalSaveAmount.TextChanged += new System.EventHandler(this.textBoxLocalSaveAmount_TextChanged);
            this.textBoxLocalSaveAmount.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLocalSaveAmount_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "مبلغ مسدد عملة محلية";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInvoiceTotal
            // 
            this.labelInvoiceTotal.AutoSize = true;
            this.labelInvoiceTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInvoiceTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInvoiceTotal.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelInvoiceTotal.Location = new System.Drawing.Point(509, 2);
            this.labelInvoiceTotal.Margin = new System.Windows.Forms.Padding(2);
            this.labelInvoiceTotal.Name = "labelInvoiceTotal";
            this.labelInvoiceTotal.Size = new System.Drawing.Size(164, 27);
            this.labelInvoiceTotal.TabIndex = 2;
            this.labelInvoiceTotal.Text = "مجموع القائمة";
            this.labelInvoiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalInvoice
            // 
            this.textBoxTotalInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTotalInvoice.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxTotalInvoice.ForeColor = System.Drawing.Color.Red;
            this.textBoxTotalInvoice.Location = new System.Drawing.Point(340, 1);
            this.textBoxTotalInvoice.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxTotalInvoice.Name = "textBoxTotalInvoice";
            this.textBoxTotalInvoice.ReadOnly = true;
            this.textBoxTotalInvoice.Size = new System.Drawing.Size(166, 33);
            this.textBoxTotalInvoice.TabIndex = 3;
            this.textBoxTotalInvoice.Text = "مجموع القائمة";
            this.textBoxTotalInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonPercentageDiscount
            // 
            this.radioButtonPercentageDiscount.AutoSize = true;
            this.radioButtonPercentageDiscount.Location = new System.Drawing.Point(549, 34);
            this.radioButtonPercentageDiscount.Name = "radioButtonPercentageDiscount";
            this.radioButtonPercentageDiscount.Size = new System.Drawing.Size(123, 25);
            this.radioButtonPercentageDiscount.TabIndex = 4;
            this.radioButtonPercentageDiscount.TabStop = true;
            this.radioButtonPercentageDiscount.Text = "نــــســـبة الــــخصم";
            this.radioButtonPercentageDiscount.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiscountAmount
            // 
            this.radioButtonDiscountAmount.AutoSize = true;
            this.radioButtonDiscountAmount.Location = new System.Drawing.Point(556, 65);
            this.radioButtonDiscountAmount.Name = "radioButtonDiscountAmount";
            this.radioButtonDiscountAmount.Size = new System.Drawing.Size(116, 25);
            this.radioButtonDiscountAmount.TabIndex = 5;
            this.radioButtonDiscountAmount.TabStop = true;
            this.radioButtonDiscountAmount.Text = "مــــبــلغ الــــخصم";
            this.radioButtonDiscountAmount.UseVisualStyleBackColor = true;
            // 
            // textBoxDiscountPercentage
            // 
            this.textBoxDiscountPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscountPercentage.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxDiscountPercentage.Location = new System.Drawing.Point(340, 32);
            this.textBoxDiscountPercentage.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxDiscountPercentage.Name = "textBoxDiscountPercentage";
            this.textBoxDiscountPercentage.Size = new System.Drawing.Size(166, 33);
            this.textBoxDiscountPercentage.TabIndex = 6;
            this.textBoxDiscountPercentage.Text = "0";
            this.textBoxDiscountPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDiscountPercentage.TextChanged += new System.EventHandler(this.textBoxDiscountPercentage_TextChanged);
            // 
            // textBoxDiscountAmount
            // 
            this.textBoxDiscountAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscountAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxDiscountAmount.Location = new System.Drawing.Point(340, 63);
            this.textBoxDiscountAmount.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            this.textBoxDiscountAmount.Size = new System.Drawing.Size(166, 33);
            this.textBoxDiscountAmount.TabIndex = 7;
            this.textBoxDiscountAmount.Text = "0";
            this.textBoxDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDiscountAmount.TextChanged += new System.EventHandler(this.textBoxDiscountAmount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "صافي القائمة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFinalAmount
            // 
            this.textBoxFinalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFinalAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxFinalAmount.ForeColor = System.Drawing.Color.Red;
            this.textBoxFinalAmount.Location = new System.Drawing.Point(340, 94);
            this.textBoxFinalAmount.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFinalAmount.Name = "textBoxFinalAmount";
            this.textBoxFinalAmount.ReadOnly = true;
            this.textBoxFinalAmount.Size = new System.Drawing.Size(166, 33);
            this.textBoxFinalAmount.TabIndex = 9;
            this.textBoxFinalAmount.Text = "صافي القائمة";
            this.textBoxFinalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanelSummery2
            // 
            this.tableLayoutPanelSummery2.ColumnCount = 4;
            this.tableLayoutPanelSummery2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSummery2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSummery2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSummery2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSummery2.Controls.Add(this.labelStockQuantity, 0, 0);
            this.tableLayoutPanelSummery2.Controls.Add(this.textBoxStockQuantity, 1, 0);
            this.tableLayoutPanelSummery2.Controls.Add(this.labelCriticalRange, 0, 1);
            this.tableLayoutPanelSummery2.Controls.Add(this.textBoxCritiCalRange, 1, 1);
            this.tableLayoutPanelSummery2.Controls.Add(this.labelExpireDate, 2, 0);
            this.tableLayoutPanelSummery2.Controls.Add(this.textBoxExpireDate, 3, 0);
            this.tableLayoutPanelSummery2.Controls.Add(this.buttonDailyReport, 3, 1);
            this.tableLayoutPanelSummery2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelSummery2.Location = new System.Drawing.Point(0, 633);
            this.tableLayoutPanelSummery2.Name = "tableLayoutPanelSummery2";
            this.tableLayoutPanelSummery2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanelSummery2.RowCount = 3;
            this.tableLayoutPanelSummery2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummery2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummery2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSummery2.Size = new System.Drawing.Size(675, 100);
            this.tableLayoutPanelSummery2.TabIndex = 6;
            // 
            // labelStockQuantity
            // 
            this.labelStockQuantity.AutoSize = true;
            this.labelStockQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStockQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStockQuantity.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelStockQuantity.Location = new System.Drawing.Point(509, 2);
            this.labelStockQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.labelStockQuantity.Name = "labelStockQuantity";
            this.labelStockQuantity.Size = new System.Drawing.Size(164, 29);
            this.labelStockQuantity.TabIndex = 3;
            this.labelStockQuantity.Text = "الرصيد المخزني";
            this.labelStockQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStockQuantity
            // 
            this.textBoxStockQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStockQuantity.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxStockQuantity.ForeColor = System.Drawing.Color.Red;
            this.textBoxStockQuantity.Location = new System.Drawing.Point(340, 1);
            this.textBoxStockQuantity.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxStockQuantity.Name = "textBoxStockQuantity";
            this.textBoxStockQuantity.ReadOnly = true;
            this.textBoxStockQuantity.Size = new System.Drawing.Size(166, 33);
            this.textBoxStockQuantity.TabIndex = 4;
            this.textBoxStockQuantity.Text = "0";
            this.textBoxStockQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCriticalRange
            // 
            this.labelCriticalRange.AutoSize = true;
            this.labelCriticalRange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCriticalRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCriticalRange.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCriticalRange.Location = new System.Drawing.Point(509, 35);
            this.labelCriticalRange.Margin = new System.Windows.Forms.Padding(2);
            this.labelCriticalRange.Name = "labelCriticalRange";
            this.labelCriticalRange.Size = new System.Drawing.Size(164, 29);
            this.labelCriticalRange.TabIndex = 5;
            this.labelCriticalRange.Text = "الحد الادنى";
            this.labelCriticalRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCritiCalRange
            // 
            this.textBoxCritiCalRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCritiCalRange.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxCritiCalRange.ForeColor = System.Drawing.Color.Red;
            this.textBoxCritiCalRange.Location = new System.Drawing.Point(340, 34);
            this.textBoxCritiCalRange.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCritiCalRange.Name = "textBoxCritiCalRange";
            this.textBoxCritiCalRange.ReadOnly = true;
            this.textBoxCritiCalRange.Size = new System.Drawing.Size(166, 33);
            this.textBoxCritiCalRange.TabIndex = 6;
            this.textBoxCritiCalRange.Text = "0";
            this.textBoxCritiCalRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelExpireDate
            // 
            this.labelExpireDate.AutoSize = true;
            this.labelExpireDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExpireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExpireDate.Font = new System.Drawing.Font("Changa Medium", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelExpireDate.Location = new System.Drawing.Point(173, 2);
            this.labelExpireDate.Margin = new System.Windows.Forms.Padding(2);
            this.labelExpireDate.Name = "labelExpireDate";
            this.labelExpireDate.Size = new System.Drawing.Size(164, 29);
            this.labelExpireDate.TabIndex = 7;
            this.labelExpireDate.Text = "تاريخ انتهاء صلاحية";
            this.labelExpireDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxExpireDate
            // 
            this.textBoxExpireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExpireDate.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxExpireDate.ForeColor = System.Drawing.Color.Red;
            this.textBoxExpireDate.Location = new System.Drawing.Point(1, 1);
            this.textBoxExpireDate.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxExpireDate.Name = "textBoxExpireDate";
            this.textBoxExpireDate.ReadOnly = true;
            this.textBoxExpireDate.Size = new System.Drawing.Size(169, 33);
            this.textBoxExpireDate.TabIndex = 8;
            this.textBoxExpireDate.Text = "لايوجد";
            this.textBoxExpireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDailyReport
            // 
            this.buttonDailyReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDailyReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDailyReport.FlatAppearance.BorderSize = 2;
            this.buttonDailyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(108)))));
            this.buttonDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDailyReport.Font = new System.Drawing.Font("Changa Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonDailyReport.ForeColor = System.Drawing.Color.Red;
            this.buttonDailyReport.Location = new System.Drawing.Point(3, 36);
            this.buttonDailyReport.Name = "buttonDailyReport";
            this.tableLayoutPanelSummery2.SetRowSpan(this.buttonDailyReport, 2);
            this.buttonDailyReport.Size = new System.Drawing.Size(165, 61);
            this.buttonDailyReport.TabIndex = 9;
            this.buttonDailyReport.Text = "تقرير يومي";
            this.buttonDailyReport.UseVisualStyleBackColor = true;
            this.buttonDailyReport.Click += new System.EventHandler(this.buttonDailyReport_Click);
            // 
            // labelReminderMoney
            // 
            this.labelReminderMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReminderMoney.Font = new System.Drawing.Font("Changa Medium", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelReminderMoney.Location = new System.Drawing.Point(173, 607);
            this.labelReminderMoney.Margin = new System.Windows.Forms.Padding(2);
            this.labelReminderMoney.Name = "labelReminderMoney";
            this.labelReminderMoney.Size = new System.Drawing.Size(164, 28);
            this.labelReminderMoney.TabIndex = 17;
            this.labelReminderMoney.Text = "المبلغ المتبقي";
            this.labelReminderMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReminderMoney
            // 
            this.textBoxReminderMoney.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxReminderMoney.ForeColor = System.Drawing.Color.Red;
            this.textBoxReminderMoney.Location = new System.Drawing.Point(1, 606);
            this.textBoxReminderMoney.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxReminderMoney.Name = "textBoxReminderMoney";
            this.textBoxReminderMoney.ReadOnly = true;
            this.textBoxReminderMoney.Size = new System.Drawing.Size(169, 33);
            this.textBoxReminderMoney.TabIndex = 18;
            this.textBoxReminderMoney.Text = "0";
            this.textBoxReminderMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1350, 733);
            this.Controls.Add(this.textBoxReminderMoney);
            this.Controls.Add(this.labelReminderMoney);
            this.Controls.Add(this.tableLayoutPanelSummery2);
            this.Controls.Add(this.tableLayoutPanelInvoiceSummery);
            this.Controls.Add(this.tableLayoutPanelGridView);
            this.Controls.Add(this.tableLayoutPanelCategories);
            this.Controls.Add(this.tableLayoutPanelMainControl);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(8, 5);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(1350, 750);
            this.Name = "CacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CacherForm";
            this.Activated += new System.EventHandler(this.CacherForm_Activated);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tableLayoutPanelMainControl.ResumeLayout(false);
            this.tableLayoutPanelMainControl.PerformLayout();
            this.tableLayoutPanelCreateInvoice.ResumeLayout(false);
            this.tableLayoutPanelCreateInvoice.PerformLayout();
            this.tableLayoutPanelOperations.ResumeLayout(false);
            this.tableLayoutPanelCategories.ResumeLayout(false);
            this.tableLayoutPanelGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.tableLayoutPanelInvoiceSummery.ResumeLayout(false);
            this.tableLayoutPanelInvoiceSummery.PerformLayout();
            this.tableLayoutPanelSummery2.ResumeLayout(false);
            this.tableLayoutPanelSummery2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.Button buttonCreateInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCreateInvoice;
        private System.Windows.Forms.Button buttonInpostInvoices;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelBarcodeItem;
        private System.Windows.Forms.TextBox textBoxBarCodeItem;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.ListBox listBoxitemsWithoutBarcode;
        private System.Windows.Forms.Label labelInvoiceNo;
        private System.Windows.Forms.TextBox textBoxInvoiceNo;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOperations;
        private System.Windows.Forms.Button buttonInvoiceSave;
        private System.Windows.Forms.Button buttonInvoicePrint;
        private System.Windows.Forms.Button buttonInvoiceCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelitemsWithoutBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGridView;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInvoiceSummery;
        private System.Windows.Forms.Button buttonInvoicePause;
        private System.Windows.Forms.Label labelInvoiceTotal;
        private System.Windows.Forms.TextBox textBoxTotalInvoice;
        private System.Windows.Forms.RadioButton radioButtonPercentageDiscount;
        private System.Windows.Forms.RadioButton radioButtonDiscountAmount;
        private System.Windows.Forms.TextBox textBoxDiscountPercentage;
        private System.Windows.Forms.TextBox textBoxDiscountAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFinalAmount;
        private System.Windows.Forms.TextBox textBoxTotalSaveAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPercentageTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDollarSaveAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLocalSaveAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSummery2;
        private System.Windows.Forms.Label labelStockQuantity;
        private System.Windows.Forms.TextBox textBoxStockQuantity;
        private System.Windows.Forms.Label labelCriticalRange;
        private System.Windows.Forms.TextBox textBoxCritiCalRange;
        private System.Windows.Forms.Label labelExpireDate;
        private System.Windows.Forms.TextBox textBoxExpireDate;
        private System.Windows.Forms.Label labelReminderMoney;
        private System.Windows.Forms.TextBox textBoxReminderMoney;
        private System.Windows.Forms.Button buttonDailyReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeletebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCriticalRange;
    }
}