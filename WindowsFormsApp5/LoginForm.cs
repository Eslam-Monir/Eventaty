using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;





namespace WindowsFormsApp5
{
    public partial class Login_form : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public static int ID;
        public static int User_ID;

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

        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();


            cmd.Connection = conn;
            if (!IsPO.Checked)
            {
                cmd.CommandText = "select id from Users where Name = :name and Password= :password";
            }
            else
            {
                cmd.CommandText = "select id from placeowner where Name = :name and Password= :password";
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
                    User_ID = Int32.Parse(dr[0].ToString());
                    this.Hide();
                    UserHome HomeForm = new UserHome();
                    HomeForm.Show();


                }
                else
                {
                    ID = Int32.Parse(dr[0].ToString());
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
