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
        double invoiceTotal, invoiceTotalAmount, invoiceDiscount = 0;
        string paymentType = "";
        public SalesForm()
        {
            InitializeComponent();
            maskedTextBox_invoicedate.Enabled = false;
            maskedTextBox_invoicedate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.dataGridView_displayitems.Columns["Column1"].ReadOnly = true;
            this.dataGridView_displayitems.Columns["Column2"].ReadOnly = true;
            this.dataGridView_displayitems.Columns["Column5"].ReadOnly = true;
            //this.dataGridView_displayitems.Columns["Column5"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("ar-iq");
            //this.dataGridView_displayitems.Columns["Column5"].DefaultCellStyle.Format = "C0";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            SalesForm.ActiveForm.Close();
        }

        private void btn_newinvoice_Click(object sender, EventArgs e)
        {
            EnableControlling();
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
                        Calcuation();
                    }
                    break;

                case 2:
                    // items from masked box
                    if(dt.Rows.Count>0)
                    {
                        if (CheckDuplicate(dt.Rows[0]["ItemName"].ToString()) == true)
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
                            Calcuation();
                        }
                    }                      
                    break;

                case 3:

                    // items from textbox
                    if (dt.Rows.Count > 0)
                    {
                        if (CheckDuplicate(dt.Rows[0]["ItemName"].ToString()) == true)
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
                            Calcuation();
                        }
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

        private void txt_invoiceDiscount_TextChanged(object sender, EventArgs e)
        {
            if(txt_invoiceDiscount.Text=="")
            {
                txt_invoiceDiscount.Text = "0";
                Calcuation();
            }
            else
            {
                invoiceDiscount = double.Parse(txt_invoiceDiscount.Text);
                invoiceTotalAmount = invoiceTotal - invoiceDiscount;
                label_invoiceTotalAmount.Text = invoiceTotalAmount.ToString();
            }
        }

        private void dataGridView_displayitems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            float quantity, salePrice = 0;   
            for(int i=0; i<dataGridView_displayitems.Rows.Count; i++)
            {
                // to check if value changed of quantity 
                if (dataGridView_displayitems.Columns[e.ColumnIndex].Name == "Column3")
                {
                    if(dataGridView_displayitems.Rows[i].Cells["Column4"].Value != null)
                    {
                        quantity = float.Parse(dataGridView_displayitems.Rows[i].Cells["Column3"].Value.ToString());
                        salePrice = float.Parse(dataGridView_displayitems.Rows[i].Cells["Column4"].Value.ToString());
                        dataGridView_displayitems.Rows[i].Cells["Column5"].Value = quantity * salePrice;
                        Calcuation();
                    }
                }
                //check if value of price changed
                if (dataGridView_displayitems.Columns[e.ColumnIndex].Name == "Column4")
                {
                    if (dataGridView_displayitems.Rows[i].Cells["Column3"].Value != null)
                    {
                        quantity = float.Parse(dataGridView_displayitems.Rows[i].Cells["Column3"].Value.ToString());
                        salePrice = float.Parse(dataGridView_displayitems.Rows[i].Cells["Column4"].Value.ToString());
                        dataGridView_displayitems.Rows[i].Cells["Column5"].Value = quantity * salePrice;
                        Calcuation();
                    }
                }
            }
        }

        private void btn_saveinvoice_Click(object sender, EventArgs e)
        {
            SqlParameter[] param1 = new SqlParameter[6];
            int summation = 0;
            for (int rowindex = 0; rowindex < dataGridView_displayitems.Rows.Count; rowindex++)
            {
                param1[0] = new SqlParameter("@InvoiceNo", SqlDbType.BigInt);
                param1[0].Value = int.Parse(label_invoiceNumber.Text);
                //
                param1[1] = new SqlParameter("@CoustomerName", SqlDbType.NVarChar, 100);
                param1[1].Value = txt_coustomerName.Text;
                //
                param1[2] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
                param1[2].Value = dataGridView_displayitems.Rows[rowindex].Cells["Column2"].Value;
                //
                param1[3] = new SqlParameter("@Quantity", SqlDbType.Int);
                param1[3].Value = int.Parse(dataGridView_displayitems.Rows[rowindex].Cells["Column3"].Value.ToString());
                //
                param1[4] = new SqlParameter("@price", SqlDbType.Int);
                param1[4].Value = int.Parse(dataGridView_displayitems.Rows[rowindex].Cells["Column4"].Value.ToString());
                //
                param1[5] = new SqlParameter("@totalPrice", SqlDbType.Int);
                param1[5].Value = int.Parse(dataGridView_displayitems.Rows[rowindex].Cells["Column5"].Value.ToString());
                
                usedclass.ExecuteCommand("insert_sale_order", param1);
            }

            SqlParameter[] param2 = new SqlParameter[4];
            param2[0] = new SqlParameter("", SqlDbType.Int);
            param2[0].Value = int.Parse(label_invoiceNumber.Text);
            //
            param2[1] = new SqlParameter("",SqlDbType.Float);
            //param2[1].Value = float.Parse()
        }

        private void txt_savedMoney_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_savedMoney.Text = invoiceTotalAmount.ToString();
        }

        private void button_saveWithout_Click(object sender, EventArgs e)
        {

            if (dataGridView_displayitems.Rows.Count > 0)
            {
                if (txt_coustomerName.Text == "")
                {
                    MessageBox.Show("يرجى ادخال اسم الجهة");
                    txt_coustomerName.Focus();
                }
                else
                {
                    if (!radioButton_CashMoney.Checked && !radioButton_NoCash.Checked)
                    {
                        MessageBox.Show("يرجى اختيار نوع التسديد");
                    }
                    else
                    {
                        SqlParameter[] param = new SqlParameter[5];
                        for (int row = 0; row < dataGridView_displayitems.Rows.Count; row++)
                        {
                            param[0] = new SqlParameter("@invoiceNo", SqlDbType.Int);
                            param[0].Value = Int32.Parse(label_invoiceNumber.Text);
                            //
                            param[1] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
                            param[1].Value = dataGridView_displayitems.Rows[row].Cells["Column2"].Value;
                            //
                            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
                            param[2].Value = int.Parse(dataGridView_displayitems.Rows[row].Cells["Column3"].Value.ToString());
                            //
                            param[3] = new SqlParameter("@price", SqlDbType.Float);
                            param[3].Value = float.Parse(dataGridView_displayitems.Rows[row].Cells["Column4"].Value.ToString());
                            //
                            param[4] = new SqlParameter("@totalPrice", SqlDbType.Float);
                            param[4].Value = float.Parse(dataGridView_displayitems.Rows[row].Cells["Column5"].Value.ToString());
                            usedclass.ExecuteCommand("insert_order", param);
                        }
                        SqlParameter[] param2 = new SqlParameter[8];
                        //
                        param2[0] = new SqlParameter("@invoiceNo", SqlDbType.Int);
                        param2[0].Value = Int32.Parse(label_invoiceNumber.Text);
                        //
                        param2[1] = new SqlParameter("@invoiceCustomer", SqlDbType.NVarChar, 250);
                        param2[1].Value = txt_coustomerName.Text;
                        //

                        param2[2] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 50);
                        param2[2].Value = "شراء";
                        //
                        param2[3] = new SqlParameter("@invoiceDiscount", SqlDbType.Float);
                        param2[3].Value = float.Parse(txt_invoiceDiscount.Text);
                        //
                        param2[4] = new SqlParameter("@invoiceDate", SqlDbType.Date);
                        param2[4].Value = DateTime.ParseExact(maskedTextBox_invoicedate.Text, "dd/MM/yyyy", null);
                        //
                        param2[5] = new SqlParameter("@invoice_cash_or_not", SqlDbType.NVarChar, 50);
                        param2[5].Value = paymentType;
                        //
                        param2[6] = new SqlParameter("@invoice_run_or_not", SqlDbType.NVarChar, 50);
                        param2[6].Value = "not run";
                        //
                        param2[7] = new SqlParameter("@invoice_entereduser", SqlDbType.NVarChar, 50);
                        param2[7].Value = "mustafa";
                        //

                        usedclass.ExecuteCommand("save_new_invoice", param2);
                    }
                }
            }
               
           
        }

        private void radioButton_CashMoney_CheckedChanged(object sender, EventArgs e)
        {
            txt_invoiceDiscount.Enabled = true;
            txt_savedMoney.Enabled = true;
            paymentType = "نقد";
        }

        private void radioButton_NoCash_CheckedChanged(object sender, EventArgs e)
        {
            txt_invoiceDiscount.Enabled = false;
            txt_savedMoney.Enabled = false;
            paymentType = "اجل";
            txt_savedMoney.Text = "0";
            txt_invoiceDiscount.Text = "0";
        }

        private Double Calcuation()
        {
            invoiceTotal = 0;
            for (int RowIndex = 0; RowIndex < dataGridView_displayitems.Rows.Count; RowIndex++)
            {
                invoiceTotal = invoiceTotal + Convert.ToDouble(dataGridView_displayitems["Column5", RowIndex].Value);
                invoiceTotalAmount = invoiceTotal;
            }
            label_invoiceTotal.Text = invoiceTotal.ToString();
            label_invoiceTotalAmount.Text = invoiceTotal.ToString();
            //txt_Total.Text = String.Format("{0:##,##}", Double.Parse(txt_Total.Text));
            //if (txt_Total.Text == "")
            //{
            //    txt_Total.Text = "0";
            //}
            return invoiceTotal;

        }

        private void EnableControlling()
        {
            maskedTextBox_invoicedate.Enabled = true;
            maskedTextBox_BarCode.Enabled = true;
            txt_invoiceDiscount.Enabled = true;
            txt_savedMoney.Enabled = true;
            textBox1.Enabled = true;
            listBox1.Enabled = true;
            comboBox1.Enabled = true;
            txt_coustomerName.Enabled = true;
            button_saveWithout.Enabled = true;
            btn_saveinvoice.Enabled = true;
            radioButton_CashMoney.Enabled = true;
            radioButton_NoCash.Enabled = true;
            label_invoiceTotal.Text = "0";
            label_invoiceTotalAmount.Text = "0";
            txt_invoiceDiscount.Text = "0";
            maskedTextBox_invoicedate.Focus();
        }
    }
}
