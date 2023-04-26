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
            Create_Event CreateEvent = new Create_Event();
            CreateEvent.Show();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }
    }
}
