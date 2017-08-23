using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rresturant
{
    public partial class Invoice_Form : Form
    {
        BasicClass usedclass = new BasicClass();
        public Invoice_Form()
        {
            InitializeComponent();
            displayallCategory();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Invoice_Form.ActiveForm.Close();
        }
        /////////////////////////////////////////////////functions//////////////////

       private void displayallCategory()
        {
            flowLayoutPanel_CategWithoutBarcode.Controls.Clear();
            DataTable dt = new DataTable();
            dt = usedclass.selectdata("Get_All_Category", null);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Button btn_Item = new Button();
                btn_Item.Name = dt.Rows[i][0].ToString();       
                btn_Item.Text = dt.Rows[i][1].ToString();
                btn_Item.AutoSize = true;
                btn_Item.Height = 60;
                btn_Item.FlatStyle = FlatStyle.Flat;
                btn_Item.FlatAppearance.BorderSize = 2;
                btn_Item.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 124, 0);
                btn_Item.Font = new Font("Changa", 10, FontStyle.Regular);
                btn_Item.Click += new EventHandler(set_itemsWithoutarcode);
                flowLayoutPanel_CategWithoutBarcode.Controls.Add(btn_Item);
            }
        }

        private void set_itemsWithoutarcode(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            flowLayoutPanel_itemsWithoutBarcode.Controls.Clear();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar,50);
            param[0].Value = clickedbutton.Text;
            DataTable dt = new DataTable();
            dt = usedclass.selectdata("get_All_items_by_categoryName", param);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Button btn_Item = new Button();
                btn_Item.Name = dt.Rows[i][0].ToString();
                btn_Item.Text = dt.Rows[i][1].ToString();       
                btn_Item.AutoSize = true;
                btn_Item.Height = 60;
                btn_Item.FlatStyle = FlatStyle.Flat;
                btn_Item.FlatAppearance.BorderSize = 2;
                btn_Item.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 124, 0);
                btn_Item.Font = new Font("Changa", 10, FontStyle.Regular);
                btn_Item.Click += new EventHandler(Set_invoicGrid);
                flowLayoutPanel_itemsWithoutBarcode.Controls.Add(btn_Item);
            }
        }

        private void Set_invoicGrid(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

        }
    }
}
