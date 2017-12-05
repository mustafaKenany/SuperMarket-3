﻿using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class itemsReportForm : Form
    {
        public itemsReportForm()
        {
            InitializeComponent ();
        }

        private void Exit_Click(object sender , EventArgs e)
        {
            this.Close ();
        }

        private void button_showAllitems_Click(object sender , EventArgs e)
        {
            var usedClass = new BasicClass ();
            var dt = new DataTable ();
            dt = usedClass.selectdata ( "Report_SelectAllitemsWithPrices" , null );
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
                dt = usedClass.selectdata ( "Report_SelectAllitemswithPrices_UsingFilter" , param );
                dataGridView_displayitems.DataSource = dt;
            }
            else
            {
                dt = usedClass.selectdata ( "Report_SelectAllitemsWithPrices" , null );
                dataGridView_displayitems.DataSource = dt;
            }
        }

        private void dataGridView_displayitems_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {
            string itemName = dataGridView_displayitems.Rows[e.RowIndex].Cells["ColumnItemName"].Value.ToString ();

            var dt = new DataTable ();
            var UsedClass = new BasicClass ();
            var crp = new ItemsReport ();
            var form = new PrintForm ();
            if ( e.ColumnIndex == 0 )
            {
                if ( e.RowIndex >= 0 )
                {
                    SqlParameter[] param = new SqlParameter[3];
                    param[0] = new SqlParameter ( "@ItemName" , SqlDbType.NVarChar , 250 );
                    param[0].Value = itemName;
                    param[1] = new SqlParameter ( "@InvoiceType" , SqlDbType.NVarChar , 250 );
                    param[1].Value = "شراء";
                    param[2] = new SqlParameter ( "@InvoiceSatus" , SqlDbType.NVarChar , 250 );
                    param[2].Value = "Run";
                    dt = UsedClass.selectdata ( "Report_Select_items_using_itemName_and_InvoiceType" , param );
                    TextObject invoiceType = (TextObject) crp.ReportDefinition.Sections["Section1"].ReportObjects["Text11"];
                    invoiceType.Text = "قائمة مشتريات";
                    crp.SetDataSource ( dt );
                    form.crystalReportViewer1.ReportSource = crp;
                    form.ShowDialog ();
                }
            }
            else if ( e.ColumnIndex == 1 )
            {
                if ( e.RowIndex >= 0 )
                {
                    SqlParameter[] param = new SqlParameter[3];
                    param[0] = new SqlParameter ( "@ItemName" , SqlDbType.NVarChar , 250 );
                    param[0].Value = itemName;
                    param[1] = new SqlParameter ( "@InvoiceType" , SqlDbType.NVarChar , 250 );
                    param[1].Value = "بيع";
                    param[2] = new SqlParameter ( "@InvoiceSatus" , SqlDbType.NVarChar , 250 );
                    param[2].Value = "Run";
                    dt = UsedClass.selectdata ( "Report_Select_items_using_itemName_and_InvoiceType" , param );
                    crp.SetDataSource ( dt );
                    string y = string.Concat ( crp.DataDefinition.FormulaFields["Quantity"].Text , " *-1" );
                    crp.DataDefinition.FormulaFields["Quantity"].Text = y;
                    TextObject invoiceType = (TextObject) crp.ReportDefinition.Sections["Section1"].ReportObjects["Text11"];
                    invoiceType.Text = "قائمة مبيعات";
                    form.crystalReportViewer1.ReportSource = crp;
                    form.ShowDialog ();
                }
            }
            else if ( e.ColumnIndex == 2 )
            {
                if ( e.RowIndex >= 0 )
                {
                    SqlParameter[] param = new SqlParameter[3];
                    param[0] = new SqlParameter ( "@ItemName" , SqlDbType.NVarChar , 250 );
                    param[0].Value = itemName;
                    param[1] = new SqlParameter ( "@InvoiceType" , SqlDbType.NVarChar , 250 );
                    param[1].Value = "بيع";
                    param[2] = new SqlParameter ( "@InvoiceSatus" , SqlDbType.NVarChar , 250 );
                    param[2].Value = "Save";
                    dt = UsedClass.selectdata ( "Report_Select_items_using_itemName_and_InvoiceType" , param );
                    string y = string.Concat ( crp.DataDefinition.FormulaFields["Quantity"].Text , " *-1" );
                    crp.DataDefinition.FormulaFields["Quantity"].Text = y;
                    TextObject invoiceType = (TextObject) crp.ReportDefinition.Sections["Section1"].ReportObjects["Text11"];
                    invoiceType.Text = "قائمة محجوزة";
                    crp.SetDataSource ( dt );
                    form.crystalReportViewer1.ReportSource = crp;
                    form.ShowDialog ();
                }
            }
        }



        private void buttonPrintitemsGrid_Click(object sender , EventArgs e)
        {
            var crp = new itemsGridReport ();
            var form = new PrintForm ();
            crp.SetDataSource ( dataGridView_displayitems.DataSource );
            form.crystalReportViewer1.ReportSource = crp;
            form.ShowDialog ();

        }
    }
}
