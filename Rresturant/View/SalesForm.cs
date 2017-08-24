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
    public partial class SalesForm : Form
    {
        BasicClass usedclass = new BasicClass();
        DataTable dt = new DataTable();
        Int32 invoiceNumber = 0;
        int count = 1;
        public SalesForm()
        {
            InitializeComponent();
            maskedTextBox_invoicedate.Enabled = false;
            maskedTextBox_invoicedate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.dataGridView_displayitems.Columns["Column1"].ReadOnly = true;
            this.dataGridView_displayitems.Columns["Column2"].ReadOnly = true;
            this.dataGridView_displayitems.Columns["Column5"].ReadOnly = true;
            this.dataGridView_displayitems.Columns["Column5"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("ar-iq");
            this.dataGridView_displayitems.Columns["Column5"].DefaultCellStyle.Format = "C0";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            SalesForm.ActiveForm.Close();
        }

        private void btn_newinvoice_Click(object sender, EventArgs e)
        {
            maskedTextBox_invoicedate.Enabled = true;
            maskedTextBox_invoicedate.Focus();
            //get invoice number
            dt = usedclass.selectdata("get_invoice_number", null);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == "")
                {
                    invoiceNumber = 1;
                }
                else
                {
                    invoiceNumber = Convert.ToInt32(dt.Rows[i][0].ToString());
                    invoiceNumber++;
                }
            }
            label_invoiceNumber.Text = invoiceNumber.ToString();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            dt = usedclass.selectdata("Get_All_Category", null);
            //
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CatergoryName";
            comboBox1.ValueMember = "CategoryID";            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
            param[0].Value = comboBox1.Text;

            dt = usedclass.selectdata("get_All_items_by_categoryName", param);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i][1]);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            setGriditems(1);
        }

        private void setGriditems(int v)
        {
            
            switch (v)
            {
                default:
                    break;
                case 1:
                    // list items by choosing from listitems
                    if (CheckDuplicate(listBox1.SelectedItem.ToString())==true)
                    {
                        int idx1 = dataGridView_displayitems.Rows.Add();
                        DataGridViewRow row1 = dataGridView_displayitems.Rows[idx1];

                        row1.Cells["Column1"].Value = count;     //تسلسل المواد
                        row1.Cells["Column2"].Value = listBox1.SelectedItem.ToString();  //اسم المادة
                        row1.Cells["Column3"].Value = 1;     //كمية المادة
                        row1.Cells["Column4"].Value = 1;     //   سعر الشراء 
                        row1.Cells["Column5"].Value = 1;     //مجموع
                        count++;
                    }
                    break;

                case 2:
                    // items from masked box
                    if (CheckDuplicate(dt.Rows[0]["ItemName"].ToString())==true)
                    {
                        int idx2 = dataGridView_displayitems.Rows.Add();
                        DataGridViewRow row2 = dataGridView_displayitems.Rows[idx2];

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            row2.Cells["Column2"].Value = dt.Rows[i][1];
                        }
                        row2.Cells["Column1"].Value = count;     //تسلسل المواد
                        row2.Cells["Column3"].Value = 1;     //كمية المادة
                        row2.Cells["Column4"].Value = 1;     //   سعر الشراء 
                        row2.Cells["Column5"].Value = 1;     //مجموع
                        count++;
                    }                    
                    break;
                case 3:

                    // items from textbox
                        if(CheckDuplicate(dt.Rows[0]["ItemName"].ToString())==true)
                    {
                        int idx3 = dataGridView_displayitems.Rows.Add();
                        DataGridViewRow row3 = dataGridView_displayitems.Rows[idx3];

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            row3.Cells["Column2"].Value = dt.Rows[0]["ItemName"];
                        }
                        row3.Cells["Column1"].Value = count;     //تسلسل المواد
                        row3.Cells["Column3"].Value = 1;     //كمية المادة
                        row3.Cells["Column4"].Value = 1;     //   سعر الشراء 
                        row3.Cells["Column5"].Value = 1;     //مجموع
                        count++;
                    }
                        
                                       
                    break;
            }
        }

        private bool CheckDuplicate(string value)
        {
            for (int i = 0; i < dataGridView_displayitems.Rows.Count; i++)
            {
                if (dataGridView_displayitems.Rows[i].Cells[1].Value != null)
                {
                    if (dataGridView_displayitems.Rows[i].Cells[1].Value.ToString() == value)
                    {
                        int quantity = Convert.ToInt32(dataGridView_displayitems.Rows[i].Cells[2].Value.ToString());
                        quantity++;
                        dataGridView_displayitems.Rows[i].Cells[2].Value = quantity;
                        int price = Convert.ToInt32(dataGridView_displayitems.Rows[i].Cells[3].Value.ToString());
                        dataGridView_displayitems.Rows[i].Cells[4].Value = quantity*price;

                        return false;
                    }                   
                }
            }
            return true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if(textBox1.Text!="")
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@itemname", SqlDbType.NVarChar, 50);
                    param[0].Value = textBox1.Text;

                    dt = usedclass.selectdata("get_specfic_item", param);
                    textBox1.Text = "";
                    setGriditems(3);
                }
            }
        }

        private void maskedTextBox_BarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (maskedTextBox_BarCode.Text != "")
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@barCode", SqlDbType.NVarChar, 50);
                    param[0].Value = maskedTextBox_BarCode.Text.Trim();

                    dt = usedclass.selectdata("get_items_by_barcode", param);
                    maskedTextBox_BarCode.Text = "";
                    setGriditems(2);
                }
            }
        }
    }
}
