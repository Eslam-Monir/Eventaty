using Oracle.DataAccess.Client;
using System;
using System.Data;
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


        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand test = new OracleCommand();
            test.Connection = conn;
            test.CommandText = "SELECT ID FROM Events WHERE NAME = :NAME AND DATES = :DATES";
            test.Parameters.Add("NAME", event_name.Text);
            test.Parameters.Add("DATES", event_date.Text);
            OracleDataReader dr = test.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("the Event Name is already exist in that Date, write another");
                dr.Close();
            }
            else
            {
                dr.Close();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Events (ID, NAME, DATES, TIMES, ATTENDEE_LIMIT, DESCRIPTION, CATEGORIES, LOCATION, STATUS) VALUES (events_seq.nextval, :NAME, :DATES, :TIMES, :ATENDEE_LIMIT, :DESCRIPTION, :CATEGORIES, (SELECT ID FROM PLACE WHERE NAME =:LOCATION AND STATUS != 'CLOSED'), 0)";
                cmd.Parameters.Add("NAME", event_name.Text);
                cmd.Parameters.Add("DATES", event_date.Text);
                cmd.Parameters.Add("TIMES", event_time.Text);
                cmd.Parameters.Add("ATTENDEE_LIMIT", event_attendeelimit.Text);
                cmd.Parameters.Add("DESCRIPTION", event_description.Text);
                cmd.Parameters.Add("CATEGORIES", event_categories.Text);
                cmd.Parameters.Add("LOCATION", event_location.SelectedItem.ToString());

                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.Connection = conn;
                    cmd2.CommandText = "INSERT INTO PENDING_REQUEST  VALUES (PENDING_REQUEST_seq.nextval, 1, (SELECT ID FROM Events WHERE NAME = :NAME AND DATES = :DATES))";
                    cmd2.Parameters.Add("NAME", event_name.Text);
                    cmd2.Parameters.Add("DATES", event_date.Text);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("new event has added");
                }

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome UserForm = new UserHome();
            UserForm.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT NAME FROM Place WHERE STATUS != 'closed'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                event_location.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}
