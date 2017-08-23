using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rresturant
{
    class BasicClass
    {
        SqlCommand cmd;
        //SqlConnection Con = new SqlConnection("Data Source=MACKPC;Initial Catalog=Restrant;Persist Security Info=True;User ID=sa;Password=123");
        SqlConnection Con = new SqlConnection("Data Source=MACKPC;Initial Catalog=SuperMarket;Persist Security Info=True;User ID=sa;Password=123");
        //Constructor initialize connection object
        //public BasicClass()
        //{
        //    SqlConnection Con = new SqlConnection("Data Source=MACKPC;Initial Catalog=Restrant;Persist Security Info=True;User ID=sa;Password=123");
        //}

        public void OnlyLettersFunction(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        //method to open connection
        public void DBopenConnection()
        {
          if(Con.State!=ConnectionState.Open)
            {
                Con.Open();
            }
        }

        //method to close connection
        public void DBcloseConnection()
        {
            if (Con.State==ConnectionState.Open)
            {
                Con.Close();
            }
        }

        //method to select data from DB
        public DataTable selectdata(string storedProcedure, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedProcedure;
            cmd.Connection = Con;

            if(parameter!=null)
            {
                for(int i=0;i<parameter.Length;i++)
                {
                    cmd.Parameters.Add(parameter[i]);
                }
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        //method to insert, update and delete DATA from DB
        public void ExecuteCommand(string StoredProcedure,SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = StoredProcedure;
            cmd.Connection = Con;
            if(parameter!=null)
            {
                cmd.Parameters.AddRange(parameter);
            }
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}
