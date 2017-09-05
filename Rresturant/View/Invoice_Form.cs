using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rresturant
{
    public partial class Invoice_Form : Form
    {
        BasicClass usedclass = new BasicClass();
        DataTable dt = new DataTable();
        private int counter = 1;
        private int invoiceTotal, invoiceTotalAmount, buyprice, quantity, invoiceNumber;
        private string paymentType;

        public Invoice_Form()
        {
            InitializeComponent();
            this.dataGridView_displayItems.Columns["Column_itemPrice"].DefaultCellStyle.Format = "C0";
            this.dataGridView_displayItems.Columns["Column_itemPrice"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("ar-iq");
            displayallCategory();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Invoice_Form.ActiveForm.Close();
        }

        private void displayallCategory()
        {
            flowLayoutPanel_CategWithoutBarcode.Controls.Clear();

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

        private Double Calcuation()
        {
            invoiceTotal = invoiceTotalAmount = 0;
            for (int RowIndex = 0; RowIndex < dataGridView_displayItems.Rows.Count; RowIndex++)
            {
                invoiceTotal = invoiceTotal + Convert.ToInt32(dataGridView_displayItems["Column_itemtotal", RowIndex].Value);
                invoiceTotalAmount = invoiceTotal;
            }
            label_invoiceTotal.Text = invoiceTotal.ToString();
            label_invoiceTotalAmount.Text = invoiceTotalAmount.ToString();
            //txt_Total.Text = String.Format("{0:##,##}", Double.Parse(txt_Total.Text));
            //if (txt_Total.Text == "")
            //{
            //    txt_Total.Text = "0";
            //}
            return invoiceTotal;
        }

        private void write_into_grid(string item, string price)
        {
            if (dt.Rows.Count > 0)
            {
                if (CheckDuplicate(item))
                {

                    int idx = dataGridView_displayItems.Rows.Add();

                    DataGridViewRow row = dataGridView_displayItems.Rows[idx];
                    row.Cells["Column_GridNo"].Value = counter;     //تسلسل المواد
                    row.Cells["Column_itemName"].Value = item;  //اسم المادة
                    row.Cells["Column_PcsQunatity"].Value = 1;     //كمية المادة
                    row.Cells["Column_itemPrice"].Value = price;     //   سعر البيع 
                    row.Cells["Column_itemtotal"].Value = int.Parse(price) * 1;   //مجموع
                    counter++;
                    Calcuation();
                }
            }

        }

        private bool CheckDuplicate(string value)
        {
            for (int i = 0; i < dataGridView_displayItems.Rows.Count; i++)
            {
                if (dataGridView_displayItems.Rows[i].Cells[1].Value != null)
                {
                    if (dataGridView_displayItems.Rows[i].Cells[1].Value.ToString() == value)
                    {
                        int quantity = Convert.ToInt32(dataGridView_displayItems.Rows[i].Cells[2].Value.ToString());
                        quantity++;
                        dataGridView_displayItems.Rows[i].Cells[2].Value = quantity;
                        int price = Convert.ToInt32(dataGridView_displayItems.Rows[i].Cells[3].Value.ToString());
                        dataGridView_displayItems.Rows[i].Cells[4].Value = quantity * price;
                        Calcuation();
                        return false;
                    }
                }

            }
            return true;
        }

        /////////////////////////////////////////////////functions//////////////////


        private void set_itemsWithoutarcode(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            flowLayoutPanel_itemsWithoutBarcode.Controls.Clear();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
            param[0].Value = clickedbutton.Text;
            dt = usedclass.selectdata("get_all_items_without_barcode", param);
            listBox_items.DataSource = dt;
            listBox_items.DisplayMember = "ItemName";
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

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (maskedTextBox_BarCode.Text != "")
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@itemBarCode", SqlDbType.NVarChar, 50);
                    param[0].Value = maskedTextBox_BarCode.Text.Trim();

                    dt = usedclass.selectdata("buy_item_using_barcode", param);
                    maskedTextBox_BarCode.Text = "";
                    write_into_grid(dt.Rows[0]["ItemName"].ToString(), dt.Rows[0]["price_for_buy"].ToString());
                }
            }
        }

        private void listBox_items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_items.Enabled == true)
            {

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 100);
                param[0].Value = listBox_items.Text;

                dt = usedclass.selectdata("buying_item_using_name", param);

                write_into_grid(dt.Rows[0]["ItemName"].ToString(), dt.Rows[0]["price_for_buy"].ToString());
            }

        }

        private void dataGridView_displayItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView_displayItems.Columns[e.ColumnIndex].Name == "Column_PcsQunatity" && dataGridView_displayItems.Rows[e.RowIndex].Cells["Column_PcsQunatity"].Value != null)
            {
                if (dataGridView_displayItems.Rows[e.RowIndex].Cells["Column_itemPrice"].Value != null)
                {
                    buyprice = int.Parse(dataGridView_displayItems.Rows[e.RowIndex].Cells["Column_itemPrice"].Value.ToString());
                    quantity = int.Parse(dataGridView_displayItems.Rows[e.RowIndex].Cells["Column_PcsQunatity"].Value.ToString());
                    if (quantity > check_stock_quantity(e))
                    {
                        MessageBox.Show("الكمية المصروفة اكثر من الكمية المخزونة سوف تتم اضافة كل الكمية الى القائمة");
                        quantity = check_stock_quantity(e);
                        dataGridView_displayItems.Rows[e.RowIndex].Cells["Column_PcsQunatity"].Value = quantity;
                    }
                    else
                    if (buyprice == 0)
                    {
                        MessageBox.Show("يجب تسعير هذه المادة لن تتم اضافة قيمتها للفاتورة", "Message");
                    }
                    else
                    {

                        dataGridView_displayItems.Rows[e.RowIndex].Cells["Column_itemtotal"].Value = buyprice * quantity;
                        Calcuation();
                    }

                }
            }
        }

        private int check_stock_quantity(DataGridViewCellEventArgs e)
        {
            int stockQuantity = 0;
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 100);
            parm[0].Value = dataGridView_displayItems.Rows[e.RowIndex].Cells["Column_itemName"].Value;
            dt = usedclass.selectdata("get_quantity_using_itemName", parm);
            if (dt.Rows.Count > 0)
            {
                return stockQuantity = int.Parse(dt.Rows[0]["itemQuantity"].ToString());
            }
            return 0;
        }

        private void button_CancelInvoice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد الغاء القائمة الحالية", "Warring", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                dataGridView_displayItems.Rows.Clear();
                Calcuation();
            }
        }

        private void dataGridView_displayItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                dataGridView_displayItems.Rows.RemoveAt(e.RowIndex);
                Calcuation();

            }
        }

        private void button_postBill_Click(object sender, EventArgs e)
        {
            if (txt_savedMoney.Text == "")
            {
                DialogResult Result = MessageBox.Show("هل القائمة بالاجل", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Result == DialogResult.Yes)
                {
                    paymentType = "اجل";
                    txt_savedMoney.Text = "0";
                    txt_savedMoney.Enabled = false;
                    save_data_from_gridToDB();
                }
                else if (Result == DialogResult.No)
                {
                    MessageBox.Show("يرجى ادخال المبلغ المسدد");
                    txt_savedMoney.Enabled = true;
                    txt_savedMoney.Focus();
                }
            }
            else
            {
                save_data_from_gridToDB();
            }
        }

        private void save_data_from_gridToDB()
        {
            SqlParameter[] param = new SqlParameter[6];
            for (int row = 0; row < dataGridView_displayItems.Rows.Count; row++)
            {
                param[0] = new SqlParameter("@invoiceNo", SqlDbType.Int);
                param[0].Value = Int32.Parse(label_invoiceNo.Text);
                //
                param[1] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
                param[1].Value = dataGridView_displayItems.Rows[row].Cells["Column_itemName"].Value;
                //

                param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
                param[2].Value = -1 * int.Parse(dataGridView_displayItems.Rows[row].Cells["Column_PcsQunatity"].Value.ToString());
                //
                param[3] = new SqlParameter("@price", SqlDbType.Float);
                param[3].Value = float.Parse(dataGridView_displayItems.Rows[row].Cells["Column_itemPrice"].Value.ToString());
                //
                param[4] = new SqlParameter("@totalPrice", SqlDbType.Float);
                param[4].Value = float.Parse(dataGridView_displayItems.Rows[row].Cells["Column_itemtotal"].Value.ToString());
                //
                param[5] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 250);
                param[5].Value = textBox_customerName.Text;
                //
                usedclass.ExecuteCommand("insert_order", param);
            }
        }

        private void button_newInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridView_displayItems.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("هل تريد الغاء القائمة الحالية", "Warring", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    dataGridView_displayItems.Rows.Clear();
                    Calcuation();
                }
            }
            else
            {
                enable_controlling();
                get_invoice_number();
                label_invoiceNo.Text = invoiceNumber.ToString();
            }
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

        private void enable_controlling()
        {
            textBox_customerName.Enabled = true;
            maskedTextBox_BarCode.Enabled = true;
            flowLayoutPanel_CategWithoutBarcode.Enabled = true;
            listBox_items.Enabled = true;
            button_CancelInvoice.Enabled = true;
            button_DeptRepayment.Enabled = true;
            button_inPostBill.Enabled = true;
            button_printInvoice.Enabled = true;
            button_postBill.Enabled = true;
        }

        private void Set_invoicGrid(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 100);
            param[0].Value = clicked.Text;

            dt = usedclass.selectdata("buying_item_using_name", param);
            write_into_grid(dt.Rows[0]["ItemName"].ToString(), dt.Rows[0]["price_for_buy"].ToString());
        }
    }
}
