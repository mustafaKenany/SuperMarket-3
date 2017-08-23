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
    public partial class stteingscs : Form
    {
        BasicClass usedClass = new BasicClass();
        public stteingscs()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /////////////////////////////////////////Functions Section////////////////////////
        /// </summary>
        private void displayAllitemsInGridView(int choice, string name)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            switch (choice)
            {
                case 1:
                    param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
                    param[0].Value = name;
                    dt = usedClass.selectdata("get_All_items_by_categoryName", param);
                    //
                    dataGridView_displayitems.DataSource = dt;
                    break;
                case 2:
                    param[0] = new SqlParameter("@itemname", SqlDbType.NVarChar, 50);
                    param[0].Value = name;
                    dt = usedClass.selectdata("get_specfic_item", param);
                    //
                    dataGridView_displayitems.DataSource = dt;
                    break;
                case 3:
                    param[0] = new SqlParameter("@barCode", SqlDbType.NVarChar, 100);
                    param[0].Value = name;
                    dt = usedClass.selectdata("get_items_by_barcode", param);
                    //
                    dataGridView_displayitems.DataSource = dt;
                    break;
                default:
                    break;
            }
            
        }
        ///////////////////////////////////////////////button Actions Section//////////////////
        private void Exit_Click(object sender, EventArgs e)
        {
            stteingscs.ActiveForm.Close();
        }

        private void btn_addNewCategory_Click(object sender, EventArgs e)
        {
            if (txt_newCategoryName.Text == "")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@categoryName", SqlDbType.NVarChar, 50);
                param[0].Value = txt_newCategoryName.Text;
                //
                param[1] = new SqlParameter("@EnteredUser", SqlDbType.NVarChar, 100);
                param[1].Value = "Mustafa";

                usedClass.ExecuteCommand("InsertNewCategory", param);
                txt_newCategoryName.Text = "";
                MessageBox.Show("تمت الاضافة بنجاح", "أضـــافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_addNewItem_Click(object sender, EventArgs e)
        {
            if(combo_chooseCategoryName.Text=="" || txt_newItemName.Text=="" )
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[6];     //information from design and Username
                //
                param[0] = new SqlParameter("@itemName", SqlDbType.NVarChar, 50);
                param[0].Value = txt_newItemName.Text;
                //
                param[1] = new SqlParameter("@itemCategory", SqlDbType.NVarChar, 50);
                param[1].Value = combo_chooseCategoryName.Text;
                //
                param[2] = new SqlParameter("@PcsInsideCarton", SqlDbType.Int);
                if (txt_PCSinsideCarton.Text != "")
                {
                    param[2].Value = int.Parse(txt_PCSinsideCarton.Text);
                }
                else 
                {
                    param[2].Value = 0;
                }
                //
                param[3] = new SqlParameter("@CriticalQuantity", SqlDbType.Int);
                if (txt_CriticalQuantity.Text != "")
                {
                    param[3].Value = int.Parse(txt_CriticalQuantity.Text);
                }
                else
                {
                    param[3].Value = 0;
                }
                //
                param[4] = new SqlParameter("@ItemBarcode", SqlDbType.NVarChar, 100);
                if (maskedTextBox_BarCodeItem.Text != "")
                {
                    param[4].Value = maskedTextBox_BarCodeItem.Text;
                }
                else
                {
                    param[4].Value =0;
                }
                //
                param[5] = new SqlParameter("@EnteredUser", SqlDbType.NVarChar, 100);
                param[5].Value = "Mustafa";


                usedClass.ExecuteCommand("insertNewItems", param);
                combo_chooseCategoryName.Text = "";
                txt_newItemName.Text = "";
                txt_PCSinsideCarton.Text = "";
                txt_CriticalQuantity.Text = "";
                maskedTextBox_BarCodeItem.Text = "";
                MessageBox.Show("تمت الاضافة بنجاح", "أضـــافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ModifyCateg_Click(object sender, EventArgs e)
        {
            if(combo_ModifedCategoryName.Text=="" || txt_modifedCategName.Text=="")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[2];
                Int32 CategID = Convert.ToInt32(combo_ModifedCategoryName.SelectedValue);
                param[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
                param[0].Value = CategID;
                //
                param[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
                param[1].Value = txt_modifedCategName.Text;
                //
                usedClass.ExecuteCommand("Re_nameCategory", param);
                combo_ModifedCategoryName.Text = "";
                txt_modifedCategName.Text = "";
                MessageBox.Show("تمت عملــية الـــتعــديـل ينجاح", "الـــتعــديـل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_DeleteCateg_Click(object sender, EventArgs e)
        {
            if (combo_deleteCategory.Text == "")
            {
                MessageBox.Show("يرجى التأكد من ادخال المعلومات بشكل كامل", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                Int32 CategID = Convert.ToInt32(combo_deleteCategory.SelectedValue);
                param[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
                param[0].Value = CategID;
                //
                DialogResult Result = MessageBox.Show("عملية الحذف سوف تؤدي الى حذف العناصر التي تنتمي لهذا الصنف", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                if (Result == DialogResult.Yes)
                {
                    usedClass.ExecuteCommand("deleteCategory", param);
                    combo_deleteCategory.Text = "";
                    combo_deleteCategory.Refresh();
                    MessageBox.Show("تمت عملــية الـــحـــذف ينجاح", "الـــحـــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        /// <summary>
        /// ///////////////////
        ///////////////////////////////////Combobox actions//////////////////////
        private void combo_chooseCategoryName_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = usedClass.selectdata("Get_All_Category", null);
            //
            combo_chooseCategoryName.DataSource = dt;
            combo_chooseCategoryName.DisplayMember = "CatergoryName";
            combo_chooseCategoryName.ValueMember = "CategoryID";
        }

        private void combo_CategoryinModifiedorDeleteSection_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = usedClass.selectdata("Get_All_Category", null);
            //
            combo_CategoryinModifiedorDeleteSection.DataSource = dt;
            combo_CategoryinModifiedorDeleteSection.DisplayMember = "CatergoryName";
            combo_CategoryinModifiedorDeleteSection.ValueMember = "CategoryID";
        }



        private void combo_ChosingItemName_DropDown(object sender, EventArgs e)
        {
            if (combo_CategoryinModifiedorDeleteSection.Text == "")
            {
                MessageBox.Show("يرجى التأكد من اختيار المجموعة لعرض المواد التي تحويها", "خــــطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 50);
                param[0].Value = combo_CategoryinModifiedorDeleteSection.Text;

                DataTable dt = new DataTable();
                dt = usedClass.selectdata("get_All_items_by_categoryName", param);

                combo_ChosingItemName.DataSource = dt;
                combo_ChosingItemName.DisplayMember = "ItemName";
                combo_ChosingItemName.ValueMember = "ItemID";
                displayAllitemsInGridView(2, combo_ChosingItemName.Text);
            }

        }

        private void combo_ModifedCategoryName_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = usedClass.selectdata("Get_All_Category", null);
            //
            combo_ModifedCategoryName.DataSource = dt;
            combo_ModifedCategoryName.DisplayMember = "CatergoryName";
            combo_ModifedCategoryName.ValueMember = "CategoryID";
        }

        private void combo_deleteCategory_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = usedClass.selectdata("Get_All_Category", null);
            //
            combo_deleteCategory.DataSource = dt;
            combo_deleteCategory.DisplayMember = "CatergoryName";
            combo_deleteCategory.ValueMember = "CategoryID";
        }

        private void combo_CategoryinModifiedorDeleteSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayAllitemsInGridView(1, combo_CategoryinModifiedorDeleteSection.Text);
        }

        private void combo_ChosingItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayAllitemsInGridView(2, combo_ChosingItemName.Text);
        }

        private void maskedTextBox_BarCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            displayAllitemsInGridView(3, maskedTextBox_BarCode.Text);
        }

        
    }
}
