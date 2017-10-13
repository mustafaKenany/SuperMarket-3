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
    public partial class UnRunBills : Form
    {
        BasicClass usedClass = new BasicClass();
        DataTable dt = new DataTable();

        public UnRunBills()
        {
            InitializeComponent();
            initializeFunction();
            
        }

        private void initializeFunction()
        {
            BasicClass.UnrnningBillId = 0;
            filldatagridview(dataGridView_RuningBuyInvoices, "Run", "بيع"); //fill data grid view of Running Buy inovices
            filldatagridview(dataGridView_SavedbuyInvoices, "Save", "بيع"); //fill data grid view of Running Buy inovices
            filldatagridview(dataGridView_unRunBuyInvoices, "Not Run", "بيع"); //fill data grid view of Running Buy inovices
            filldatagridview(dataGridView_RuningSalingInvoices, "Run", "شراء"); //fill data grid view of Running Buy inovices
            filldatagridview(dataGridView_unRunSalinginvoce, "Not Run", "شراء"); //fill data grid view of Running Buy inovices

        }

        private void filldatagridview(DataGridView grid, string invoicestatus, string invoicetype)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
            param[0].Value = invoicetype;
            param[1] = new SqlParameter("@invoiceStatus", SqlDbType.NVarChar, 150);
            param[1].Value = invoicestatus;
            dt = usedClass.selectdata("select_UnRunInvoice_byType_and_Status", param);
            grid.DataSource= dt;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_FilterBuying_TextChanged(object sender, EventArgs e)
        {
            if (txt_unRunBuyInvoice.Text == "")
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
                param[0].Value = "بيع";
                dt = usedClass.selectdata("select_UnRunInvoice_byType", param);
                dataGridView_RuningSalingInvoices.DataSource = dt;
            }
            else
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
                param[0].Value = "بيع";
                param[1] = new SqlParameter("@invoiceFilter", SqlDbType.NVarChar, 150);
                param[1].Value = txt_unRunBuyInvoice.Text;

                dt = usedClass.selectdata("select_unRunBill_using_type_and_filter", param);
                dataGridView_unRunBuyInvoices.DataSource = dt;
            }
        }
        
        private void textBox_filterSaling_TextChanged(object sender, EventArgs e)
        {
            if (textBox_RunSalinginvoice.Text == "")
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
                param[0].Value = "شراء";
                dt = usedClass.selectdata("select_UnRunInvoice_byType", param);
                dataGridView_RuningSalingInvoices.DataSource = dt;
            }
            else
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
                param[0].Value = "شراء";
                param[1] = new SqlParameter("@invoiceFilter", SqlDbType.NVarChar, 150);
                param[1].Value = textBox_RunSalinginvoice.Text;

                dt = usedClass.selectdata("select_unRunBill_using_type_and_filter", param);
                dataGridView_RuningSalingInvoices.DataSource = dt;
            }
        }

        private void dataGridView_saleBillUnRun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex >= 0)
                {
                    //code for editing Sale Invoice
                    SalesForm form = new SalesForm();
                    BasicClass.UnrnningBillId = Int16.Parse(dataGridView_RuningSalingInvoices["Column_billiD", e.RowIndex].Value.ToString());
                    this.Close();
                    form.ShowDialog();
                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (e.RowIndex >= 0)
                {
                    //code for deleteing Sale Inovice
                    MessageBox.Show(dataGridView_RuningSalingInvoices["Column_billiD", e.RowIndex].Value.ToString());
                }
            }
        }

        private void dataGridView_buy_InvoiceUnRun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex>=0)
                {
                    //code for editing Buy Invoice                    
                    BasicClass.UnrnningBillId = Int16.Parse(dataGridView_unRunBuyInvoices["Column_Buy_billiD", e.RowIndex].Value.ToString());
                    Invoice_Form form = new Invoice_Form();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (e.ColumnIndex == 1)
            {
                if (e.RowIndex >= 0)
                {
                    //code for deleting Buy Invoice 
                    DialogResult result = MessageBox.Show("هل تريد حذف القائمة فعلا، عملية الحذف سوف تؤدي الى فقدان رقم القائمة", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    MessageBox.Show(dataGridView_unRunBuyInvoices["Column_Buy_billiD", e.RowIndex].Value.ToString());
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
