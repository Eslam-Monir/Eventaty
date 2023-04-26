using Oracle.DataAccess.Client;
using System;
using System.Windows.Forms;


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Events (ID, NAME, DATES, TIMES, ATTENDEE_LIMIT, DESCRIPTION, CATEGORIES, LOCATION) VALUES (3, :NAME, :DATES, :TIMES, :ATTENDEE_LIMIT, :DESCRIPTION, :CATEGORIES, :LOCATION)";
            cmd.Parameters.Add("NAME", event_name.Text);
            cmd.Parameters.Add("DATES", event_date.Text);
            cmd.Parameters.Add("TIMES", event_time.Text);
            cmd.Parameters.Add("ATTENDEE_LIMIT", event_attendeelimit.Text);
            cmd.Parameters.Add("DESCRIPTION", event_description.Text);
            cmd.Parameters.Add("CATEGORIES", event_categories.Text);
            cmd.Parameters.Add("LOCATION", event_location.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("new event has added");
            }
        }
    }
}
