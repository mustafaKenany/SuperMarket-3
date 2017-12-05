﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

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

        private void dataGridViewBuyGridInvoice_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {
            var crp = new SaleInvoiceReport ();
            var dt = new DataTable ();
            var usedClass = new BasicClass ();
            var form = new PrintForm ();
            if ( e.ColumnIndex==0 )
            {
                if ( e.RowIndex>=0 )
                {
                    int InvoiceNo = int.Parse ( dataGridViewBuyGridInvoice.Rows[e.RowIndex].Cells["CoulmnBuyInvoiceNo"].Value.ToString () );
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter ( "@InvoiceNo" , SqlDbType.Int );
                    param[0].Value = InvoiceNo;
                    dt = usedClass.selectdata ( "Report_Select_SaleInvoice_usingInvoiceNo" , param );
                    string y = string.Concat ( crp.DataDefinition.FormulaFields["ItemQuantity"].Text , "*-1" );
                    crp.DataDefinition.FormulaFields["ItemQuantity"].Text = y;
                    TextObject invoiceType = (TextObject) crp.ReportDefinition.Sections["Section1"].ReportObjects["Text7"];
                    invoiceType.Text = dataGridViewBuyGridInvoice.Rows[e.RowIndex].Cells["CoulmnBuyInvoiceType"].Value.ToString ();
                    FormulaFieldDefinition x = crp.DataDefinition.FormulaFields["InvoiceTotalAmount"];
                    crp.SetDataSource ( dt );
                    form.crystalReportViewer1.ReportSource = crp;
                    form.ShowDialog ();
                   
                }
            }
        }
    }
}
