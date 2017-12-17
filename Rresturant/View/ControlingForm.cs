using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class ControlingForm : Form
    {
        public ControlingForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CasherForm_Click(object sender, EventArgs e)
        {
            //invoiceForm form = new invoiceForm();
            //form.Show();
            //Invoice_Form form = new Invoice_Form();
            //form.Show();
            var form = new View.CacherForm ();
            form.ShowDialog ();

        }

        private void btn_SettingForm_Click(object sender, EventArgs e)
        {
            ////SettingForm form = new SettingForm();
            ////form.Show();
            //stteingscs form = new stteingscs();
            //form.ShowDialog();
            var form = new View.SettingsForm ();
            form.ShowDialog ();
        }

        private void btn_PurshaceForm_Click(object sender, EventArgs e)
        {
            var form = new View.PurshaceForm ();
            form.ShowDialog ();
            //SalesForm form = new SalesForm();
            //form.ShowDialog();
        }

        private void btn_AccountingForm_Click(object sender, EventArgs e)
        {
            FinicialForm form = new FinicialForm();
            form.ShowDialog();
        }

        private void button_for_prices_Click(object sender, EventArgs e)
        {
            prices_form form = new prices_form();
            form.ShowDialog();
        }

        private void button_UnRunnigBill_Click(object sender, EventArgs e)
        {
            UnRunBills form = new UnRunBills();
            form.ShowDialog();
        }

        private void btn_ReportingForm_Click(object sender, EventArgs e)
        {
            //ReportingForm form = new ReportingForm ();
            //form.ShowDialog ();
            var form = new ReportingMiniForm ();
            form.ShowDialog ();
        }
    }
}
