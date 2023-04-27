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

    public partial class Comment : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        /*public string Data1 { get; set; }
        public string Data2 { get; set; }*/
        public Comment()
        {
            
            InitializeComponent();
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
          
        }

    

        private void Sub_Comment_Click(object sender, EventArgs e)
        {
            /*  Guid id = Guid.NewGuid();

             int ID = id.GetHashCode();
             if(ID <0)
             {
                 ID = -ID;
             }*/

            OracleCommand ay = new OracleCommand();


            ay.Connection = conn;
            ay.CommandText = "insert into Comments values(comment_seq.nextval,:text,:userid,:eventid)";
            /*ay.Parameters.Add("id", comment_seq.nextval);*/

            ay.Parameters.Add("text", texB.Text);
           /* ay.Parameters.Add("name", Data1);
            ay.Parameters.Add("password", Data2);*/

            ay.Parameters.Add("userid", 1);
            ay.Parameters.Add("eventid", 1);
            ay.ExecuteNonQuery();

            MessageBox.Show("Added successfully :)");
        }
    }
}
