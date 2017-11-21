namespace Rresturant
{
    partial class BuyReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonShowBuyInvoices = new System.Windows.Forms.Button();
            this.buttonPrintBuyGrid = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFilterBuyGrid = new System.Windows.Forms.TextBox();
            this.dataGridViewBuyGridInvoice = new System.Windows.Forms.DataGridView();
            this.CoulmnBuyInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoulmnBuyInvoiceCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoulmnBuyInvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoulmnBuyInvoiceDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoulmnBuyInvoiceTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoulmnBuyInvoiceSaveMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoulmnBuyInvoiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoulmnBuyInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuyGridInvoice)).BeginInit();
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
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(483, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "فواتير البيع";
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxFilterBuyGrid);
            this.panel2.Controls.Add(this.buttonPrintBuyGrid);
            this.panel2.Controls.Add(this.buttonShowBuyInvoices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 50);
            this.panel2.TabIndex = 4;
            // 
            // buttonShowBuyInvoices
            // 
            this.buttonShowBuyInvoices.AutoSize = true;
            this.buttonShowBuyInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.buttonShowBuyInvoices.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowBuyInvoices.Location = new System.Drawing.Point(600, 5);
            this.buttonShowBuyInvoices.Name = "buttonShowBuyInvoices";
            this.buttonShowBuyInvoices.Size = new System.Drawing.Size(100, 40);
            this.buttonShowBuyInvoices.TabIndex = 1;
            this.buttonShowBuyInvoices.Text = "عرض الفواتير";
            this.buttonShowBuyInvoices.UseVisualStyleBackColor = false;
            this.buttonShowBuyInvoices.Click += new System.EventHandler(this.buttonShowBuyInvoices_Click);
            // 
            // buttonPrintBuyGrid
            // 
            this.buttonPrintBuyGrid.AutoSize = true;
            this.buttonPrintBuyGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.buttonPrintBuyGrid.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintBuyGrid.Location = new System.Drawing.Point(475, 5);
            this.buttonPrintBuyGrid.Name = "buttonPrintBuyGrid";
            this.buttonPrintBuyGrid.Size = new System.Drawing.Size(100, 40);
            this.buttonPrintBuyGrid.TabIndex = 2;
            this.buttonPrintBuyGrid.Text = "طباعة";
            this.buttonPrintBuyGrid.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "ادخل كلمة للبحث";
            // 
            // textBoxFilterBuyGrid
            // 
            this.textBoxFilterBuyGrid.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterBuyGrid.Location = new System.Drawing.Point(21, 10);
            this.textBoxFilterBuyGrid.Name = "textBoxFilterBuyGrid";
            this.textBoxFilterBuyGrid.Size = new System.Drawing.Size(293, 32);
            this.textBoxFilterBuyGrid.TabIndex = 4;
            this.textBoxFilterBuyGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFilterBuyGrid.TextChanged += new System.EventHandler(this.textBoxFilterBuyGrid_TextChanged);
            // 
            // dataGridViewBuyGridInvoice
            // 
            this.dataGridViewBuyGridInvoice.AllowUserToAddRows = false;
            this.dataGridViewBuyGridInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewBuyGridInvoice.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBuyGridInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewBuyGridInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBuyGridInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewBuyGridInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Changa", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBuyGridInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewBuyGridInvoice.ColumnHeadersHeight = 50;
            this.dataGridViewBuyGridInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoulmnBuyInvoiceNo,
            this.CoulmnBuyInvoiceCustomer,
            this.CoulmnBuyInvoiceTotal,
            this.CoulmnBuyInvoiceDiscount,
            this.CoulmnBuyInvoiceTotalAmount,
            this.CoulmnBuyInvoiceSaveMoney,
            this.CoulmnBuyInvoiceType,
            this.CoulmnBuyInvoiceDate});
            this.dataGridViewBuyGridInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBuyGridInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridViewBuyGridInvoice.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewBuyGridInvoice.MultiSelect = false;
            this.dataGridViewBuyGridInvoice.Name = "dataGridViewBuyGridInvoice";
            this.dataGridViewBuyGridInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewBuyGridInvoice.RowHeadersVisible = false;
            this.dataGridViewBuyGridInvoice.RowHeadersWidth = 45;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBuyGridInvoice.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewBuyGridInvoice.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewBuyGridInvoice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridViewBuyGridInvoice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBuyGridInvoice.RowTemplate.Height = 40;
            this.dataGridViewBuyGridInvoice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBuyGridInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuyGridInvoice.Size = new System.Drawing.Size(1125, 600);
            this.dataGridViewBuyGridInvoice.TabIndex = 11;
            // 
            // CoulmnBuyInvoiceNo
            // 
            this.CoulmnBuyInvoiceNo.DataPropertyName = "invoiceNo";
            this.CoulmnBuyInvoiceNo.HeaderText = "رقم الفاتورة";
            this.CoulmnBuyInvoiceNo.Name = "CoulmnBuyInvoiceNo";
            this.CoulmnBuyInvoiceNo.ReadOnly = true;
            // 
            // CoulmnBuyInvoiceCustomer
            // 
            this.CoulmnBuyInvoiceCustomer.DataPropertyName = "CustomerName";
            this.CoulmnBuyInvoiceCustomer.HeaderText = "الـــــزبــــــــون";
            this.CoulmnBuyInvoiceCustomer.Name = "CoulmnBuyInvoiceCustomer";
            this.CoulmnBuyInvoiceCustomer.ReadOnly = true;
            this.CoulmnBuyInvoiceCustomer.Width = 200;
            // 
            // CoulmnBuyInvoiceTotal
            // 
            this.CoulmnBuyInvoiceTotal.DataPropertyName = "invoiceTotal";
            this.CoulmnBuyInvoiceTotal.HeaderText = "مجموع فاتورة";
            this.CoulmnBuyInvoiceTotal.Name = "CoulmnBuyInvoiceTotal";
            this.CoulmnBuyInvoiceTotal.ReadOnly = true;
            // 
            // CoulmnBuyInvoiceDiscount
            // 
            this.CoulmnBuyInvoiceDiscount.DataPropertyName = "invoiceDiscount";
            this.CoulmnBuyInvoiceDiscount.HeaderText = "خصم القائمة";
            this.CoulmnBuyInvoiceDiscount.Name = "CoulmnBuyInvoiceDiscount";
            this.CoulmnBuyInvoiceDiscount.ReadOnly = true;
            // 
            // CoulmnBuyInvoiceTotalAmount
            // 
            this.CoulmnBuyInvoiceTotalAmount.DataPropertyName = "invoiceTotalAmount";
            this.CoulmnBuyInvoiceTotalAmount.HeaderText = "صافي القائمة";
            this.CoulmnBuyInvoiceTotalAmount.Name = "CoulmnBuyInvoiceTotalAmount";
            this.CoulmnBuyInvoiceTotalAmount.ReadOnly = true;
            // 
            // CoulmnBuyInvoiceSaveMoney
            // 
            this.CoulmnBuyInvoiceSaveMoney.DataPropertyName = "saved_money";
            this.CoulmnBuyInvoiceSaveMoney.HeaderText = "المبلغ المسدد";
            this.CoulmnBuyInvoiceSaveMoney.Name = "CoulmnBuyInvoiceSaveMoney";
            this.CoulmnBuyInvoiceSaveMoney.ReadOnly = true;
            // 
            // CoulmnBuyInvoiceType
            // 
            this.CoulmnBuyInvoiceType.DataPropertyName = "Cash_or_notCash";
            this.CoulmnBuyInvoiceType.HeaderText = "نوع فاتورة";
            this.CoulmnBuyInvoiceType.Name = "CoulmnBuyInvoiceType";
            this.CoulmnBuyInvoiceType.ReadOnly = true;
            // 
            // CoulmnBuyInvoiceDate
            // 
            this.CoulmnBuyInvoiceDate.DataPropertyName = "invoiceDate";
            this.CoulmnBuyInvoiceDate.HeaderText = "تاريخ الفاتورة";
            this.CoulmnBuyInvoiceDate.Name = "CoulmnBuyInvoiceDate";
            this.CoulmnBuyInvoiceDate.ReadOnly = true;
            // 
            // BuyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 700);
            this.Controls.Add(this.dataGridViewBuyGridInvoice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 12);
            this.Name = "BuyReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BuyReportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuyGridInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonShowBuyInvoices;
        private System.Windows.Forms.Button buttonPrintBuyGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFilterBuyGrid;
        private System.Windows.Forms.DataGridView dataGridViewBuyGridInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoulmnBuyInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoulmnBuyInvoiceCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoulmnBuyInvoiceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoulmnBuyInvoiceDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoulmnBuyInvoiceTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoulmnBuyInvoiceSaveMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoulmnBuyInvoiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoulmnBuyInvoiceDate;
    }
}