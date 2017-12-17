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

namespace Rresturant.View
{
    public partial class UnInvoices_and_Users : Form
    {
        BasicClass usedclass = new BasicClass();
        DataTable dt = new DataTable();

        public UnInvoices_and_Users()
        {
            InitializeComponent();
            initializeFunction();
        }

        private void initializeFunction()
        {
            dt = usedclass.selectdata("Select_Users", null);
            dataGridView_Users.DataSource = dt;
            fillgridview_withoutCondition(dataGridView_saveBuyingInvoice, "Save", "بيع"); //fill data grid view of Running Buy inovices
            fillgridview_withoutCondition(dataGridView_unRunBuyingInvoices, "Not Run", "بيع"); //fill data grid view of Running Buy inovices

        }

        private void fillgridview_withoutCondition(DataGridView grid, string invoicesStatus, string invoicesType)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
            param[0].Value = invoicesType;
            param[1] = new SqlParameter("@invoiceStatus", SqlDbType.NVarChar, 150);
            param[1].Value = invoicesStatus;
            dt = usedclass.selectdata("select_UnRunInvoice_byType_and_Status", param);
            grid.DataSource = dt;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            UnInvoices_and_Users.ActiveForm.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage_users)
            {
                label_form.Text = "الزبائن";
            }
            else
                if (tabControl1.SelectedTab == tabPage_SaveInvoices)
            {
                label_form.Text = "القوائم المحجوزة";
            }
            else if (tabControl1.SelectedTab == tabPage_unRunInvoices)
            {
                label_form.Text = "القوائم المعلقة";
            }
        }

        private void textBox_Userfilter_TextChanged(object sender, EventArgs e)
        {

            if (textBox_Userfilter.Text == "")
            {
                dt = usedclass.selectdata("Select_Users", null);
                dataGridView_Users.DataSource = dt;
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                param[1] = new SqlParameter("@CoustomerFilter", SqlDbType.NVarChar, 150);
                param[1].Value = textBox_Userfilter.Text;
                usedclass.ExecuteCommand("select_Coustomers_using_ID_or_Name", param);
            }
        }

        private void dataGridView_Users_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BasicClass.CoustomerName = dataGridView_Users["Column_userName", e.RowIndex].Value.ToString();
            
            this.Close();
        }

        private void dataGridView_saveBuyingInvoice_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BasicClass.UnrnningBillId = Int16.Parse(dataGridView_saveBuyingInvoice["Column_BillID", e.RowIndex].Value.ToString());
            BasicClass.flagModified = true;

            this.Close();

        }

        private void dataGridView_unRunBuyingInvoices_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BasicClass.UnrnningBillId = Int16.Parse(dataGridView_unRunBuyingInvoices["dataGridViewTextBoxColumn1", e.RowIndex].Value.ToString());
            BasicClass.flagModified = true;
            this.Close();

        }

        private void dataGridView_saveBuyingInvoice_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {

        }
    }
}
