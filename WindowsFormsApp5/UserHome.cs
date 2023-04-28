using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class UserHome : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        List<Events> PownerEvents = new List<Events>();
        public UserHome()
        {
            InitializeComponent();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "  select events.* , place.name FROM events INNER JOIN place ON events.location=place.id  ";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Events pEvent = new Events(
               id: Int32.Parse(dr[0].ToString()),
                  name: dr[1].ToString(),
                  date: dr[2].ToString(),
                  time: dr[3].ToString(),
                  attendee_limit: Int32.Parse(dr[4].ToString()),
                  description: dr[5].ToString(),
                  categories: dr[6].ToString(),
                  location: Int32.Parse(dr[10].ToString()),
                  status: Int32.Parse(dr[8].ToString()),
                  PO_id: Int32.Parse(dr[9].ToString()));


                PownerEvents.Add(pEvent);

            }


            foreach (Events evnt in PownerEvents)
            {
                listView1.Items.Add(evnt.name);
            }
        }

        private void create_event_Click(object sender, EventArgs e)
        {

        }

        private void add_comment_Click(object sender, EventArgs e)
        {
            if (comment_txt.Text != "")
            {

                if (listView1.SelectedItems.Count == 0)
                    return;
                ListViewItem item = listView1.SelectedItems[0];
                OracleCommand ay = new OracleCommand();


                ay.Connection = conn;
                ay.CommandText = "insert into Comments values(comments_seq.nextval,:text,:userid,:eventid)";

                ay.Parameters.Add("text", comment_txt.Text);
                ay.Parameters.Add("userid", Login_form.User_ID);
                int selectedIndex = item.Index; ;
                ay.Parameters.Add("eventid", PownerEvents[selectedIndex].id);
                ay.ExecuteNonQuery();
                MessageBox.Show("Added successfully :)");
                comments.Items.Add(comment_txt.Text);
                comment_txt.Text = "";
            }
            else
            {
                MessageBox.Show("please enter a comment first");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            int selectedIndex = item.Index;


            label2.Text = "Name :           " + PownerEvents[selectedIndex].name;
            label7.Text = "Description :  " + PownerEvents[selectedIndex].description;
            label3.Text = "Categories  :  " + PownerEvents[selectedIndex].categories;
            label5.Text = "Location :       " + PownerEvents[selectedIndex].location;


            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "  select comments.*  FROM comments INNER JOIN events ON events.id = comments.event_id and events.id =" + PownerEvents[selectedIndex].id;
            cmd.CommandType = CommandType.Text;
            List<Events> PComments = new List<Events>();

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Events pEvent = new Events(
               id: Int32.Parse(dr[0].ToString()),
                  name: dr[1].ToString(),
                  date: null,
                  time: null,
                  attendee_limit: 0,
                  description: null,
                  categories: null,
                  location: 0,
                  status: 0,
                  PO_id: 0);


                PComments.Add(pEvent);

            }

            comments.Items.Clear();
            foreach (Events evnt in PComments)
            {
                comments.Items.Add(evnt.name);
            }
            comments.View = View.List;
        }

        private void enroll_event_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            int selectedIndex = item.Index;
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "  select *  FROM USER_ENROLLED_EVENTS where userid =  " + Login_form.User_ID + "AND eventid = " + PownerEvents[selectedIndex].id;
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr = cmd2.ExecuteReader();
            if (!dr.Read())
            {

                OracleCommand command = new OracleCommand("ADD_USER_ENROLLED_EVENTS", conn);
                command.CommandType = CommandType.StoredProcedure;



                command.Parameters.Add("u_id", OracleDbType.Int32).Value = Login_form.User_ID;
                command.Parameters.Add("event_ID", OracleDbType.Int32).Value = PownerEvents[selectedIndex].id;


                int r = command.ExecuteNonQuery();
                if (r != 0)
                {
                    MessageBox.Show("Enrolled in the Event");
                }
            }
            else
            {
                MessageBox.Show("Already enrolled in that Event");
            }
        }

        private void manage_categories_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_Category manage_cat = new Manage_Category();
            manage_cat.Show();
        }
    }
}
