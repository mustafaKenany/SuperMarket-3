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
    public partial class BuyReportForm : Form
    {
        public BuyReportForm()
        {
            InitializeComponent ();
        }

        private void Exit_Click(object sender , EventArgs e)
        {
            this.Close ();
        }

        private void buttonShowBuyInvoices_Click(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ( "@InvoiceType" , SqlDbType.NChar , 250 );
            param[0].Value = "بيع";
            dt = usedClass.selectdata ( "SelectAll_Invoices_usingType" , param );
            dataGridViewBuyGridInvoice.DataSource = dt;
        }

        private void textBoxFilterBuyGrid_TextChanged(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            if ( textBoxFilterBuyGrid.Text != "" )
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter ( "@InvoiceType" , SqlDbType.NChar , 250 );
                param[0].Value = "بيع";
                param[1] = new SqlParameter ( "@Filter" , SqlDbType.NVarChar , 250 );
                param[1].Value = textBoxFilterBuyGrid.Text;
                dt = usedClass.selectdata ( "SelectAll_Invoices_usingTypeAndFilter" , param );
                dataGridViewBuyGridInvoice.DataSource = dt;
            }
            else
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter ( "@InvoiceType" , SqlDbType.NChar , 250 );
                param[0].Value = "بيع";
                dt = usedClass.selectdata ( "SelectAll_Invoices_usingType" , param );
                dataGridViewBuyGridInvoice.DataSource = dt;
            }
        }
    }
}
