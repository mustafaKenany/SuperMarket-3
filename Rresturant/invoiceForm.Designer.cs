namespace Rresturant
{
    partial class invoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoiceForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel_ShowItmes = new System.Windows.Forms.Panel();
            this.label_invoiceNO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_InsideRestrant = new System.Windows.Forms.Button();
            this.btn_OutSideRestrant = new System.Windows.Forms.Button();
            this.btn_ShowIAllitems = new System.Windows.Forms.Button();
            this.tableLayoutPanel_MainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_displayItems = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel_ShowTablesAndCategory = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_DisplayTables = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_DisplayCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_OrderDetail = new System.Windows.Forms.DataGridView();
            this.Column_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ItemPCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_deleteItemPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panel_ShowItmes.SuspendLayout();
            this.tableLayoutPanel_MainContainer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel_ShowTablesAndCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderDetail)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            this.panel_Header.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(614, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "البيع المباشر";
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
            // panel_ShowItmes
            // 
            this.panel_ShowItmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel_ShowItmes.Controls.Add(this.label_invoiceNO);
            this.panel_ShowItmes.Controls.Add(this.label6);
            this.panel_ShowItmes.Controls.Add(this.btn_InsideRestrant);
            this.panel_ShowItmes.Controls.Add(this.btn_OutSideRestrant);
            this.panel_ShowItmes.Controls.Add(this.btn_ShowIAllitems);
            this.panel_ShowItmes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ShowItmes.Location = new System.Drawing.Point(0, 45);
            this.panel_ShowItmes.Name = "panel_ShowItmes";
            this.panel_ShowItmes.Size = new System.Drawing.Size(1300, 60);
            this.panel_ShowItmes.TabIndex = 2;
            // 
            // label_invoiceNO
            // 
            this.label_invoiceNO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_invoiceNO.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_invoiceNO.ForeColor = System.Drawing.Color.White;
            this.label_invoiceNO.Location = new System.Drawing.Point(74, 27);
            this.label_invoiceNO.Name = "label_invoiceNO";
            this.label_invoiceNO.Size = new System.Drawing.Size(91, 27);
            this.label_invoiceNO.TabIndex = 4;
            this.label_invoiceNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(171, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "فاتورة رقم";
            // 
            // btn_InsideRestrant
            // 
            this.btn_InsideRestrant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_InsideRestrant.AutoSize = true;
            this.btn_InsideRestrant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_InsideRestrant.FlatAppearance.BorderSize = 2;
            this.btn_InsideRestrant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_InsideRestrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsideRestrant.Font = new System.Drawing.Font("Changa", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsideRestrant.ForeColor = System.Drawing.Color.White;
            this.btn_InsideRestrant.Location = new System.Drawing.Point(339, 4);
            this.btn_InsideRestrant.Name = "btn_InsideRestrant";
            this.btn_InsideRestrant.Size = new System.Drawing.Size(83, 50);
            this.btn_InsideRestrant.TabIndex = 2;
            this.btn_InsideRestrant.Text = "صـــــالــة";
            this.btn_InsideRestrant.UseVisualStyleBackColor = true;
            this.btn_InsideRestrant.Click += new System.EventHandler(this.btn_InsideRestrant_Click);
            // 
            // btn_OutSideRestrant
            // 
            this.btn_OutSideRestrant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OutSideRestrant.AutoSize = true;
            this.btn_OutSideRestrant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_OutSideRestrant.FlatAppearance.BorderSize = 2;
            this.btn_OutSideRestrant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_OutSideRestrant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutSideRestrant.Font = new System.Drawing.Font("Changa", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OutSideRestrant.ForeColor = System.Drawing.Color.White;
            this.btn_OutSideRestrant.Location = new System.Drawing.Point(922, 4);
            this.btn_OutSideRestrant.Name = "btn_OutSideRestrant";
            this.btn_OutSideRestrant.Size = new System.Drawing.Size(93, 50);
            this.btn_OutSideRestrant.TabIndex = 1;
            this.btn_OutSideRestrant.Text = "ســـــفـــري";
            this.btn_OutSideRestrant.UseVisualStyleBackColor = true;
            this.btn_OutSideRestrant.Click += new System.EventHandler(this.btn_OutSideRestrant_Click);
            // 
            // btn_ShowIAllitems
            // 
            this.btn_ShowIAllitems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ShowIAllitems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_ShowIAllitems.FlatAppearance.BorderSize = 2;
            this.btn_ShowIAllitems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_ShowIAllitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowIAllitems.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowIAllitems.ForeColor = System.Drawing.Color.White;
            this.btn_ShowIAllitems.Location = new System.Drawing.Point(548, 4);
            this.btn_ShowIAllitems.Name = "btn_ShowIAllitems";
            this.btn_ShowIAllitems.Size = new System.Drawing.Size(222, 50);
            this.btn_ShowIAllitems.TabIndex = 0;
            this.btn_ShowIAllitems.Text = "عرض الاصناف والطاولات";
            this.btn_ShowIAllitems.UseVisualStyleBackColor = true;
            this.btn_ShowIAllitems.Click += new System.EventHandler(this.btn_ShowIAllitems_Click);
            // 
            // tableLayoutPanel_MainContainer
            // 
            this.tableLayoutPanel_MainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tableLayoutPanel_MainContainer.ColumnCount = 3;
            this.tableLayoutPanel_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel_MainContainer.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel_MainContainer.Controls.Add(this.tableLayoutPanel_ShowTablesAndCategory, 2, 0);
            this.tableLayoutPanel_MainContainer.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MainContainer.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel_MainContainer.Name = "tableLayoutPanel_MainContainer";
            this.tableLayoutPanel_MainContainer.RowCount = 1;
            this.tableLayoutPanel_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MainContainer.Size = new System.Drawing.Size(1300, 513);
            this.tableLayoutPanel_MainContainer.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel_displayItems);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Changa Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(470, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(412, 513);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اختيار المواد";
            // 
            // flowLayoutPanel_displayItems
            // 
            this.flowLayoutPanel_displayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_displayItems.Location = new System.Drawing.Point(1, 25);
            this.flowLayoutPanel_displayItems.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_displayItems.Name = "flowLayoutPanel_displayItems";
            this.flowLayoutPanel_displayItems.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flowLayoutPanel_displayItems.Size = new System.Drawing.Size(410, 487);
            this.flowLayoutPanel_displayItems.TabIndex = 0;
            // 
            // tableLayoutPanel_ShowTablesAndCategory
            // 
            this.tableLayoutPanel_ShowTablesAndCategory.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel_ShowTablesAndCategory.ColumnCount = 1;
            this.tableLayoutPanel_ShowTablesAndCategory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ShowTablesAndCategory.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel_ShowTablesAndCategory.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel_ShowTablesAndCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ShowTablesAndCategory.Location = new System.Drawing.Point(887, 3);
            this.tableLayoutPanel_ShowTablesAndCategory.Name = "tableLayoutPanel_ShowTablesAndCategory";
            this.tableLayoutPanel_ShowTablesAndCategory.RowCount = 2;
            this.tableLayoutPanel_ShowTablesAndCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ShowTablesAndCategory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ShowTablesAndCategory.Size = new System.Drawing.Size(410, 507);
            this.tableLayoutPanel_ShowTablesAndCategory.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel_DisplayTables);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Changa Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 253);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(410, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختيار طاولات";
            // 
            // flowLayoutPanel_DisplayTables
            // 
            this.flowLayoutPanel_DisplayTables.AutoScroll = true;
            this.flowLayoutPanel_DisplayTables.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.flowLayoutPanel_DisplayTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_DisplayTables.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_DisplayTables.Location = new System.Drawing.Point(1, 24);
            this.flowLayoutPanel_DisplayTables.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_DisplayTables.Name = "flowLayoutPanel_DisplayTables";
            this.flowLayoutPanel_DisplayTables.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flowLayoutPanel_DisplayTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel_DisplayTables.Size = new System.Drawing.Size(408, 229);
            this.flowLayoutPanel_DisplayTables.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel_DisplayCategory);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Changa Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(410, 253);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اختيار الاصناف";
            // 
            // flowLayoutPanel_DisplayCategory
            // 
            this.flowLayoutPanel_DisplayCategory.AutoScroll = true;
            this.flowLayoutPanel_DisplayCategory.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.flowLayoutPanel_DisplayCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_DisplayCategory.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_DisplayCategory.Location = new System.Drawing.Point(1, 25);
            this.flowLayoutPanel_DisplayCategory.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_DisplayCategory.Name = "flowLayoutPanel_DisplayCategory";
            this.flowLayoutPanel_DisplayCategory.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flowLayoutPanel_DisplayCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel_DisplayCategory.Size = new System.Drawing.Size(408, 227);
            this.flowLayoutPanel_DisplayCategory.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.37278F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.62722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 507);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_OrderDetail);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Changa Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(2, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(458, 371);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الطلبات";
            // 
            // dataGridView_OrderDetail
            // 
            this.dataGridView_OrderDetail.AllowUserToAddRows = false;
            this.dataGridView_OrderDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dataGridView_OrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Changa Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_OrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ItemName,
            this.Column_ItemPrice,
            this.Column_ItemPCS,
            this.Column_PriceTotal,
            this.Column_deleteItemPicture});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Changa Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_OrderDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_OrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OrderDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridView_OrderDetail.Location = new System.Drawing.Point(2, 26);
            this.dataGridView_OrderDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_OrderDetail.MultiSelect = false;
            this.dataGridView_OrderDetail.Name = "dataGridView_OrderDetail";
            this.dataGridView_OrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_OrderDetail.RowHeadersVisible = false;
            this.dataGridView_OrderDetail.RowHeadersWidth = 35;
            this.dataGridView_OrderDetail.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_OrderDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa SemiBold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_OrderDetail.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dataGridView_OrderDetail.RowTemplate.Height = 40;
            this.dataGridView_OrderDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_OrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_OrderDetail.Size = new System.Drawing.Size(454, 343);
            this.dataGridView_OrderDetail.TabIndex = 0;
            this.dataGridView_OrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrderDetail_CellContentClick);
            this.dataGridView_OrderDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OrderDetail_CellValueChanged);
            this.dataGridView_OrderDetail.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_OrderDetail_EditingControlShowing);
            // 
            // Column_ItemName
            // 
            this.Column_ItemName.HeaderText = "المادة";
            this.Column_ItemName.Name = "Column_ItemName";
            // 
            // Column_ItemPrice
            // 
            this.Column_ItemPrice.HeaderText = "السعر";
            this.Column_ItemPrice.Name = "Column_ItemPrice";
            // 
            // Column_ItemPCS
            // 
            this.Column_ItemPCS.HeaderText = "العدد";
            this.Column_ItemPCS.Name = "Column_ItemPCS";
            // 
            // Column_PriceTotal
            // 
            this.Column_PriceTotal.HeaderText = "المجمل";
            this.Column_PriceTotal.Name = "Column_PriceTotal";
            // 
            // Column_deleteItemPicture
            // 
            this.Column_deleteItemPicture.HeaderText = "";
            this.Column_deleteItemPicture.Image = ((System.Drawing.Image)(resources.GetObject("Column_deleteItemPicture.Image")));
            this.Column_deleteItemPicture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_deleteItemPicture.Name = "Column_deleteItemPicture";
            this.Column_deleteItemPicture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_deleteItemPicture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Cancel);
            this.groupBox5.Controls.Add(this.btn_Save);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txt_Discount);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txt_Total);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 374);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(456, 130);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cancel.FlatAppearance.BorderSize = 2;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(24, 62);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 62);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "الغاء الطلب";
            this.btn_Cancel.UseCompatibleTextRendering = true;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Save.FlatAppearance.BorderSize = 2;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(112, 62);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(82, 62);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "ترحيل";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(200, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "د.ع";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(200, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "د.ع";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Discount.Font = new System.Drawing.Font("Changa Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Discount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txt_Discount.Location = new System.Drawing.Point(241, 49);
            this.txt_Discount.Multiline = true;
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(100, 29);
            this.txt_Discount.TabIndex = 0;
            this.txt_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Discount.TextChanged += new System.EventHandler(this.txt_Discount_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(347, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "خصــــم القائمة";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(347, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "مجموع القائمة";
            // 
            // txt_Total
            // 
            this.txt_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Total.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.ForeColor = System.Drawing.Color.White;
            this.txt_Total.Location = new System.Drawing.Point(245, 13);
            this.txt_Total.Multiline = true;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(100, 26);
            this.txt_Total.TabIndex = 0;
            this.txt_Total.Text = "0";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // invoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1300, 618);
            this.Controls.Add(this.tableLayoutPanel_MainContainer);
            this.Controls.Add(this.panel_ShowItmes);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoiceForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panel_ShowItmes.ResumeLayout(false);
            this.panel_ShowItmes.PerformLayout();
            this.tableLayoutPanel_MainContainer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel_ShowTablesAndCategory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderDetail)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel panel_ShowItmes;
        private System.Windows.Forms.Button btn_ShowIAllitems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MainContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ShowTablesAndCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_DisplayTables;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_DisplayCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_displayItems;
        private System.Windows.Forms.Button btn_InsideRestrant;
        private System.Windows.Forms.Button btn_OutSideRestrant;
        private System.Windows.Forms.DataGridView dataGridView_OrderDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ItemPCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PriceTotal;
        private System.Windows.Forms.DataGridViewImageColumn Column_deleteItemPicture;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label_invoiceNO;
        private System.Windows.Forms.Label label6;
    }
}