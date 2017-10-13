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
        private int counter;
        private int invoiceTotal, invoiceTotalAmount, buyprice, quantity, invoiceNumber;
        private string paymentType;

        public Invoice_Form()
        {
            InitializeComponent();
            initializeFucntion();
        }

        private void initializeFucntion()
        {
            //make controling to default value
            this.dataGridView_displayItems.Columns["Column_itemPrice"].DefaultCellStyle.Format = "C0";
            this.dataGridView_displayItems.Columns["Column_itemPrice"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("ar-iq");
            displayallCategory();
      
            counter = 1;
            invoiceTotal = invoiceTotalAmount = invoiceNumber = buyprice = quantity = 0;
            paymentType = BasicClass.CoustomerName = maskedTextBox_BarCode.Text = "";
            label_invoiceNo.Text = label_invoiceTotal.Text = label_invoiceTotalAmount.Text = txt_invoiceDiscount.Text = txt_savedMoney.Text = label_Deyon.Text = "0";
            label_invoiceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dt.Rows.Clear();
            listBox_items.DataSource = dt;

            //disabling controlling
            button_displayInPostBill.Enabled = false;
            textBox_customerName.Enabled = false;
            maskedTextBox_BarCode.Enabled = false;
            listBox_items.Enabled = false;
            button_CancelInvoice.Enabled = false;
            button_DeptRepayment.Enabled = false;
            button_displayInPostBill.Enabled = false;
            button_inPostBill.Enabled = false;
            button_postBill.Enabled = false;
            button_printInvoice.Enabled = false;
            flowLayoutPanel_CategWithoutBarcode.Enabled = false;
            flowLayoutPanel_itemsWithoutBarcode.Enabled = false;
            dataGridView_displayItems.Enabled = false;
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

        private void get_invoice_number()
        {
            dt = usedclass.selectdata("select_all_IDs", null);
            if (dt.Rows.Count > 0)
            {
                invoiceNumber = Int32.Parse(dt.Rows[0]["InvoiceNo"].ToString());
            }
        }

        private void enable_controlling()
        {
            button_displayInPostBill.Enabled = true;
            textBox_customerName.Enabled = true;
            maskedTextBox_BarCode.Enabled = true;
            flowLayoutPanel_CategWithoutBarcode.Enabled = true;
            flowLayoutPanel_itemsWithoutBarcode.Enabled = true;
            listBox_items.Enabled = true;
            button_CancelInvoice.Enabled = true;
            button_DeptRepayment.Enabled = true;
            button_inPostBill.Enabled = true;
            button_printInvoice.Enabled = true;
            button_postBill.Enabled = true;
            txt_savedMoney.Enabled = true;
            txt_invoiceDiscount.Enabled = true;
            dataGridView_displayItems.Enabled = true;
        }


        private void save_data_from_gridToDB(string run_or_not)
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
                param[2] = new SqlParameter("@Quantity", SqlDbType.Int); //multiply by -1 to make subtraction from total in database
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
            SqlParameter[] param2 = new SqlParameter[9];
            //
            param2[0] = new SqlParameter("@invoiceNo", SqlDbType.Int);
            param2[0].Value = Int32.Parse(label_invoiceNo.Text);
            //
            param2[1] = new SqlParameter("@invoiceCustomer", SqlDbType.NVarChar, 250);
            param2[1].Value = textBox_customerName.Text;
            //

            param2[2] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 50);
            param2[2].Value = "بيع";
            //
            param2[3] = new SqlParameter("@invoiceDiscount", SqlDbType.Float);
            param2[3].Value = float.Parse(txt_invoiceDiscount.Text);
            //
            param2[4] = new SqlParameter("@invoiceDate", SqlDbType.Date);
            param2[4].Value = DateTime.Now.ToShortDateString();
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

            usedclass.ExecuteCommand("new_invoice", param2);
            dataGridView_displayItems.Rows.Clear();

        }

        private void save_data_from_grid_to_db_without_quantity(string run_or_not)
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
                param[2] = new SqlParameter("@Quantity", SqlDbType.Int); //multiply by -1 to make subtraction from total in database
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
                usedclass.ExecuteCommand("insert_order_without_effect_stock", param);
            }
            SqlParameter[] param2 = new SqlParameter[9];
            //
            param2[0] = new SqlParameter("@invoiceNo", SqlDbType.Int);
            param2[0].Value = Int32.Parse(label_invoiceNo.Text);
            //
            param2[1] = new SqlParameter("@invoiceCustomer", SqlDbType.NVarChar, 250);
            param2[1].Value = textBox_customerName.Text;
            //

            param2[2] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 50);
            param2[2].Value = "بيع";
            //
            param2[3] = new SqlParameter("@invoiceDiscount", SqlDbType.Float);
            param2[3].Value = float.Parse(txt_invoiceDiscount.Text);
            //
            param2[4] = new SqlParameter("@invoiceDate", SqlDbType.Date);
            param2[4].Value = DateTime.Now.ToShortDateString();
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

            usedclass.ExecuteCommand("new_invoice_but_not_run", param2);
            dataGridView_displayItems.Rows.Clear();

        }

        /////////////////////////////////////////////////functions//////////////////

        private void Exit_Click(object sender, EventArgs e)
        {
            Invoice_Form.ActiveForm.Close();
        }

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
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        write_into_grid(dt.Rows[i]["ItemName"].ToString(), dt.Rows[i]["price_for_buy"].ToString());
                    }
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
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 250);
                param[1] = new SqlParameter("@itemQuantity", SqlDbType.Int);
                param[2] = new SqlParameter("@invoiceNo", SqlDbType.Int);
                param[2].Value = int.Parse(label_invoiceNo.Text);
                for (int i = 0; i < dataGridView_displayItems.Rows.Count; i++)
                {
                    param[0].Value = dataGridView_displayItems.Rows[i].Cells["Column_itemName"].Value.ToString();
                    param[1].Value = int.Parse(dataGridView_displayItems.Rows[i].Cells["Column_PcsQunatity"].Value.ToString());
                    usedclass.ExecuteCommand("Update_stock_when_cancelOrder", param);
                }
                initializeFucntion();
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
                for (int i = 0; i < dataGridView_displayItems.Rows.Count; i++)
                {
                    dataGridView_displayItems.Rows[i].Cells["Column_GridNo"].Value = i + 1;
                }

            }
        }

        private void button_postBill_Click(object sender, EventArgs e)
        {
            if (txt_savedMoney.Text == "" || txt_savedMoney.Text == "0")
            {
                DialogResult Result = MessageBox.Show("هل القائمة بالاجل", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Result == DialogResult.Yes)
                {
                    paymentType = "اجل";
                    txt_savedMoney.Text = "0";
                    txt_savedMoney.Enabled = false;
                    save_data_from_gridToDB("Run");
                    MessageBox.Show("تمت عملية الحفظ في قاعدة البيانات", "message");
                    initializeFucntion();
                }
                else if (Result == DialogResult.No)
                {
                    MessageBox.Show("يرجى ادخال المبلغ المسدد");
                    txt_savedMoney.Enabled = true;
                    txt_savedMoney.Focus();
                    paymentType = "نقد";
                }
            }
            else
            {
                save_data_from_gridToDB("Run");
                MessageBox.Show("تمت عملية الحفظ في قاعدة البيانات", "message");
                initializeFucntion();

            }
        }

        private void button_inPostBill_Click(object sender, EventArgs e)
        {
            if (dataGridView_displayItems.Rows.Count > 0)
            {
                MessageBox.Show("القائمة ستكون بالاجل", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paymentType = "اجل";
                txt_savedMoney.Text = "0";
                txt_savedMoney.Enabled = false;
               
                DialogResult Result = MessageBox.Show("هل تريد تعليق القائمة مع حجز الكميات", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (Result == DialogResult.Yes)
                {

                    save_data_from_gridToDB("Save");
                    MessageBox.Show("تم تعليق القائمة مع حجز الكميات", "message");
                    initializeFucntion();
                }
                else if (Result == DialogResult.No)
                {
                    save_data_from_grid_to_db_without_quantity("Not Run");
                    MessageBox.Show("تم تعليق القائمة بدون حجز الكميات", "message");
                    initializeFucntion();
                }
            }
        }

        private void button_printInvoice_Click(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@invoiceNo", SqlDbType.Int);
            param[0].Value = 9;
            dt = usedclass.selectdata("Get_order_by_invoiceNo", param);
            CrystalReport1 crp = new CrystalReport1();
            crp.SetDataSource(dt);
            PrintForm form = new PrintForm();
            form.crystalReportViewer1.ReportSource = crp;
            form.ShowDialog();


        }

        private void button_displayInPostBill_Click(object sender, EventArgs e)
        {
            View.UnInvoices_and_Users form = new View.UnInvoices_and_Users();
            form.label_form.Text = "القوائم المعلقة";
            form.tabControl1.SelectedTab = form.tabPage_SaveInvoices;
            form.ShowDialog();

        }

        private void textBox_customerName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            View.UnInvoices_and_Users form = new View.UnInvoices_and_Users();
            form.label_form.Text = "الـــزبائن";
            form.tabControl1.SelectedTab = form.tabPage_users;
            form.ShowDialog();

        }

        private void Invoice_Form_Activated(object sender, EventArgs e)
        {
            if (BasicClass.CoustomerName != "")
            {
                textBox_customerName.Text = BasicClass.CoustomerName;
            }
            if (BasicClass.UnrnningBillId != 0)
            {
                enable_controlling();
                dataGridView_displayItems.Rows.Clear();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@InvoiceID", SqlDbType.Int);
                param[0].Value = BasicClass.UnrnningBillId;
                dt = usedclass.selectdata("select_information_of_unRunInvoice_using_ID", param);
                textBox_customerName.Text = dt.Rows[0]["CustomerName"].ToString();
                label_invoiceNo.Text = dt.Rows[0]["invoiceNo"].ToString();
                label_invoiceTotal.Text = dt.Rows[0]["invoiceTotal"].ToString();
                label_invoiceTotalAmount.Text = label_invoiceTotal.Text;
                txt_savedMoney.Text = dt.Rows[0]["saved_money"].ToString();
                txt_invoiceDiscount.Text = dt.Rows[0]["invoiceDiscount"].ToString();
                label_invoiceDate.Text = dt.Rows[0]["invoiceDate"].ToString();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int quantity = (int.Parse(dt.Rows[i]["itemQuantity"].ToString())) * -1;
                    dataGridView_displayItems.Rows.Add(counter, dt.Rows[i]["itemName"].ToString(), quantity, dt.Rows[i]["itemPrice"].ToString(), dt.Rows[i]["totalPrice"].ToString());
                    counter++;
                }
                BasicClass.UnrnningBillId = 0;
            }
        }

        private void textBox_customerName_Leave(object sender, EventArgs e)
        {
            if (textBox_customerName.Text != "")
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 150);
                param[0].Value = textBox_customerName.Text;
                dt = usedclass.selectdata("Calculation_Total_Deyoon", param);
                if (dt.Rows.Count > 0)
                {
                    BasicClass.TotalDeyoon = double.Parse(dt.Rows[0]["diffrence"].ToString());
                    label_Deyon.Text = BasicClass.TotalDeyoon.ToString();
                }
                else
                {
                    label_Deyon.Text = "0";
                }

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
                    initializeFucntion();
                    enable_controlling();
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

        private void Set_invoicGrid(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 100);
            param[0].Value = clicked.Text;

            dt = usedclass.selectdata("buying_item_using_name", param);
            if (dt.Rows.Count > 0)
            {
                write_into_grid(dt.Rows[0]["ItemName"].ToString(), dt.Rows[0]["price_for_buy"].ToString());
            }
        }
    }
}
