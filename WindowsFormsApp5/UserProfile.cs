using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class UserProfile : Form
    {
        string place;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public UserProfile()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {



            string ordb = "Data source=orcl;User Id=scott;Password=tiger;";

            OracleCommand cmddd = new OracleCommand();
            cmddd.Connection = conn;
            
            cmddd.CommandText = "USERPROF";
            cmddd.CommandType = CommandType.StoredProcedure;

            cmddd.Parameters.Add("u_id", OracleDbType.Decimal).Value = Convert.ToDecimal(Login_form.ID);
            cmddd.Parameters.Add("name", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            cmddd.Parameters.Add("email", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            cmddd.ExecuteNonQuery();
            label5.Text = cmddd.Parameters["name"].Value.ToString();
            label4.Text = cmddd.Parameters["email"].Value.ToString();
            conn.Close();
        }
            }
        
}
