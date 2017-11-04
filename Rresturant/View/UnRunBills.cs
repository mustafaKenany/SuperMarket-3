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
            BasicClass.flagModified = false;
            fillgridview_withoutCondition(dataGridView_RuningBuyInvoices, "Run", "بيع"); //fill data grid view of Running Buy inovices
            fillgridview_withoutCondition(dataGridView_SavedbuyInvoices, "Save", "بيع"); //fill data grid view of Running Buy inovices
            fillgridview_withoutCondition(dataGridView_unRunBuyInvoices, "Not Run", "بيع"); //fill data grid view of Running Buy inovices
            fillgridview_withoutCondition(dataGridView_RuningSalingInvoices, "Run", "شراء"); //fill data grid view of Running Buy inovices
            fillgridview_withoutCondition(dataGridView_unRunSalinginvoce, "Not Run", "شراء"); //fill data grid view of Running Buy inovices

        }

        private void fillgridview_withoutCondition(DataGridView grid, string invoicesStatus, string invoicesType)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
            param[0].Value = invoicesType;
            param[1] = new SqlParameter("@invoiceStatus", SqlDbType.NVarChar, 150);
            param[1].Value = invoicesStatus;
            dt = usedClass.selectdata("select_UnRunInvoice_byType_and_Status", param);
            grid.DataSource = dt;
        }

        private void fillgridview_withCondition(DataGridView grid, string invoicesStatus, string invoiceType, string invoiceCondition)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@invoiceType", SqlDbType.NVarChar, 150);
            param[0].Value = invoiceType;
            param[1] = new SqlParameter("@invoiceStatus", SqlDbType.NVarChar, 150);
            param[1].Value = invoicesStatus;
            param[2] = new SqlParameter("@invoiceFilter", SqlDbType.NVarChar, 150);
            param[2].Value = invoiceCondition;
            dt = usedClass.selectdata("select_unRunBill_using_type_and_filter_and_status", param);
            grid.DataSource = dt;
        }

        private void call_invoiceForm(DataGridViewCellEventArgs e,DataGridView grid,string GridColumn)
        {
            BasicClass.UnrnningBillId = Int16.Parse(grid[GridColumn, e.RowIndex].Value.ToString());
            Invoice_Form form = new Invoice_Form();
            form.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// //////////////////////////////////functions//////////////////////


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

        private void textBox_RuningBuyInvoice_TextChanged(object sender, EventArgs e)
        {
            if (textBox_RuningBuyInvoice.Text == "")
            {
                fillgridview_withoutCondition(dataGridView_RuningBuyInvoices, "Run", "بيع"); //fill data grid view of Running Buy inovices
            }
            else
            {
                fillgridview_withCondition(dataGridView_RuningBuyInvoices, "Run", "بيع", textBox_RuningBuyInvoice.Text);
            }
        }

        private void textBox_SaveBuyInvoice_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SaveBuyInvoice.Text == "")
            {
                fillgridview_withoutCondition(dataGridView_SavedbuyInvoices, "Save", "بيع"); //fill data grid view of Running Buy inovices
            }
            else
            {
                fillgridview_withCondition(dataGridView_SavedbuyInvoices, "Save", "بيع", textBox_SaveBuyInvoice.Text);
            }
        }

        private void txt_unRunBuyInvoice_TextChanged(object sender, EventArgs e)
        {
            if (txt_unRunBuyInvoice.Text == "")
            {
                fillgridview_withoutCondition(dataGridView_unRunBuyInvoices, "Not Run", "بيع"); //fill data grid view of Running Buy inovices

            }
            else
            {
                fillgridview_withCondition(dataGridView_unRunBuyInvoices, "Not Run", "بيع", txt_unRunBuyInvoice.Text);
            }
        }

        private void textBox_RunSalinginvoice_TextChanged(object sender, EventArgs e)
        {
            if (textBox_RunSalinginvoice.Text == "")
            {
                fillgridview_withoutCondition(dataGridView_RuningSalingInvoices, "Run", "شراء"); //fill data grid view of Running Buy inovices
            }
            else
            {
                fillgridview_withCondition(dataGridView_RuningSalingInvoices, "Run", "شراء", textBox_RunSalinginvoice.Text);
            }
        }

        private void textBox_unRunSalinginvoice_TextChanged(object sender, EventArgs e)
        {
            if (textBox_unRunSalinginvoice.Text == "")
            {
                fillgridview_withoutCondition(dataGridView_unRunSalinginvoce, "Not Run", "شراء"); //fill data grid view of Running Buy inovices
            }
            else
            {
                fillgridview_withCondition(dataGridView_unRunSalinginvoce, "Not Run", "شراء", textBox_unRunSalinginvoice.Text);
            }
        }

        private void dataGridView_SavedbuyInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                BasicClass.flagModified = true;
                call_invoiceForm(e, dataGridView_SavedbuyInvoices, "billNumber_SavedInvoices");
            }
            else if (e.ColumnIndex == 1)
            {

            }
        }

        private void dataGridView_unRunBuyInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                call_invoiceForm(e,dataGridView_unRunBuyInvoices, "billNumber_unRunBuyinginvoices");
            }
            else if (e.ColumnIndex == 1)
            {

            }
        }

        private void dataGridView_RuningBuyInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //BasicClass.flagModified = true;
                //BasicClass.UnrnningBillId = Int16.Parse(dataGridView_RuningBuyInvoices["billNumber_RunnigInvoices", e.RowIndex].Value.ToString());
                //Invoice_Form form = new Invoice_Form();
                //form.ShowDialog();
                //this.Close();
                MessageBox.Show("حالة التعديل لا يمكن ان تتم على قوائم منفذة ومرحلة\nاذا كانت حالة زيادة في التجهيز قم بعمل ملحق للفاتورة\nاذا كانت حالة نقص قم بعمل فاتورة شراء من العميل", "Message");
            }
            else
            {

            }
        }

        private void dataGridView_RuningSalingInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==0)
            {
                //BasicClass.flagModified = true;
                //BasicClass.UnrnningBillId = Int16.Parse(dataGridView_RuningSalingInvoices["billNumber_RunnigSaleInvoice", e.RowIndex].Value.ToString());
                //SalesForm form = new SalesForm();
                //form.ShowDialog();
                //this.Close();
                MessageBox.Show("حالة التعديل لا يمكن ان تتم على قوائم منفذة ومرحلة\nاذا كانت حالة زيادة في التجهيز قم بعمل ملحق للفاتورة\nاذا كانت حالة نقص قم بعمل فاتورة بيع الى العميل", "Message");
            }
        }

        private void dataGridView_unRunSalinginvoce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                
                BasicClass.UnrnningBillId = Int16.Parse(dataGridView_unRunSalinginvoce["billNumber_unRunSalingInvoices", e.RowIndex].Value.ToString());
                SalesForm form = new SalesForm();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
