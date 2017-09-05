using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rresturant
{
    public partial class prices_form : Form
    {
        DataTable dt = new DataTable();
        DataTable changes = new DataTable();
        BasicClass usedClass = new BasicClass();
        public prices_form()
        {
            InitializeComponent();
            changes.Columns.Add("itemName");
            changes.Columns.Add("column_price_or_quantity");

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            prices_form.ActiveForm.Close();
        }

        private void checkBox_all_items_without_price_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox_all_items_without_price.Checked)
            {
                dt.Rows.Clear();
                dataGridViewPrices_displayitems.DataSource = dt;
            }
            else
            {
                dt.Rows.Clear();
                comboBoxprice_allcategories.DataSource = dt;
                maskedTextBoxprice_BarCode.Text = "";
                txtprice_searchByitemName.Text = "";
                dataGridViewPrices_displayitems.Enabled = true;
                dt = usedClass.selectdata("get_all_items_without_prices", null);
                dataGridViewPrices_displayitems.DataSource = dt;
            }
        }

        private void maskedTextBoxprice_BarCode_KeyDown(object sender, KeyEventArgs e)
        {
            dt.Rows.Clear();
            ////dataGridViewPrices_displayitems.DataSource = dt;
            comboBoxprice_allcategories.DataSource = dt;
            txtprice_searchByitemName.Text = "";
            checkBox_all_items_without_price.Checked = false;
            dataGridViewPrices_displayitems.Enabled = true;
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (maskedTextBoxprice_BarCode.Text != "")
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@item_barCode", SqlDbType.NVarChar, 50);
                    param[0].Value = maskedTextBoxprice_BarCode.Text.Trim();

                    dt = usedClass.selectdata("get_all_items_with_prices_by_barcode", param);

                    //maskedTextBoxprice_BarCode.Text = "";
                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewPrices_displayitems.DataSource = dt;
                    }
                }
            }
        }

        private void txtprice_searchByitemName_KeyDown(object sender, KeyEventArgs e)
        {
            dt.Rows.Clear();
            dataGridViewPrices_displayitems.DataSource = dt;
            comboBoxprice_allcategories.DataSource = dt;
            maskedTextBoxprice_BarCode.Text = "";
            checkBox_all_items_without_price.Checked = false;
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (txtprice_searchByitemName.Text != "")
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
                    param[0].Value = txtprice_searchByitemName.Text.Trim();

                    dt = usedClass.selectdata("get_all_items_with_prices_by_name", param);
                    textBoxQuantity_itemName.Text = "";
                    dataGridViewPrices_displayitems.DataSource = dt;
                }
            }
        }

        private void comboBoxprice_allcategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@itemCategory", SqlDbType.NVarChar, 50);
            param[0].Value = comboBoxprice_allcategories.Text.ToString();

            dt = usedClass.selectdata("get_all_items_with_prices_by_CategoryName", param);
            txtprice_searchByitemName.Text = "";
            dataGridViewPrices_displayitems.DataSource = dt;

        }

        private void comboBoxprice_allcategories_DropDown(object sender, EventArgs e)
        {
            dt = usedClass.selectdata("Get_All_Category", null);
            //
            comboBoxprice_allcategories.DataSource = dt;
            comboBoxprice_allcategories.DisplayMember = "CatergoryName";
            comboBoxprice_allcategories.ValueMember = "CategoryID";
            checkBox_all_items_without_price.Checked = false;
            txtprice_searchByitemName.Text = "";
            maskedTextBoxprice_BarCode.Text = "";
            dt.Rows.Clear();
            dataGridViewPrices_displayitems.DataSource = dt;
        }

        private void dataGridViewPrices_displayitems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPrices_displayitems.Rows.Count > 0)
            {
                if (dataGridViewPrices_displayitems.Columns[e.ColumnIndex].Name == "Column_price_for_buy" && dataGridViewPrices_displayitems.Rows[e.RowIndex].Cells["Column_price_for_buy"].Value.ToString() != "")
                {

                    changes.Rows.Add(dataGridViewPrices_displayitems.Rows[e.RowIndex].Cells["columnName"].Value.ToString(), dataGridViewPrices_displayitems.Rows[e.RowIndex].Cells["Column_price_for_buy"].Value.ToString());
                }
                if (dataGridViewPrices_displayitems.Rows[e.RowIndex].Cells["Column_price_for_buy"].Value.ToString() == "" || float.Parse(dataGridViewPrices_displayitems.Rows[e.RowIndex].Cells["Column_price_for_buy"].Value.ToString()) < 0)
                {
                    MessageBox.Show("يجب وضع قيمة صحيحة لهذه المادة", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dataGridViewPrices_displayitems.Rows[e.RowIndex].Cells["Column_price_for_buy"].Value = 0;

                }
            }
        }

        private void button_changePrices_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrices_displayitems.Rows.Count > 0)
            {
                SqlParameter[] parameter = new SqlParameter[2];
                //changes = dt.Copy();
                for (int i = 0; i < changes.Rows.Count; i++)
                {
                    parameter[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 250);
                    parameter[0].Value = changes.Rows[i]["itemName"].ToString();
                    //
                    parameter[1] = new SqlParameter("@itemNewPrice", SqlDbType.Float);
                    parameter[1].Value = float.Parse(changes.Rows[i]["column_price_or_quantity"].ToString());
                    usedClass.ExecuteCommand("update_price_using_itemName", parameter);
                    MessageBox.Show("تم تحديث الاسعار", "Message");

                }
            }

        }


        /// <summary>
        /// ///////////////////////////////////////////Above is Tab page 1 and below is TabPage 2////////////

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult Result = new DialogResult();
            if (tabControl1.SelectedTab == tabPage_CorrectPrices)
            {
                dt.Rows.Clear();
                dataGridViewPrices_displayitems.DataSource = dt;
                dataGridViewQuantity_displayitems.DataSource = dt;
                if (changes.Rows.Count > 0)
                {
                    Result = MessageBox.Show("هناك ارصدة تم تعديلها لم يتم حفظها اذا كنت تريد الحفظ اضغط نعم", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    SqlParameter[] parameter = new SqlParameter[2];
                    //changes = dt.Copy();
                    for (int i = 0; i < changes.Rows.Count; i++)
                    {
                        parameter[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 250);
                        parameter[0].Value = changes.Rows[i]["itemName"].ToString();
                        //
                        parameter[1] = new SqlParameter("@itemNewQuantity", SqlDbType.Int);
                        parameter[1].Value = int.Parse(changes.Rows[i]["column_price_or_quantity"].ToString());
                        usedClass.ExecuteCommand("update_quantity_using_itemName", parameter);
                    }
                    MessageBox.Show("تم تحديث الارصدة", "Message");
                }
            }
            else if (tabControl1.SelectedTab == tabPage_correctQuantity)
            {
                dt.Rows.Clear();
                dataGridViewPrices_displayitems.DataSource = dt;
                dataGridViewQuantity_displayitems.DataSource = dt;
                if (changes.Rows.Count > 0)
                {
                    Result = MessageBox.Show("هناك اسعار تم تعديلها لم يتم حفظها اذا كنت تريد الحفظ اضغط نعم", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (Result == DialogResult.Yes)
                    {
                        SqlParameter[] parameter = new SqlParameter[2];
                        //changes = dt.Copy();
                        for (int i = 0; i < changes.Rows.Count; i++)
                        {
                            parameter[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 250);
                            parameter[0].Value = changes.Rows[i]["itemName"].ToString();
                            //
                            parameter[1] = new SqlParameter("@itemNewPrice", SqlDbType.Float);
                            parameter[1].Value = float.Parse(changes.Rows[i]["column_price_or_quantity"].ToString());
                            usedClass.ExecuteCommand("update_price_using_itemName", parameter);
                            MessageBox.Show("تم تحديث الاسعار", "Message");
                        }
                    }
                }
            }
        }

        private void checkBox_Allitems_without_quantity_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Allitems_without_quantity.Checked)
            {
                dt.Rows.Clear();
                dataGridViewQuantity_displayitems.DataSource = dt;
            }
            else
            {
                dt.Rows.Clear();
                comboBoxQuantity_allCategories.DataSource = dt;
                maskedTextBoxQuantity_barCode.Text = "";
                textBoxQuantity_itemName.Text = "";
                dataGridViewQuantity_displayitems.Enabled = true;
                dt = usedClass.selectdata("get_all_items_without_quantity", null);
                dataGridViewQuantity_displayitems.DataSource = dt;
            }
        }

        private void maskedTextBoxQuantity_barCode_KeyDown(object sender, KeyEventArgs e)
        {
            dt.Rows.Clear();
            dataGridViewQuantity_displayitems.DataSource = dt;
            comboBoxQuantity_allCategories.DataSource = dt;
            textBoxQuantity_itemName.Text = "";
            checkBox_Allitems_without_quantity.Checked = false;

            if (e.KeyValue == (char)Keys.Enter)
            {
                if (maskedTextBoxQuantity_barCode.Text != "")
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@item_barCode", SqlDbType.NVarChar, 50);
                    param[0].Value = maskedTextBoxQuantity_barCode.Text.Trim();

                    dt = usedClass.selectdata("get_all_items_with_prices_by_barcode", param);
                    maskedTextBoxQuantity_barCode.Text = "";
                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewQuantity_displayitems.DataSource = dt;
                    }
                }
            }
        }

        private void textBoxQuantity_itemName_KeyDown(object sender, KeyEventArgs e)
        {
            dt.Rows.Clear();
            dataGridViewQuantity_displayitems.DataSource = dt;
            comboBoxQuantity_allCategories.DataSource = dt;
            maskedTextBoxQuantity_barCode.Text = "";
            checkBox_Allitems_without_quantity.Checked = false;
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (textBoxQuantity_itemName.Text != "")
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
                    param[0].Value = textBoxQuantity_itemName.Text.Trim();

                    dt = usedClass.selectdata("get_all_items_with_prices_by_name", param);
                    textBoxQuantity_itemName.Text = "";
                    dataGridViewQuantity_displayitems.DataSource = dt;
                }
            }
        }

        private void comboBoxQuantity_allCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@itemCategory", SqlDbType.NVarChar, 50);
            param[0].Value = comboBoxQuantity_allCategories.Text.ToString();

            dt = usedClass.selectdata("get_all_items_with_prices_by_CategoryName", param);
            textBoxQuantity_itemName.Text = "";
            dataGridViewQuantity_displayitems.DataSource = dt;
        }

        private void comboBoxQuantity_allCategories_DropDown(object sender, EventArgs e)
        {
            dt = usedClass.selectdata("Get_All_Category", null);
            //
            comboBoxQuantity_allCategories.DataSource = dt;
            comboBoxQuantity_allCategories.DisplayMember = "CatergoryName";
            comboBoxQuantity_allCategories.ValueMember = "CategoryID";
            checkBox_Allitems_without_quantity.Checked = false;
            textBoxQuantity_itemName.Text = "";
            maskedTextBoxQuantity_barCode.Text = "";
            //dt.Rows.Clear();
            //dataGridViewQuantity_displayitems.DataSource = dt;
        }

        private void dataGridViewQuantity_displayitems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewQuantity_displayitems.Rows.Count > 0)
            {
                if (dataGridViewQuantity_displayitems.Columns[e.ColumnIndex].Name == "Column_Quantity" && dataGridViewQuantity_displayitems.Rows[e.RowIndex].Cells["Column_Quantity"].Value.ToString() != "")
                {

                    changes.Rows.Add(dataGridViewQuantity_displayitems.Rows[e.RowIndex].Cells["Column_itemName"].Value.ToString(), dataGridViewQuantity_displayitems.Rows[e.RowIndex].Cells["Column_Quantity"].Value.ToString());
                }
                if (dataGridViewQuantity_displayitems.Rows[e.RowIndex].Cells["Column_Quantity"].Value.ToString() == "" || Int32.Parse(dataGridViewQuantity_displayitems.Rows[e.RowIndex].Cells["Column_Quantity"].Value.ToString()) < 0)
                {
                    MessageBox.Show("يجب وضع قيمة صحيحة لهذه المادة", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dataGridViewQuantity_displayitems.Rows[e.RowIndex].Cells["Column_Quantity"].Value = 0;

                }
            }




        }

        private void button_changeQuantity_Click(object sender, EventArgs e)
        {
            if (dataGridViewQuantity_displayitems.Rows.Count > 0)
            {
                SqlParameter[] parameter = new SqlParameter[2];
                //changes = dt.Copy();
                for (int i = 0; i < changes.Rows.Count; i++)
                {
                    parameter[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 250);
                    parameter[0].Value = changes.Rows[i]["itemName"].ToString();
                    //
                    parameter[1] = new SqlParameter("@itemNewQuantity", SqlDbType.Int);
                    parameter[1].Value = int.Parse(changes.Rows[i]["column_price_or_quantity"].ToString());
                    usedClass.ExecuteCommand("update_quantity_using_itemName", parameter);
                }
                MessageBox.Show("تم تحديث الارصدة", "Message");

            }
        }

    }
}
