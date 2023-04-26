using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;





namespace WindowsFormsApp5
{
    public partial class Login_form : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public Login_form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
         
        {   conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();


            cmd.Connection = conn;
            if (!IsPO.Checked) {
                cmd.CommandText = "select * from Users where Name = :name and Password= :password";
            }
            else
            {
                cmd.CommandText = "select * from placeowner where Name = :name and Password= :password";
            }
            cmd.Parameters.Add("name", userName.Text);
            cmd.Parameters.Add("password", Password.Text);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Verify.Text = "Login Successfull ";
                if (!IsPO.Checked)
                {
                    this.Hide();
                    UserHome HomeForm = new UserHome();
                    HomeForm.Show();
                  
                }
                else
                {
                    this.Hide();
                    PlaceOwnerHome HomeForm = new PlaceOwnerHome();
                    HomeForm.Show();
                }
            }
            else { Verify.Text = "Login Unsuccessfull "; }
            dr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
