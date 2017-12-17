namespace Rresturant
{
    partial class SaleReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFilterSalesGrid = new System.Windows.Forms.TextBox();
            this.buttonPrintSalesGrid = new System.Windows.Forms.Button();
            this.buttonShowSaleInvoices = new System.Windows.Forms.Button();
            this.dataGridViewSaleGrid = new System.Windows.Forms.DataGridView();
            this.ColumnInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceSavedMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.checkBoxDateSearch = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 50);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "فواتير الشراء";
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(0, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(43, 50);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkBoxDateSearch);
            this.panel2.Controls.Add(this.dateTimePickerTo);
            this.panel2.Controls.Add(this.dateTimePickerFrom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxFilterSalesGrid);
            this.panel2.Controls.Add(this.buttonPrintSalesGrid);
            this.panel2.Controls.Add(this.buttonShowSaleInvoices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 75);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "ادخل كلمة للبحث";
            // 
            // textBoxFilterSalesGrid
            // 
            this.textBoxFilterSalesGrid.Font = new System.Drawing.Font("Changa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterSalesGrid.Location = new System.Drawing.Point(6, 21);
            this.textBoxFilterSalesGrid.Name = "textBoxFilterSalesGrid";
            this.textBoxFilterSalesGrid.Size = new System.Drawing.Size(293, 32);
            this.textBoxFilterSalesGrid.TabIndex = 4;
            this.textBoxFilterSalesGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFilterSalesGrid.TextChanged += new System.EventHandler(this.textBoxFilterSalesGrid_TextChanged);
            // 
            // buttonPrintSalesGrid
            // 
            this.buttonPrintSalesGrid.AutoSize = true;
            this.buttonPrintSalesGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.buttonPrintSalesGrid.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintSalesGrid.Location = new System.Drawing.Point(430, 18);
            this.buttonPrintSalesGrid.Name = "buttonPrintSalesGrid";
            this.buttonPrintSalesGrid.Size = new System.Drawing.Size(100, 40);
            this.buttonPrintSalesGrid.TabIndex = 2;
            this.buttonPrintSalesGrid.Text = "طباعة";
            this.buttonPrintSalesGrid.UseVisualStyleBackColor = false;
            // 
            // buttonShowSaleInvoices
            // 
            this.buttonShowSaleInvoices.AutoSize = true;
            this.buttonShowSaleInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.buttonShowSaleInvoices.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowSaleInvoices.Location = new System.Drawing.Point(532, 18);
            this.buttonShowSaleInvoices.Name = "buttonShowSaleInvoices";
            this.buttonShowSaleInvoices.Size = new System.Drawing.Size(100, 40);
            this.buttonShowSaleInvoices.TabIndex = 1;
            this.buttonShowSaleInvoices.Text = "عرض الفواتير";
            this.buttonShowSaleInvoices.UseVisualStyleBackColor = false;
            this.buttonShowSaleInvoices.Click += new System.EventHandler(this.buttonShowSaleInvoices_Click);
            // 
            // dataGridViewSaleGrid
            // 
            this.dataGridViewSaleGrid.AllowUserToAddRows = false;
            this.dataGridViewSaleGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSaleGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewSaleGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSaleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewSaleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Changa", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSaleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewSaleGrid.ColumnHeadersHeight = 50;
            this.dataGridViewSaleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnInvoiceNo,
            this.ColumnInvoiceCustomer,
            this.ColumnInvoiceTotal,
            this.ColumnInvoiceDiscount,
            this.ColumnInvoiceTotalAmount,
            this.ColumnInvoiceSavedMoney,
            this.ColumnInvoiceStatus,
            this.ColumnInvoiceDate,
            this.ColumnInvoiceDetail});
            this.dataGridViewSaleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSaleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridViewSaleGrid.Location = new System.Drawing.Point(0, 125);
            this.dataGridViewSaleGrid.MultiSelect = false;
            this.dataGridViewSaleGrid.Name = "dataGridViewSaleGrid";
            this.dataGridViewSaleGrid.ReadOnly = true;
            this.dataGridViewSaleGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewSaleGrid.RowHeadersVisible = false;
            this.dataGridViewSaleGrid.RowHeadersWidth = 45;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSaleGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewSaleGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSaleGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridViewSaleGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSaleGrid.RowTemplate.Height = 40;
            this.dataGridViewSaleGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSaleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSaleGrid.Size = new System.Drawing.Size(1125, 575);
            this.dataGridViewSaleGrid.TabIndex = 10;
            this.dataGridViewSaleGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSaleGrid_CellContentClick);
            // 
            // ColumnInvoiceNo
            // 
            this.ColumnInvoiceNo.DataPropertyName = "invoiceNo";
            this.ColumnInvoiceNo.HeaderText = "رقم فاتورة";
            this.ColumnInvoiceNo.Name = "ColumnInvoiceNo";
            this.ColumnInvoiceNo.ReadOnly = true;
            // 
            // ColumnInvoiceCustomer
            // 
            this.ColumnInvoiceCustomer.DataPropertyName = "CustomerName";
            this.ColumnInvoiceCustomer.HeaderText = "الـــــزبــــــــون";
            this.ColumnInvoiceCustomer.Name = "ColumnInvoiceCustomer";
            this.ColumnInvoiceCustomer.ReadOnly = true;
            this.ColumnInvoiceCustomer.Width = 200;
            // 
            // ColumnInvoiceTotal
            // 
            this.ColumnInvoiceTotal.DataPropertyName = "invoiceTotal";
            this.ColumnInvoiceTotal.HeaderText = "مجموع فاتورة";
            this.ColumnInvoiceTotal.Name = "ColumnInvoiceTotal";
            this.ColumnInvoiceTotal.ReadOnly = true;
            // 
            // ColumnInvoiceDiscount
            // 
            this.ColumnInvoiceDiscount.DataPropertyName = "invoiceDiscount";
            this.ColumnInvoiceDiscount.HeaderText = "خصم القائمة";
            this.ColumnInvoiceDiscount.Name = "ColumnInvoiceDiscount";
            this.ColumnInvoiceDiscount.ReadOnly = true;
            // 
            // ColumnInvoiceTotalAmount
            // 
            this.ColumnInvoiceTotalAmount.DataPropertyName = "invoiceTotalAmount";
            this.ColumnInvoiceTotalAmount.HeaderText = "صافي القائمة";
            this.ColumnInvoiceTotalAmount.Name = "ColumnInvoiceTotalAmount";
            this.ColumnInvoiceTotalAmount.ReadOnly = true;
            // 
            // ColumnInvoiceSavedMoney
            // 
            this.ColumnInvoiceSavedMoney.DataPropertyName = "saved_money";
            this.ColumnInvoiceSavedMoney.HeaderText = "المبلغ المسدد";
            this.ColumnInvoiceSavedMoney.Name = "ColumnInvoiceSavedMoney";
            this.ColumnInvoiceSavedMoney.ReadOnly = true;
            // 
            // ColumnInvoiceStatus
            // 
            this.ColumnInvoiceStatus.DataPropertyName = "Cash_or_notCash";
            this.ColumnInvoiceStatus.HeaderText = "نوع فاتورة";
            this.ColumnInvoiceStatus.Name = "ColumnInvoiceStatus";
            this.ColumnInvoiceStatus.ReadOnly = true;
            // 
            // ColumnInvoiceDate
            // 
            this.ColumnInvoiceDate.DataPropertyName = "invoiceDate";
            this.ColumnInvoiceDate.HeaderText = "تاريخ فاتورة";
            this.ColumnInvoiceDate.Name = "ColumnInvoiceDate";
            this.ColumnInvoiceDate.ReadOnly = true;
            // 
            // ColumnInvoiceDetail
            // 
            this.ColumnInvoiceDetail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColumnInvoiceDetail.HeaderText = "تفاصيل";
            this.ColumnInvoiceDetail.Name = "ColumnInvoiceDetail";
            this.ColumnInvoiceDetail.ReadOnly = true;
            this.ColumnInvoiceDetail.Text = "تفاصيل";
            this.ColumnInvoiceDetail.UseColumnTextForButtonValue = true;
            // 
            // checkBoxDateSearch
            // 
            this.checkBoxDateSearch.AutoSize = true;
            this.checkBoxDateSearch.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxDateSearch.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkBoxDateSearch.Location = new System.Drawing.Point(1006, 14);
            this.checkBoxDateSearch.Name = "checkBoxDateSearch";
            this.checkBoxDateSearch.Size = new System.Drawing.Size(107, 44);
            this.checkBoxDateSearch.TabIndex = 16;
            this.checkBoxDateSearch.Text = "بحث بين تاريخين";
            this.checkBoxDateSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDateSearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Changa Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(805, 41);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(164, 28);
            this.dateTimePickerTo.TabIndex = 15;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Changa Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(805, 7);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(164, 28);
            this.dateTimePickerFrom.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(975, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "من";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(974, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "الى";
            // 
            // SaleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 700);
            this.Controls.Add(this.dataGridViewSaleGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 12);
            this.Name = "SaleReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SaleReportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonShowSaleInvoices;
        private System.Windows.Forms.Button buttonPrintSalesGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFilterSalesGrid;
        private System.Windows.Forms.DataGridView dataGridViewSaleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceSavedMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceDate;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnInvoiceDetail;
        private System.Windows.Forms.CheckBox checkBoxDateSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}