using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp5
{

    public partial class Manage_Category : Form
    {

        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Manage_Category()
        {
            InitializeComponent();

        }
        private void Manage_Category_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Name from Category";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            string query = "SELECT name " +
                       "FROM category " +
                       "WHERE id IN (SELECT cat_id FROM favorite_category where user_id=:userid)";


            using (OracleConnection connection = new OracleConnection(ordb))
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter("userid", Login_form.User_ID));
                connection.Open();
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string categoryName = reader.GetString(0);
                    listBox2.Items.Add(reader[0]);
                }

                reader.Close();
                while (dr.Read())
                {
                    string itemName = dr.GetString(0);
                    if (!listBox2.Items.Contains(itemName))
                    {
                        listBox1.Items.Add(itemName);
                    }
                }
                dr.Close();




            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Add_Click(object sender, EventArgs e)
        {
            List<object> itemsToAdd = new List<object>();
            foreach (var item in listBox1.SelectedItems)
            {

                itemsToAdd.Add(item);

            }
            foreach (var item in itemsToAdd)
            {
                listBox2.Items.Add(item);
                OracleCommand command = new OracleCommand("INSERT INTO Favorite_Category (cat_id,user_id) VALUES ((select id from Category where name =:name),:userid)", conn);
                command.Parameters.Add(new OracleParameter("name", item));
                command.Parameters.Add(new OracleParameter("userid", Login_form.User_ID));
                listBox1.Items.Remove(item);
                command.ExecuteNonQuery();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            List<object> itemsToAdd = new List<object>();
            foreach (var item in listBox2.SelectedItems)
            {
                itemsToAdd.Add(item);
            }
            foreach (var item in itemsToAdd)
            {

                listBox2.Items.Remove(item);
                OracleCommand command = new OracleCommand("DELETE FROM Favorite_Category WHERE Cat_id = (select id from Category where name =:name) AND User_Id = :userid", conn);
                command.Parameters.Add(new OracleParameter("name", item));
                command.Parameters.Add(new OracleParameter("userid", Login_form.User_ID));
                listBox1.Items.Add(item);
                command.ExecuteNonQuery();

            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome userHome = new UserHome();
            userHome.Show();
        }
    }
}

