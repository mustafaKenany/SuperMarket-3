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

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
            param[0].Value = "بيع";
            param[1] = new SqlParameter("@invoiceStatus", SqlDbType.NVarChar, 100);
            param[1].Value = "Save";
            dt = usedclass.selectdata("select_UnRunInvoice_byType_and_Status", param);
            dataGridView_Save_Invoices.DataSource = dt;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            UnInvoices_and_Users.ActiveForm.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage_users)
            {
                dt = usedclass.selectdata("Select_Users", null);
                dataGridView_Users.DataSource = dt;
                label_form.Text = "الزبائن";
            }
            else
                if (tabControl1.SelectedTab == tabPage_SaveInvoices)
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
                param[0].Value = "بيع";
                param[1] = new SqlParameter("@invoiceStatus", SqlDbType.NVarChar, 100);
                param[1].Value = "Save";
                dt = usedclass.selectdata("select_UnRunInvoice_byType_and_Status", param);
                dataGridView_Save_Invoices.DataSource = dt;
                label_form.Text = "القوائم المحجوزة";
            }
            else if (tabControl1.SelectedTab == tabPage_unRunInvoices)
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
                param[0].Value = "بيع";
                param[1] = new SqlParameter("@invoiceStatus", SqlDbType.NVarChar, 100);
                param[1].Value = "Not Run";
                dt = usedclass.selectdata("select_UnRunInvoice_byType_and_Status", param);
                dataGridView_unRunInvoices.DataSource = dt;
                label_form.Text = "القوائم المعلقة";
            }
        }

        private void dataGridView_Users_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BasicClass.CoustomerName = dataGridView_Users["Column_userName", e.RowIndex].Value.ToString();
            this.Close();
        }

        private void dataGridView_Save_Invoices_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BasicClass.UnrnningBillId = Int16.Parse(dataGridView_Save_Invoices["Column_BillID", e.RowIndex].Value.ToString());
            this.Close();
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                dt = usedclass.selectdata("Select_Users", null);
                dataGridView_Users.DataSource = dt;
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@CoustomerFilter", SqlDbType.NVarChar,150);
                param[0].Value = textBox1.Text;
                dt = usedclass.selectdata("select_Coustomers_using_ID_or_Name", param);
                dataGridView_Users.DataSource = dt;
            }
        }

        private void dataGridView_unRunInvoices_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BasicClass.UnrnningBillId = Int16.Parse(dataGridView_unRunInvoices["dataGridViewTextBoxColumn1", e.RowIndex].Value.ToString());
            this.Close();
        }
    }
}
