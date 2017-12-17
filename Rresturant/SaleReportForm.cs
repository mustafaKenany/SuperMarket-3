using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class SaleReportForm : Form
    {
        public SaleReportForm()
        {
            InitializeComponent ();
            dataGridViewSaleGrid.Columns["ColumnInvoiceDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void Exit_Click(object sender , EventArgs e)
        {
            this.Close ();
        }

        private void buttonShowSaleInvoices_Click(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            if ( checkBoxDateSearch.Checked )
            {
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter ( "@InvoiceType" , SqlDbType.NVarChar , 250 );
                param[1] = new SqlParameter ( "@beginDate" , SqlDbType.NVarChar , 250 );
                param[2] = new SqlParameter ( "@endDate" , SqlDbType.NVarChar , 250 );
                param[0].Value = "شراء";
                param[1].Value = dateTimePickerFrom.Text.ToString ();
                param[2].Value = dateTimePickerTo.Text.ToString ();
                dt = usedClass.selectdata ( "Report_Select_invoices_usingDates_and_InvoiceType" , param );
                dataGridViewSaleGrid.DataSource = dt;
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter ( "@InvoiceType" , SqlDbType.NChar , 250 );
                param[0].Value = "شراء";
                dt = usedClass.selectdata ( "SelectAll_Invoices_usingType" , param );
                dataGridViewSaleGrid.DataSource = dt;
            }
            
        }

        private void textBoxFilterSalesGrid_TextChanged(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            if ( textBoxFilterSalesGrid.Text != "" )
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter ( "@InvoiceType" , SqlDbType.NChar , 250 );
                param[0].Value = "شراء";
                param[1] = new SqlParameter ( "@Filter" , SqlDbType.NVarChar , 250 );
                param[1].Value = textBoxFilterSalesGrid.Text;
                dt = usedClass.selectdata ( "SelectAll_Invoices_usingTypeAndFilter" , param );
                dataGridViewSaleGrid.DataSource = dt;
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter ( "@InvoiceType" , SqlDbType.NChar , 250 );
                param[0].Value = "شراء";
                dt = usedClass.selectdata ( "SelectAll_Invoices_usingType" , param );
                dataGridViewSaleGrid.DataSource = dt;
            }
        }

        private void dataGridViewSaleGrid_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {
            var crp = new Reports.SaleInvoiceReport ();
            var dt = new DataTable ();
            var usedClass = new BasicClass ();
            var form = new PrintForm ();
            if ( e.ColumnIndex == 0 )
            {
                if ( e.RowIndex >= 0 )
                {
                    int InvoiceNo = int.Parse ( dataGridViewSaleGrid.Rows[e.RowIndex].Cells["ColumnInvoiceNo"].Value.ToString () );
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter ( "@InvoiceNo" , SqlDbType.Int );
                    param[0].Value = InvoiceNo;
                    dt = usedClass.selectdata ( "Report_Select_SaleInvoice_usingInvoiceNo" , param );
                    TextObject invoiceType = (TextObject) crp.ReportDefinition.Sections["Section1"].ReportObjects["Text7"];
                    invoiceType.Text = dataGridViewSaleGrid.Rows[e.RowIndex].Cells["ColumnInvoiceStatus"].Value.ToString ();
                    //FormulaFieldDefinition x = crp.DataDefinition.FormulaFields["InvoiceTotalAmount"];
                    crp.SetDataSource ( dt );
                    form.crystalReportViewer1.ReportSource = crp;
                    form.ShowDialog ();

                }
            }
        }
    }
}
