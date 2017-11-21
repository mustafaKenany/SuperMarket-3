using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class SaleReportForm : Form
    {
        public SaleReportForm()
        {
            InitializeComponent ();
            dataGridViewSaleGrid.Columns["Column8"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void Exit_Click(object sender , EventArgs e)
        {
            this.Close ();
        }

        private void buttonShowSaleInvoices_Click(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ( "@InvoiceType" , SqlDbType.NChar , 250 );
            param[0].Value = "شراء";
            dt = usedClass.selectdata ( "SelectAll_Invoices_usingType" , param );
            dataGridViewSaleGrid.DataSource = dt;
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
    }
}
