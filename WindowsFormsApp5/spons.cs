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
    public partial class spons : Form
    {
        string place;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public spons()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "gtsp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("s_name", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dataReader = cmd.ExecuteReader();
            while(dataReader.Read()) { 
                listBox1.Text = dataReader.GetString(0);
            
            
            }
        }
    }
}
