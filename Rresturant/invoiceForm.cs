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
    public partial class invoiceForm : Form
    {
        BasicClass UsedClass = new BasicClass();
        double itemSalary = 0;
        int TableFlag = 0;
        int TableNumber;
        Decimal OrderID = 0;
        public invoiceForm()
        {
            InitializeComponent();
            this.dataGridView_OrderDetail.Columns["Column_ItemName"].ReadOnly = true;
            this.dataGridView_OrderDetail.Columns["Column_ItemPrice"].ReadOnly = true;
            this.dataGridView_OrderDetail.Columns["Column_PriceTotal"].ReadOnly = true;
            this.dataGridView_OrderDetail.Columns["Column_ItemPrice"].DefaultCellStyle.Format = "C0";
            this.dataGridView_OrderDetail.Columns["Column_ItemPrice"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("ar-iq");
            this.dataGridView_OrderDetail.Columns["Column_PriceTotal"].DefaultCellStyle.Format = "C0";
            this.dataGridView_OrderDetail.Columns["Column_PriceTotal"].DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("ar-iq");
            this.dataGridView_OrderDetail.Columns["Column_deleteItemPicture"].Width = 70;
            this.dataGridView_OrderDetail.Columns["Column_ItemPCS"].Width = 70;

            Get_Order_ID();
            OrderID++;
            label_invoiceNO.Text = OrderID.ToString();

        }

        /// <summary>
        /// ///////// functions ////////////////////////////////////////
        /// 
        private void Get_Order_ID()
        {
            OrderID = 0;
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("Get_OrderID", null);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == "")
                {
                    OrderID = 0;
                }
                else
                {
                    OrderID = Convert.ToDecimal(dt.Rows[i][0].ToString());
                }

            }
        }
        private void Set_ItmesGrid(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            itemSalary = Convert.ToDouble(clicked.Name);
            int flag = 0;
            for (int RowIndex = 0; RowIndex < dataGridView_OrderDetail.Rows.Count; RowIndex++)
            {
                if (dataGridView_OrderDetail["Column_ItemName", RowIndex].Value.ToString() == clicked.Text)
                {
                    flag = 1;   //Check wearther the Item is in Grid or not in Grid
                }
            }
            if (flag == 0)
            {
                int idx = dataGridView_OrderDetail.Rows.Add();
                DataGridViewRow row = dataGridView_OrderDetail.Rows[idx];

                row.Cells["Column_ItemName"].Value = clicked.Text;
                row.Cells["Column_ItemPrice"].Value = itemSalary;
                row.Cells["Column_ItemPCS"].Value = 1;
                row.Cells["Column_PriceTotal"].Value = itemSalary * 1;

                Calcuation();
                txt_Discount.Text = "";
            }
        }

        private void SetFlowLayoutPanel_DisplayItmes(object sender, EventArgs e)
        {
            flowLayoutPanel_displayItems.Controls.Clear();
            Button clickedbutton = sender as Button;
            Int32 CategoryID = Convert.ToInt32(clickedbutton.Name);
            //
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CategID", SqlDbType.Int);
            param[0].Value = CategoryID;
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_Items_BY_CATID", param);
            //
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Button btn_Item = new Button();
                btn_Item.Name = dt.Rows[i][4].ToString(); // here Get Price of Item ex 0btn3500
                btn_Item.Text = dt.Rows[i][3].ToString();                       //Get the name of item and make as text for button 
                btn_Item.AutoSize = true;
                btn_Item.Height = 70;
                btn_Item.FlatStyle = FlatStyle.Flat;
                btn_Item.FlatAppearance.BorderSize = 2;
                btn_Item.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 124, 0);
                btn_Item.Font = new Font("Changa", 13, FontStyle.Regular);
                btn_Item.Click += new EventHandler(Set_ItmesGrid);
                flowLayoutPanel_displayItems.Controls.Add(btn_Item);
            }
        }

        private void CheckOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private Double Calcuation()
        {
            Double Total = 0;
            for (int RowIndex = 0; RowIndex < dataGridView_OrderDetail.Rows.Count; RowIndex++)
            {
                Total = Total + Convert.ToDouble(dataGridView_OrderDetail["Column_PriceTotal",RowIndex].Value);
            }
            txt_Total.Text = Total.ToString();
            txt_Total.Text = String.Format("{0:##,##}", Double.Parse(txt_Total.Text));
            if(txt_Total.Text=="")
            {
                txt_Total.Text = "0";
            }
            return Total;
        }

        private void SetFlowLayoutPanel_GetTableNumber(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            TableFlag = 1;
            TableNumber = int.Parse(clickedbutton.Text);
        }

        /// <summary>
        ////////////////////////////////////Actions////////////////////////

        private void Exit_Click(object sender, EventArgs e)
        {
            invoiceForm.ActiveForm.Close();
        }

        private void btn_ShowIAllitems_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_DisplayCategory.Controls.Clear();
            DataTable dt_Category = new DataTable();
            dt_Category = UsedClass.selectdata("GET_ALL_CATEGORY", null);
            for(int i=0; i< dt_Category.Rows.Count; i++)
            {
                Button btn_Category = new Button();
                btn_Category.Name = dt_Category.Rows[i][0].ToString();
                btn_Category.Text = dt_Category.Rows[i][1].ToString();
                btn_Category.AutoSize = true;
                btn_Category.Height = 70;
                btn_Category.FlatStyle = FlatStyle.Flat;
                btn_Category.FlatAppearance.BorderSize = 2;
                btn_Category.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 124, 0);
                btn_Category.Font = new Font("Changa", 12, FontStyle.Regular);
                btn_Category.Click += new EventHandler(SetFlowLayoutPanel_DisplayItmes);
                flowLayoutPanel_DisplayCategory.Controls.Add(btn_Category);
            }
            //Code for Dispaly Tables
            flowLayoutPanel_DisplayTables.Controls.Clear();
            DataTable dt_Tables = new DataTable();
            dt_Tables = UsedClass.selectdata("GET_ALL_Tables", null);
            for (int j=0; j< dt_Tables.Rows.Count; j++)
            {
                Button btn_Tables = new Button();
                btn_Tables.Name = "btn" + dt_Tables.Rows[j][0].ToString();
                btn_Tables.Text = dt_Tables.Rows[j][1].ToString();
                btn_Tables.AutoSize = true;
                btn_Tables.Height = 70;
                btn_Tables.FlatStyle = FlatStyle.Flat;
                btn_Tables.FlatAppearance.BorderSize = 2;
                btn_Tables.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 124, 0);
                btn_Tables.Font = new Font("Changa", 13,FontStyle.Regular);
                btn_Tables.Click += new EventHandler(SetFlowLayoutPanel_GetTableNumber);
                flowLayoutPanel_DisplayTables.Controls.Add(btn_Tables);
                flowLayoutPanel_DisplayTables.Visible = true;
            }
        }

        private void btn_InsideRestrant_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_DisplayTables.Visible = true;
            flowLayoutPanel_DisplayTables.Controls.Clear();
            DataTable dt_Tables = new DataTable();
            dt_Tables = UsedClass.selectdata("GET_ALL_Tables", null);
            for (int j = 0; j < dt_Tables.Rows.Count; j++)
            {
                Button btn_Tables = new Button();
                btn_Tables.Name = "btn" + dt_Tables.Rows[j][0].ToString();
                btn_Tables.Text = dt_Tables.Rows[j][1].ToString();
                btn_Tables.AutoSize = true;
                btn_Tables.Height = 70;
                btn_Tables.FlatStyle = FlatStyle.Flat;
                btn_Tables.FlatAppearance.BorderSize = 2;
                btn_Tables.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 124, 0);
                btn_Tables.Font = new Font("Changa", 13, FontStyle.Regular);
                btn_Tables.Click += new EventHandler(SetFlowLayoutPanel_GetTableNumber);
                flowLayoutPanel_DisplayTables.Controls.Add(btn_Tables);
            }
        }       

        private void btn_OutSideRestrant_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_DisplayTables.Visible = false;
            TableFlag = 0;
        }

        private void dataGridView_OrderDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_OrderDetail.Columns[e.ColumnIndex].Name == "Column_ItemPCS")
            {
                int x = Convert.ToInt16(dataGridView_OrderDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                dataGridView_OrderDetail["Column_PriceTotal", e.RowIndex].Value = (x) * Convert.ToInt16(dataGridView_OrderDetail["Column_ItemPrice", e.RowIndex].Value.ToString());
                Calcuation();
                txt_Discount.Text = "";
            }
        }

        private void dataGridView_OrderDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(CheckOnlyNumbers);
        }

        private void dataGridView_OrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                foreach (DataGridViewRow item in this.dataGridView_OrderDetail.SelectedRows)
                {
                    dataGridView_OrderDetail.Rows.RemoveAt(item.Index);
                }
                Calcuation();
                txt_Discount.Text = "";
            }
        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            if(txt_Discount.Text=="")
            {
                txt_Discount.Text = "";
                Calcuation();
            }
            else
            {
                Double Total = Calcuation();
                Double Discount = Convert.ToDouble(txt_Discount.Text);
                Total = Total - Discount;
                txt_Total.Text = Total.ToString();
                txt_Total.Text = String.Format("{0:##,##}", Double.Parse(txt_Total.Text));
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Decimal OrderID = 0;
            //DataTable dt = new DataTable();
            //dt = UsedClass.selectdata("Get_OrderID", null);

            //for(int i =0; i<dt.Rows.Count;i++)
            //{
            //    if(dt.Rows[i][0].ToString()=="")
            //    {
            //        OrderID = 0;
            //    }
            //    else
            //    {
            //        OrderID = Convert.ToDecimal(dt.Rows[i][0].ToString());
            //    }

            //}
            Get_Order_ID();
            OrderID = OrderID + 1;
            SqlParameter[] parm = new SqlParameter[8];
            for (int RowIndex = 0; RowIndex < dataGridView_OrderDetail.Rows.Count; RowIndex++)
            {
                parm[0] = new SqlParameter("@orderID", SqlDbType.BigInt);
                parm[0].Value = OrderID;
                //
                parm[1] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
                parm[1].Value = dataGridView_OrderDetail["Column_ItemName", RowIndex].Value.ToString();
                //
                parm[2] = new SqlParameter("@itemprice", SqlDbType.Int);
                parm[2].Value = Int16.Parse(dataGridView_OrderDetail["Column_ItemPrice", RowIndex].Value.ToString());
                //
                parm[3] = new SqlParameter("@quantity", SqlDbType.Int);
                parm[3].Value = Int16.Parse(dataGridView_OrderDetail["Column_ItemPCS", RowIndex].Value.ToString());
                //
                parm[4] = new SqlParameter("@totalPrice", SqlDbType.Int);
                parm[4].Value = Int16.Parse(dataGridView_OrderDetail["Column_PriceTotal", RowIndex].Value.ToString());
                //
                parm[5] = new SqlParameter("@INorOUT", SqlDbType.Bit);
                parm[5].Value = TableFlag;
                //
                if (TableFlag == 0)
                {
                    TableNumber = 0;
                }
                parm[6] = new SqlParameter("@TableNumber", SqlDbType.Int);
                parm[6].Value = TableNumber;
                //
                parm[7] = new SqlParameter("@EnteredUser", SqlDbType.NVarChar, 100);
                parm[7].Value = "Mustafa";
                UsedClass.ExecuteCommand("InsertOrders", parm);
            }
            if(dataGridView_OrderDetail.Rows.Count==0)
            {
               //nothing to do
            }
            else
            {

                SqlParameter[] parm2 = new SqlParameter[3];

                parm2[0] = new SqlParameter("@Order_Id", SqlDbType.BigInt);
                parm2[0].Value = OrderID;
                //
                parm2[1] = new SqlParameter("@TotalMoney", SqlDbType.Float);
                parm2[1].Value = Convert.ToDouble(txt_Total.Text);
                //
                if (txt_Discount.Text != "")
                {
                    parm2[2] = new SqlParameter("@TotalDiscount", SqlDbType.Float);
                    parm2[2].Value = Convert.ToDouble(txt_Discount.Text);
                }
                else
                {
                    parm2[2] = new SqlParameter("@TotalDiscount", SqlDbType.Float);
                    parm2[2].Value = 0;
                }
                UsedClass.ExecuteCommand("InsertMoney", parm2);
                MessageBox.Show("تمت عملية الحفظ");
                dataGridView_OrderDetail.Rows.Clear();
                txt_Discount.Text = "";
                txt_Total.Text = "0";
                Get_Order_ID();
                OrderID++;
                label_invoiceNO.Text = OrderID.ToString();
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(dataGridView_OrderDetail.Rows.Count == 0)
            {
                //no thing to do
            }
            else
            {
                DialogResult Result = MessageBox.Show("هـــل تريــد الــغاء الطــلب", "الــغاء الطب", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Result==DialogResult.Yes)
                {
                    dataGridView_OrderDetail.Rows.Clear();
                }
            }
        }
    }
}
