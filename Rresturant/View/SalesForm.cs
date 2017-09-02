using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rresturant
{
    public partial class SalesForm : Form
    {
        BasicClass usedclass = new BasicClass();
        DataTable dt = new DataTable();


        private Int32 invoiceNumber = 0;
        private int count = 1;
        private double invoiceTotal, invoiceTotalAmount, invoiceDiscount = 0;
        private string paymentType = "";
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
        /// <summary>
        /// ////////////////////////////////////////////////////////functions/////////////////////////////////////
        /// 
        private void EnableControlling()
        {
            dataGridView_displayitems.Enabled = true;
            maskedTextBox_invoicedate.Enabled = true;
            maskedTextBox_BarCode.Enabled = true;
            txt_invoiceDiscount.Enabled = true;
            txt_savedMoney.Enabled = true;
            txt_searchByitemName.Enabled = true;
            listBox_listitems.Enabled = true;
            comboBox_allcategories.Enabled = true;
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

        private void get_invoice_number()
        {
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

        }

        private void set_datagrid_items(int v)
        {

            switch (v)
            {
                default:
                    break;
                case 1:
                    // list items by choosing from listitems
                    if (CheckDuplicate(listBox_listitems.SelectedItem.ToString()) == true)
                    {
                        write_into_grid(listBox_listitems.SelectedItem.ToString());
                        count++;
                        Calcuation();
                    }
                    break;

                case 2:
                    // items from masked box
                    if (dt.Rows.Count > 0)
                    {
                        if (CheckDuplicate(dt.Rows[0]["ItemName"].ToString()) == true)
                        {
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                write_into_grid(dt.Rows[i]["ItemName"].ToString());
                            }
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
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                write_into_grid(dt.Rows[i]["ItemName"].ToString());
                            }
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
                        dataGridView_displayitems.Rows[i].Cells[4].Value = quantity * price;

                        return false;
                    }
                }
            }
            return true;
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

        private void write_into_grid(string item)
        {
            int idx = dataGridView_displayitems.Rows.Add();
            DataGridViewRow row = dataGridView_displayitems.Rows[idx];
            row.Cells["Column1"].Value = count;     //تسلسل المواد
            row.Cells["Column2"].Value = item;  //اسم المادة
            row.Cells["Column3"].Value = 1;     //كمية المادة
            row.Cells["Column4"].Value = 1;     //   سعر الشراء 
            row.Cells["Column5"].Value = 1;     //مجموع
        }
       
        private void save_data_from_girdToDB(string run_or_not)
        {
            SqlParameter[] param = new SqlParameter[6];
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
                //
                param[5] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 250);
                param[5].Value = txt_coustomerName.Text;
                //
                usedclass.ExecuteCommand("insert_order", param);
            }
            SqlParameter[] param2 = new SqlParameter[9];
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
            param2[6].Value = run_or_not;
            //
            param2[7] = new SqlParameter("@invoice_entereduser", SqlDbType.NVarChar, 50);
            param2[7].Value = "mustafa";
            //
            param2[8] = new SqlParameter("@invoice_saved_money", SqlDbType.Float);
            param2[8].Value = float.Parse(txt_savedMoney.Text);

            usedclass.ExecuteCommand("save_new_invoice", param2);
            dataGridView_displayitems.Rows.Clear();
            txt_invoiceDiscount.Text = "0";
            txt_coustomerName.Text = "";
            txt_savedMoney.Text = "0";
            button_saveWithout.Enabled = false;
            btn_saveinvoice.Enabled = false;
            dataGridView_displayitems.Enabled = false;
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////End Fucntions//////////////////////////
        
        private void Exit_Click(object sender, EventArgs e)
        {
            SalesForm.ActiveForm.Close();
        }

        private void btn_newinvoice_Click(object sender, EventArgs e)
        {
            if (dataGridView_displayitems.Rows.Count>0)
            {
                DialogResult result = MessageBox.Show("هل تريد الغاء القائمة الحالية", "Warring", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result==DialogResult.OK)
                {
                    dataGridView_displayitems.Rows.Clear();
                }
                else
                {

                }
            }    
            else
            {
                EnableControlling(); //make all controller Enable (Enable=true)
                get_invoice_number(); // get invoice number from DB
                label_invoiceNumber.Text = invoiceNumber.ToString();
            }
        }

        private void comboBox_allcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_listitems.Items.Clear();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
            param[0].Value = comboBox_allcategories.Text;

            dt = usedclass.selectdata("get_All_items_by_categoryName", param);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox_listitems.Items.Add(dt.Rows[i][1]);
            }

        }

        private void comboBox_allcategories_DropDown(object sender, EventArgs e)
        {
            dt = usedclass.selectdata("Get_All_Category", null);
            //
            comboBox_allcategories.DataSource = dt;
            comboBox_allcategories.DisplayMember = "CatergoryName";
            comboBox_allcategories.ValueMember = "CategoryID";

        }

        private void listBox_listitems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_listitems.Enabled==true)
            {
            set_datagrid_items(1);
            }
        }

        private void txt_searchByitemName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.Enter)
            {
                if (txt_searchByitemName.Text != "")
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@itemname", SqlDbType.NVarChar, 50);
                    param[0].Value = txt_searchByitemName.Text;

                    dt = usedclass.selectdata("get_specfic_item", param);
                    txt_searchByitemName.Text = "";
                    set_datagrid_items(3);
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
                    set_datagrid_items(2);
                }
            }
        }

        private void txt_invoiceDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txt_invoiceDiscount.Text == "")
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
            for (int i = 0; i < dataGridView_displayitems.Rows.Count; i++)
            {
                // to check if value changed of quantity 
                if (dataGridView_displayitems.Columns[e.ColumnIndex].Name == "Column3")
                {
                    if (dataGridView_displayitems.Rows[i].Cells["Column4"].Value != null)
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
                    else if (txt_savedMoney.Text == "0" && paymentType == "نقد" || txt_savedMoney.Text == "")
                    {
                        MessageBox.Show("يرجى ادخال المبلغ المسدد");
                        txt_savedMoney.Text = "";
                        txt_savedMoney.Focus();
                    }
                    else
                    {
                        save_data_from_girdToDB("Run");
                        MessageBox.Show("تم ترحيل القائمة");
                    }
                }
            }
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
                    else if(txt_savedMoney.Text=="0" && paymentType=="نقد" || txt_savedMoney.Text=="")
                    {
                        MessageBox.Show("يرجى ادخال المبلغ المسدد");
                        txt_savedMoney.Text = "";
                        txt_savedMoney.Focus();
                    }
                    else
                    {
                        save_data_from_girdToDB("Not Run");
                        MessageBox.Show("تم تعليق القائمة");
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


    }
}
