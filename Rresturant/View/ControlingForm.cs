using System;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class ControlingForm : Form
    {
        public ControlingForm()
        {
            InitializeComponent ();
        }

        private void Exit_Click(object sender , EventArgs e)
        {
            Application.Exit ();
        }

        private void btn_CasherForm_Click(object sender , EventArgs e)
        {

            var form = new View.CacherForm ();
            form.ShowDialog ();

        }

        private void btn_SettingForm_Click(object sender , EventArgs e)
        {

            var form = new View.SettingsForm ();
            form.ShowDialog ();
        }

        private void btn_PurshaceForm_Click(object sender , EventArgs e)
        {
            var form = new View.PurshaceForm ();
            form.ShowDialog ();

        }



        private void button_for_prices_Click(object sender , EventArgs e)
        {
            prices_form form = new prices_form ();
            form.ShowDialog ();
        }

        

        private void btn_ReportingForm_Click(object sender , EventArgs e)
        {

            var form = new ReportingMiniForm ();
            form.ShowDialog ();
        }

        private void buttonSavePurshaceInvoice_Click(object sender , EventArgs e)
        {
            var form = new View.SavedInvoicesForm ();
            form.LoadSaveInvoices ( "شراء" );
            form.ShowDialog ();
        }

        private void buttonSaveSaleInvoice_Click(object sender , EventArgs e)
        {
            var form = new View.SavedInvoicesForm ();
            form.LoadSaveInvoices ( "بيع" );
            form.ShowDialog ();
        }
    }
}
