using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent ();
        }

        private void labelExit_Click(object sender , EventArgs e)
        {
            Application.Exit ();
        }

        private void buttonExit_Click(object sender , EventArgs e)
        {
            Application.Exit ();
        }

        private void buttonEnter_Click(object sender , EventArgs e)
        {
            var dt = new DataTable ();
            var UsedClass = new BasicClass ();
            var form = new ControlingForm ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ( "@UserName" , SqlDbType.NVarChar , 250 );
            param[1] = new SqlParameter ( "@Passwrod" , SqlDbType.NVarChar , 50 );
            param[0].Value = textBoxUserName.Text;
            param[1].Value = textBoxPassword.Text;
            dt = UsedClass.selectdata ( "Login_Select_Users" , param );
            if ( dt.Rows.Count > 0 )
            {
                BasicClass.UserName = dt.Rows[0]["UserName"].ToString ();
                BasicClass.Password = dt.Rows[0]["Password"].ToString ();
                if ( dt.Rows[0]["ReportPermission"].ToString () == "True" )
                {
                    form.btn_PurshaceForm.Enabled = true;
                }
               
                if ( dt.Rows[0]["CasherPermission"].ToString () == "True" )
                {
                    form.btn_CasherForm.Enabled = true;
                }
               
                if ( dt.Rows[0]["StorePermission"].ToString () == "True" )
                {
                    form.btn_PurshaceForm.Enabled = true;
                    form.btn_ReportingForm.Enabled = true;
                }
                
                if ( dt.Rows[0]["SuperUser"].ToString () == "True" )
                {
                    form.btn_CasherForm.Enabled = true;
                    form.btn_PurshaceForm.Enabled = true;
                    form.btn_ReportingForm.Enabled = true;
                    form.btn_SettingForm.Enabled = true;
                }
                if ( dt.Rows[0]["ReportPermission"].ToString () == "False" && dt.Rows[0]["SuperUser"].ToString () == "False" && dt.Rows[0]["StorePermission"].ToString () == "False" && dt.Rows[0]["CasherPermission"].ToString () == "False" )
                {
                    MessageBox.Show ( "هذا المستخدم تم حضره من قبل مدير النظام" , "MESSAGE" );
                    Application.Exit ();
                }
                BasicClass.UserName = textBoxUserName.Text.Trim ();
                BasicClass.Password = textBoxPassword.Text.Trim ();
                form.ShowDialog ();
                this.Close ();
            }
            else
            {
                MessageBox.Show ( "خطا في ادخال اسم المعلومات" );
            }
        }
    }
}
