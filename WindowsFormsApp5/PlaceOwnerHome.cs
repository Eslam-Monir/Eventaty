using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class PlaceOwnerHome : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public PlaceOwnerHome()
        {
            InitializeComponent();
        }
       /* KeyValuePair<int, string> PoEvents = new KeyValuePair<int, string>();*/
        Dictionary<int, string> PoEvents = new Dictionary<int, string>();
       List<Events> PownerEvents= new List<Events>();

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "  select * from events inner join place on  Events.location = place.id where  place.po_id= "+Login_form.ID;
           
    
              

            /**//*and Place.PO_ID= "+Login_form.ID;*/
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                /*listView1.Items.Add(dr[1].ToString());*/
                /*  PoEvents.Add(Int32.Parse(dr[0].ToString()), dr[1].ToString());*/

                Events pEvent = new Events(
               id:Int32.Parse(dr[0].ToString()),
                  name:dr[1].ToString(),
                  date:dr[2].ToString(),
                  time:dr[3].ToString(),
                  attendee_limit: Int32.Parse(dr[4].ToString()) ,
                  description: dr[5].ToString(), 
                  categories: dr[6].ToString(),
                  location: dr[7].ToString(),
                  status: Int32.Parse(dr[8].ToString())

                    );

                
                PownerEvents.Add( pEvent );

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


        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
          int selectedIndex=  item.Index;

            
            label1.Text = PownerEvents[selectedIndex].name;
            label8.Text = PownerEvents[selectedIndex].description;
            label4.Text = PownerEvents[selectedIndex].categories;
            label6.Text = PownerEvents[selectedIndex].location;

        }

        private void label1_Click(object sender, EventArgs e)
        {
  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // onClick go to [Manage Place form]
        }
    }
}
