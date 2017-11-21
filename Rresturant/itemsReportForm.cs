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
    }
}
