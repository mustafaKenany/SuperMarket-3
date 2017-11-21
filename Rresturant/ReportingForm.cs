using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class ReportingForm : Form
    {

        public ReportingForm()
        {
            InitializeComponent ();
            dataGridViewSaleGrid.Columns["ColumnInvoiceDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridViewBuyGridInvoice.Columns["CoulmnBuyInvoiceDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void Exit_Click(object sender , EventArgs e)
        {
            this.Close ();
        }

        private void button_showAllitems_Click(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            dt = usedClass.selectdata ( "SelectAllitemsWithPrices" , null );
            dataGridView_displayitems.DataSource = dt;
        }

        private void textBoxFilteritemsGrid_TextChanged(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            if ( textBoxFilteritemsGrid.Text != "" )
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter ( "@Filter" , SqlDbType.NVarChar , 250 );
                param[0].Value = textBoxFilteritemsGrid.Text;
                dt = usedClass.selectdata ( "SelectAllitemswithPrices_UsingFilter" , param );
                dataGridView_displayitems.DataSource = dt;
            }
            else
            {
                dt = usedClass.selectdata ( "SelectAllitemsWithPrices" , null );
                dataGridView_displayitems.DataSource = dt;
            }
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
            if ( textBoxFilterBuyGrid.Text!="" )
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
