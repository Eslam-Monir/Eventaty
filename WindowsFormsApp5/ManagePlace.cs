using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleDataAdapter adapter;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            string command = " select ID, Name, Location, Capacity, AVAILABLE_TIME ,STATUS from PLACE";
            adapter = new OracleDataAdapter(command,ordb);
            adapter.Fill(ds = new DataSet());
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);

        }
    }
}
