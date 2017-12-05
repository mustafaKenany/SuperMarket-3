using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;


namespace Rresturant
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent ();
        }

        private void Exit_Click(object sender , EventArgs e)
        {
            this.Close ();
        }

        private void button_showAllCustomers_Click(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            dt = usedClass.selectdata ( "Select_Users" , null );
            dataGridView_displayCustomers.DataSource = dt;
        }

        private void dataGridView_displayCustomers_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {
            var dt = new DataTable ();
            var UsedClass = new BasicClass ();
            var crp = new CustomerReports_Sale_buy ();
            var form = new PrintForm ();
            TextObject invoiceType = (TextObject) crp.ReportDefinition.Sections["Section1"].ReportObjects["Text1"];
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter ( "@CustomerName" , SqlDbType.NVarChar , 250 );
            param[1] = new SqlParameter ( "@InvoiceType" , SqlDbType.NVarChar , 250 );
            param[2] = new SqlParameter ( "@InvoiceStatus" , SqlDbType.NVarChar , 250 );
            if ( e.RowIndex >= 0 )
            {
                param[0].Value = dataGridView_displayCustomers.Rows[e.RowIndex].Cells["ColumnCustomerName"].Value.ToString ();

                switch ( e.ColumnIndex )
                {
                    case 0:
                        invoiceType.Text = "فواتير الشراء";
                        param[1].Value = "شراء";
                        param[2].Value = "Run";
                        dt = UsedClass.selectdata ( "Reports_Customers_Select_invoicesDepandonInvoiceType_and_invoiceStatus" , param );
                        crp.SetDataSource ( dt );
                        form.crystalReportViewer1.ReportSource = crp;
                        form.ShowDialog ();
                        
                        break;
                    case 1:
                        invoiceType.Text = "فواتير البيع";
                        param[1].Value = "بيع";
                        param[2].Value = "Run";
                        dt = UsedClass.selectdata ( "Reports_Customers_Select_invoicesDepandonInvoiceType_and_invoiceStatus" , param );
                        crp.SetDataSource ( dt );
                        form.crystalReportViewer1.ReportSource = crp;
                        form.ShowDialog ();
                        break;
                    case 2:
                        invoiceType.Text = "فواتير المحجوزة";
                        param[1].Value = "بيع";
                        param[2].Value = "Save";
                        dt = UsedClass.selectdata ( "Reports_Customers_Select_invoicesDepandonInvoiceType_and_invoiceStatus" , param );
                        crp.SetDataSource ( dt );
                        form.crystalReportViewer1.ReportSource = crp;
                        form.ShowDialog ();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
