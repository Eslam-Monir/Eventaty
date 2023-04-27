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
            OracleCommand cmd2 = new OracleCommand();
            cmd.Connection = conn;
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
                  location: dr[7].ToString(),
                  status: Int32.Parse(dr[8].ToString())

                    );


                PownerEvents.Add(pEvent);


                cmd2.CommandText = "  select * from events inner join place on  Events.location = place.id where  place.po_id= " + Login_form.ID;

            }
            /*      for (int i = 0;i<PownerEvents.Count;i++)
                  {
                      listView1.Items.Add(PoEvents.Values.);
                  }*/
            foreach (Events evnt in PownerEvents)
            {
                listView1.Items.Add(evnt.name);
            }

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


            label1.Text = PownerEvents[selectedIndex].name;
            label6.Text = PownerEvents[selectedIndex].description;
            label4.Text = PownerEvents[selectedIndex].categories;
            label8.Text = PownerEvents[selectedIndex].location;
        }
    }
}
