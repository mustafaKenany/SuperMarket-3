namespace Rresturant
{
    partial class FinicialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinicialForm));
            this.panel_Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.panel_Header.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "الحسابات";
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 573);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الحسابات الصادرة";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الحسابات الواردة";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 54);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(986, 470);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 71);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(986, 453);
            this.dataGridView2.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(5, 28);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(177, 37);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // FinicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinicialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinicialForm";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}