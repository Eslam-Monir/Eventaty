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

namespace WindowsFormsApp5
{
    public partial class eventRequests : Form
    {
        String place; 
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        Dictionary<int, string> PoEvents = new Dictionary<int, string>();
        List<Events> PownerEvents = new List<Events>();
        public eventRequests()
        {
            InitializeComponent();
        }
        private void eventRequests_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            
            cmd.Connection = conn;
            OracleCommand c = new OracleCommand();

            c.Connection = conn;
            
            cmd.CommandText = "  select events.* from events inner join pending_request on  Events.id = pending_request.event_id where  events.po_id= " + Login_form.ID;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                /*listView1.Items.Add(dr[1].ToString());*/
                /*  PoEvents.Add(Int32.Parse(dr[0].ToString()), dr[1].ToString());*/

                Events pEvent = new Events(
                  id: Int32.Parse(dr[0].ToString()),
                  name: dr[1].ToString(),
                  date: dr[2].ToString(),
                  time: dr[3].ToString(),
                  attendee_limit: Int32.Parse(dr[4].ToString()),
                  description: dr[5].ToString(),
                  categories: dr[6].ToString(),
                  location: Int32.Parse(dr[7].ToString()),
                  status: Int32.Parse(dr[8].ToString()),
                  PO_id: Int32.Parse(dr[9].ToString())

                    );
                PownerEvents.Add(pEvent);
     
            }
            /*      for (int i = 0;i<PownerEvents.Count;i++)
                  {
                      listView1.Items.Add(PoEvents.Values.);
                  }*/
            foreach (Events evnt in PownerEvents)
            {
                listView1.Items.Add(evnt.name);
            }
            dr.Close();
           

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            int selectedIndex = item.Index;

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select Name from place where id =  " + PownerEvents[selectedIndex].location;
            OracleDataReader r = c.ExecuteReader();
            if (r.Read())
            {
                place = r[0].ToString();
            }
            r.Close();


            label2.Text = "Name :           " + PownerEvents[selectedIndex].name;
            label7.Text = "Description :  " + PownerEvents[selectedIndex].description;
            label3.Text = "Categories  :  " + PownerEvents[selectedIndex].categories;
            label5.Text = "Location :     " + place;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            int selectedIndex = item.Index;
            int Event_id = PownerEvents[selectedIndex].id;
            int place_id = PownerEvents[selectedIndex].location;
            OracleCommand cmd2 = new OracleCommand();

            cmd2.Connection = conn;
            cmd2.CommandText = " UPDATE events  SET STATUS = 1 WHERE ID = " + Event_id;
            int r = cmd2.ExecuteNonQuery();
            if (r != -1)
            {
                cmd2.CommandText = " UPDATE Place  SET STATUS = 'closed' WHERE ID =  " + place_id;
                
                cmd2.ExecuteNonQuery();
                cmd2.CommandText = "DELETE FROM PENDING_REQUEST WHERE EVENT_ID = " + Event_id;
                cmd2.ExecuteNonQuery();
               /* cmd2.CommandText = "  select events.* , place.name FROM events INNER JOIN place ON events.location=place.id  ";*/
                MessageBox.Show("done");
                eventRequests eventRequests = new eventRequests();
                this.Hide();
                eventRequests.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            int selectedIndex = item.Index;
            int Event_id = PownerEvents[selectedIndex].id;
            int place_id = PownerEvents[selectedIndex].location;
            OracleCommand c = new OracleCommand();

            c.Connection = conn;
            c.CommandText = " DELETE FROM events WHERE ID = " + Event_id;
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                c.CommandText = "DELETE FROM PENDING_REQUEST WHERE EVENT_ID = " + Event_id;
                c.ExecuteNonQuery();
                MessageBox.Show("done");
                eventRequests eventRequests = new eventRequests();
                this.Hide();
                eventRequests.Show();
            }
        }
    }
}
