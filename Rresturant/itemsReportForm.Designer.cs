namespace Rresturant
{
    partial class itemsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemsReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilteritemsGrid = new System.Windows.Forms.TextBox();
            this.button_showAllitems = new System.Windows.Forms.Button();
            this.buttonPrintitemsGrid = new System.Windows.Forms.Button();
            this.dataGridView_displayitems = new System.Windows.Forms.DataGridView();
            this.ColumnItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemLastPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayitems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "المواد";
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(0, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(42, 50);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxFilteritemsGrid);
            this.panel2.Controls.Add(this.button_showAllitems);
            this.panel2.Controls.Add(this.buttonPrintitemsGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 50);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "ادخل كلمة للبحث";
            // 
            // textBoxFilteritemsGrid
            // 
            this.textBoxFilteritemsGrid.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxFilteritemsGrid.Location = new System.Drawing.Point(12, 13);
            this.textBoxFilteritemsGrid.Name = "textBoxFilteritemsGrid";
            this.textBoxFilteritemsGrid.Size = new System.Drawing.Size(293, 30);
            this.textBoxFilteritemsGrid.TabIndex = 4;
            this.textBoxFilteritemsGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFilteritemsGrid.TextChanged += new System.EventHandler(this.textBoxFilteritemsGrid_TextChanged);
            // 
            // button_showAllitems
            // 
            this.button_showAllitems.AutoSize = true;
            this.button_showAllitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.button_showAllitems.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showAllitems.Location = new System.Drawing.Point(600, 5);
            this.button_showAllitems.Name = "button_showAllitems";
            this.button_showAllitems.Size = new System.Drawing.Size(100, 40);
            this.button_showAllitems.TabIndex = 3;
            this.button_showAllitems.Text = "عرض المواد";
            this.button_showAllitems.UseVisualStyleBackColor = false;
            this.button_showAllitems.Click += new System.EventHandler(this.button_showAllitems_Click);
            // 
            // buttonPrintitemsGrid
            // 
            this.buttonPrintitemsGrid.AutoSize = true;
            this.buttonPrintitemsGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.buttonPrintitemsGrid.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintitemsGrid.Location = new System.Drawing.Point(475, 5);
            this.buttonPrintitemsGrid.Name = "buttonPrintitemsGrid";
            this.buttonPrintitemsGrid.Size = new System.Drawing.Size(100, 40);
            this.buttonPrintitemsGrid.TabIndex = 2;
            this.buttonPrintitemsGrid.Text = "طباعة";
            this.buttonPrintitemsGrid.UseVisualStyleBackColor = false;
            // 
            // dataGridView_displayitems
            // 
            this.dataGridView_displayitems.AllowUserToAddRows = false;
            this.dataGridView_displayitems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_displayitems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_displayitems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_displayitems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Changa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayitems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_displayitems.ColumnHeadersHeight = 40;
            this.dataGridView_displayitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemID,
            this.ColumnItemName,
            this.ColumnItemCategory,
            this.ColumnItemBarCode,
            this.ColumnItemQuantity,
            this.ColumnItemBuyPrice,
            this.ColumnItemLastPriceSale});
            this.dataGridView_displayitems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_displayitems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridView_displayitems.Location = new System.Drawing.Point(0, 100);
            this.dataGridView_displayitems.MultiSelect = false;
            this.dataGridView_displayitems.Name = "dataGridView_displayitems";
            this.dataGridView_displayitems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_displayitems.RowHeadersVisible = false;
            this.dataGridView_displayitems.RowHeadersWidth = 45;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.RowTemplate.Height = 40;
            this.dataGridView_displayitems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_displayitems.Size = new System.Drawing.Size(1000, 600);
            this.dataGridView_displayitems.TabIndex = 9;
            // 
            // ColumnItemID
            // 
            this.ColumnItemID.DataPropertyName = "ItemID";
            this.ColumnItemID.HeaderText = "رمز المادة";
            this.ColumnItemID.Name = "ColumnItemID";
            this.ColumnItemID.Width = 75;
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.DataPropertyName = "ItemName";
            this.ColumnItemName.HeaderText = "الـــــمادة";
            this.ColumnItemName.Name = "ColumnItemName";
            this.ColumnItemName.Width = 250;
            // 
            // ColumnItemCategory
            // 
            this.ColumnItemCategory.DataPropertyName = "itemCategory";
            this.ColumnItemCategory.HeaderText = "الصنف";
            this.ColumnItemCategory.Name = "ColumnItemCategory";
            this.ColumnItemCategory.Width = 150;
            // 
            // ColumnItemBarCode
            // 
            this.ColumnItemBarCode.DataPropertyName = "ItemBarCode";
            this.ColumnItemBarCode.HeaderText = "الباركود";
            this.ColumnItemBarCode.Name = "ColumnItemBarCode";
            // 
            // ColumnItemQuantity
            // 
            this.ColumnItemQuantity.DataPropertyName = "itemQuantity";
            this.ColumnItemQuantity.HeaderText = "الكمية ";
            this.ColumnItemQuantity.Name = "ColumnItemQuantity";
            // 
            // ColumnItemBuyPrice
            // 
            this.ColumnItemBuyPrice.DataPropertyName = "price_for_buy";
            this.ColumnItemBuyPrice.HeaderText = "سعر البيع";
            this.ColumnItemBuyPrice.Name = "ColumnItemBuyPrice";
            // 
            // ColumnItemLastPriceSale
            // 
            this.ColumnItemLastPriceSale.DataPropertyName = "LastPrice";
            this.ColumnItemLastPriceSale.HeaderText = "اخر شراء";
            this.ColumnItemLastPriceSale.Name = "ColumnItemLastPriceSale";
            // 
            // itemsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.dataGridView_displayitems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 15);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "itemsReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "itemsReportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayitems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPrintitemsGrid;
        private System.Windows.Forms.Button button_showAllitems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilteritemsGrid;
        private System.Windows.Forms.DataGridView dataGridView_displayitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemLastPriceSale;
    }
}