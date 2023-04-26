using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void create_event_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 CreateEvent = new Form1();
            CreateEvent.Show();
        }
    }
}
