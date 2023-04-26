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
    public partial class PlaceOwnerHome : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public PlaceOwnerHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "  select * from   events inner  join place on  Events.location = place.id where  place.po_id= "+Login_form.ID;
            Console.WriteLine(cmd.CommandText);
            
            
            /**//*and Place.PO_ID= "+Login_form.ID;*/
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listView1.Items.Add(dr[1].ToString());
                    
            }

        }


        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView1.SelectedItems[0];
            label1.Text = item.SubItems[0].Text  ; 
        }

        private void label1_Click(object sender, EventArgs e)
        {
  
        }
    }
}
