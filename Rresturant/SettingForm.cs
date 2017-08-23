using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Rresturant
{
    public partial class SettingForm : Form
    {
        BasicClass UsedClass = new BasicClass();
        public SettingForm()
        {
            InitializeComponent();            
        }
        //functions

        private void Exit_Click(object sender, EventArgs e)
        {
            SettingForm.ActiveForm.Close();
        }

        private void txt_CatName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UsedClass.OnlyLettersFunction(e);
        }

        private void btn_NewOK_Click(object sender, EventArgs e)
        {
           
            if(txt_CatName.Text=="")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل","خــــطأ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@CategName", SqlDbType.NVarChar, 50);
                param[0].Value = txt_CatName.Text;
                //
                param[1] = new SqlParameter("@EnteredUser", SqlDbType.NVarChar, 100);
                param[1].Value = "Mustafa";

                UsedClass.ExecuteCommand("InsertCategory", param);
                txt_CatName.Text = "";
                MessageBox.Show("تمت الاضافة بنجاح", "أضـــافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btn_addNewItem_Click(object sender, EventArgs e)
        {
            if (txt_ItmeName.Text == "" || txt_itemPrice.Text == "" || combo_Categ_newItem.Text=="")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 50);
                param[0].Value = txt_ItmeName.Text;
                //
                param[1] = new SqlParameter("@CatgName", SqlDbType.NVarChar, 50);
                param[1].Value = combo_Categ_newItem.Text;
                //
                Int32 ItemPrice = Convert.ToInt32(txt_itemPrice.Text);
                param[2] = new SqlParameter("@ItemPrice", SqlDbType.Int);
                param[2].Value = ItemPrice;
                //
                param[3] = new SqlParameter("@EnteredUser", SqlDbType.NVarChar, 100);
                param[3].Value = "Mustafa";
                //
                Int32 CategID = Convert.ToInt32(combo_Categ_newItem.SelectedValue);
                param[4] = new SqlParameter("@CategID", SqlDbType.Int);
                param[4].Value = CategID;

                UsedClass.ExecuteCommand("InsertNewItem", param);
                txt_itemPrice.Text = String.Format("{0:##,##}", Int32.Parse(txt_itemPrice.Text));
                MessageBox.Show("تمت الاضافة بنجاح", "أضـــافة",MessageBoxButtons.OK,MessageBoxIcon.Information);
                combo_Categ_newItem.Text = "";
                txt_ItmeName.Text = "";
                txt_itemPrice.Text = "";
            }

        }

        private void combo_Categ_newItem_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_CATEGORY", null);
            //
            combo_Categ_newItem.DataSource = dt;
            combo_Categ_newItem.DisplayMember = "CatName";
            combo_Categ_newItem.ValueMember = "CatID";
        }

        private void combo_Categ_modifyItem_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_CATEGORY", null);
            //
            combo_Categ_modifyItem.DataSource = dt;
            combo_Categ_modifyItem.DisplayMember = "CatName";
            combo_Categ_modifyItem.ValueMember = "CatID";
        }

        private void combo_Categ_deleteItem_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_CATEGORY", null);
            //
            combo_Categ_deleteItem.DataSource = dt;
            combo_Categ_deleteItem.DisplayMember = "CatName";
            combo_Categ_deleteItem.ValueMember = "CatID";
        }

        private void combo_ModifyCateg_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_CATEGORY", null);
            //
            combo_ModifyCateg.DataSource = dt;
            combo_ModifyCateg.DisplayMember = "CatName";
            combo_ModifyCateg.ValueMember = "CatID";
        }

        private void combo_deleteCateg_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_CATEGORY", null);
            //
            combo_deleteCateg.DataSource = dt;
            combo_deleteCateg.DisplayMember = "CatName";
            combo_deleteCateg.ValueMember = "CatID";
        }

        private void combo_PrevoiusItemName_DropDown(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[1];
            Int32 CategID = Convert.ToInt32(combo_Categ_modifyItem.SelectedValue);
            param[0] = new SqlParameter("@CategID", SqlDbType.Int);
            param[0].Value = CategID;
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_Items_BY_CATID", param);
            //
            combo_PrevoiusItemName.DataSource = dt;
            combo_PrevoiusItemName.DisplayMember = "ItemName";
            combo_PrevoiusItemName.ValueMember = "ItemID";
        }

        private void combo_Categ_modifyItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_PrevoiusItemName.DataSource = null;
        }

        private void btn_ModifyItmeName_Click(object sender, EventArgs e)
        {
            if(combo_Categ_modifyItem.Text=="" || combo_PrevoiusItemName.Text=="" || txt_newItemName.Text=="")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@newItemName", SqlDbType.NVarChar, 50);
                param[0].Value = txt_newItemName.Text;
                //
                Int32 ItemID = Convert.ToInt32(combo_PrevoiusItemName.SelectedValue);
                param[1] = new SqlParameter("@ItemID", SqlDbType.Int);
                param[1].Value = ItemID;
                //
                UsedClass.ExecuteCommand("ModifyItemName", param);
                combo_PrevoiusItemName.Text = "";
                txt_newItemName.Text = "";
                combo_Categ_modifyItem.Text = "";
                MessageBox.Show("تمت عملــية الــتعديــل ينجاح", "تـــعــديــل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void combo_DeletedItem_DropDown(object sender, EventArgs e)
        {
            SqlParameter[] param = new SqlParameter[1];
            Int32 CategID = Convert.ToInt32(combo_Categ_deleteItem.SelectedValue);
            param[0] = new SqlParameter("@CategID", SqlDbType.Int);
            param[0].Value = CategID;
            //
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_Items_BY_CATID", param);
            //
            combo_DeletedItem.DataSource = dt;
            combo_DeletedItem.DisplayMember = "ItemName";
            combo_DeletedItem.ValueMember = "ItemID";
        }

        private void combo_Categ_deleteItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_DeletedItem.DataSource=null;
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            if(combo_DeletedItem.Text=="" || combo_Categ_deleteItem.Text=="")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                Int32 ItemID = Convert.ToInt32(combo_DeletedItem.SelectedValue);
                param[0] = new SqlParameter("@ItemID", SqlDbType.Int);
                param[0].Value = ItemID;
                //
                UsedClass.ExecuteCommand("DeleteItemsByItemID", param);
                combo_Categ_deleteItem.Text = "";
                combo_DeletedItem.Text = "";
                MessageBox.Show("تمت عملــية الـــحــذف ينجاح", "حــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_CancelAdditem_Click(object sender, EventArgs e)
        {
            combo_Categ_newItem.Text = "";
            txt_ItmeName.Text = "";
            txt_itemPrice.Text = "";
        }

        private void btn_CancelModifyitem_Click(object sender, EventArgs e)
        {
            combo_Categ_modifyItem.Text = "";
            combo_PrevoiusItemName.Text = "";
            txt_newItemName.Text = "";
        }

        private void btn_CancelDeleteItme_Click(object sender, EventArgs e)
        {
            combo_Categ_deleteItem.Text = "";
            combo_DeletedItem.Text = "";
        }

        private void btn_ModifyCateg_Click(object sender, EventArgs e)
        {
            if (combo_ModifyCateg.Text == "" || txt_newCategName.Text == "")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[2];
                Int32 CategID = Convert.ToInt32(combo_ModifyCateg.SelectedValue);
                param[0] = new SqlParameter("@CategID", SqlDbType.Int);
                param[0].Value = CategID;
                //
                param[1] = new SqlParameter("@CategName", SqlDbType.NVarChar, 50);
                param[1].Value = txt_newCategName.Text;
                //
                UsedClass.ExecuteCommand("ModifyCategoryName", param);
                combo_ModifyCateg.Text = "";
                txt_newCategName.Text = "";
                MessageBox.Show("تمت عملــية الـــتعــديـل ينجاح", "الـــتعــديـل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_DeleteCateg_Click(object sender, EventArgs e)
        {
            if (combo_deleteCateg.Text == "")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                Int32 CategID = Convert.ToInt32(combo_deleteCateg.SelectedValue);
                param[0] = new SqlParameter("@CategID", SqlDbType.Int);
                param[0].Value = CategID;
                //
                DialogResult Result = MessageBox.Show("عملية الحذف سوف تؤدي الى حذف العناصر التي تنتمي لهذا الصنف", "Confirmation", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Hand);
                if(Result== DialogResult.Yes)
                {
                    UsedClass.ExecuteCommand("DeleteCategory", param);
                    combo_deleteCateg.Text = "";
                    combo_deleteCateg.Refresh();
                    MessageBox.Show("تمت عملــية الـــحـــذف ينجاح", "الـــحـــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Result == DialogResult.No)
                {
                    //...
                }
            }
        }

        private void btn_addNewTable_Click(object sender, EventArgs e)
        {
            if (txt_TableNumber.Text == "" || combo_TableType.Text=="")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[3];

                Int32 TableNumber = Convert.ToInt32(txt_TableNumber.Text);
                param[0] = new SqlParameter("@TableNumber", SqlDbType.Int);
                param[0].Value = TableNumber;
                //
                param[1] = new SqlParameter("@TableType", SqlDbType.NVarChar, 50);
                param[1].Value = combo_TableType.Text;
                //
                param[2] = new SqlParameter("@EnteredUser", SqlDbType.NVarChar, 100);
                param[2].Value = "Mustafa";

                UsedClass.ExecuteCommand("InsertNewTable", param);
                txt_TableNumber.Text = "";
                combo_TableType.Text = "";
                MessageBox.Show("تمت الاضافة بنجاح", "أضـــافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_CancelNewTable_Click(object sender, EventArgs e)
        {
            txt_TableNumber.Text = "";
            combo_TableType.Text = "";
        }

        private void combo_ChoseTableNumber_DropDown(object sender, EventArgs e)
        {            
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_Tables", null);
            //
            combo_ChoseTableNumber.DataSource = dt;
            combo_ChoseTableNumber.DisplayMember = "Table_Number";
            combo_ChoseTableNumber.ValueMember = "Table_Type";            
        }

        private void combo_ChoseTableNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            combo_ChooseTableType.Text = combo_ChoseTableNumber.SelectedValue.ToString();
            combo_ModifyTableType.Text = combo_ChoseTableNumber.SelectedValue.ToString();
            txt_ModifyTableNumber.Text = combo_ChoseTableNumber.Text;
        }

        private void btn_ModifyTable_Click(object sender, EventArgs e)
        {
            string previousTableNumber, modifiedTableNumber, previousTableType, modifiedTabletype;
            previousTableNumber = combo_ChoseTableNumber.Text;
            modifiedTableNumber = txt_ModifyTableNumber.Text;
            previousTableType = combo_ChooseTableType.Text;
            modifiedTabletype = combo_ChooseTableType.Text;
            if (previousTableNumber == "" || modifiedTableNumber == "" || previousTableType == "" || modifiedTabletype == "")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if((previousTableNumber.Equals(modifiedTableNumber)) && (previousTableType.Equals(modifiedTabletype)))
                {
                   //no thing do
                }
                else
                {
                    SqlParameter[] param = new SqlParameter[3];

                    Int32 newTableNumber = Convert.ToInt32(txt_ModifyTableNumber.Text);
                    Int32 oldTableNumber = Convert.ToInt32(combo_ChoseTableNumber.Text);

                    param[0] = new SqlParameter("@oldTableNumber", SqlDbType.Int);
                    param[0].Value = oldTableNumber;
                    //
                    param[1] = new SqlParameter("@TableType", SqlDbType.NVarChar, 50);
                    param[1].Value = combo_ModifyTableType.Text;
                    //
                    param[2] = new SqlParameter("@newTableNumber", SqlDbType.NVarChar, 50);
                    param[2].Value = newTableNumber;
                    //
                    DialogResult Result = MessageBox.Show("عملية التعديل سوف تؤدي الى حذف العناصر المكررة", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                    if (Result == DialogResult.Yes)
                    {
                        UsedClass.ExecuteCommand("ModifyTableDetail", param);
                        combo_ChoseTableNumber.Text = "";
                        combo_ChooseTableType.Text = "";
                        txt_ModifyTableNumber.Text = "";
                        combo_ModifyTableType.Text = "";
                        MessageBox.Show("تمت عملــية الـــتعــديـل ينجاح", "الـــتعــديـل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("تم الغاء عملــية الـــتعــديـل ينجاح", "الـــتعــديـل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        combo_ChoseTableNumber.Text = "";
                        combo_ChooseTableType.Text = "";
                        txt_ModifyTableNumber.Text = "";
                        combo_ModifyTableType.Text = "";
                    }
                }
            }
        }

        private void btn_CancelModifyTable_Click(object sender, EventArgs e)
        {
            combo_ChoseTableNumber.Text = "";
            combo_ChooseTableType.Text = "";
            txt_ModifyTableNumber.Text = "";
            combo_ModifyTableType.Text = "";
        }

        private void combo_DeleteTable_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = UsedClass.selectdata("GET_ALL_Tables", null);
            //
            combo_DeleteTable.DataSource = dt;
            combo_DeleteTable.DisplayMember = "Table_Number";
            combo_DeleteTable.ValueMember = "Table_Type";
        }

        private void btn_DeleteTable_Click(object sender, EventArgs e)
        {
            if (combo_DeleteTable.Text == "")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                Int32 TableNumber = Convert.ToInt32(combo_DeleteTable.Text);
                param[0] = new SqlParameter("@TableNumber", SqlDbType.Int);
                param[0].Value = TableNumber;
                //
                UsedClass.ExecuteCommand("DeleteRestrantTable", param);
                combo_DeleteTable.Text = "";
                MessageBox.Show("تمت عملــية الـــحـــذف ينجاح", "الـــحـــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_CancelDeleteTable_Click(object sender, EventArgs e)
        {
            combo_DeleteTable.Text = "";
        }
    }
}
