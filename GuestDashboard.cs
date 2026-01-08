using System;
using System.Windows.Forms;
using FormFlow.Model.Users;

namespace FormFlow.UI
{
    public partial class GuestDashboard : Form
    {
        private User _guest;

        public GuestDashboard(User user)
        {
            InitializeComponent();
            _guest = user;
            this.Text = "Guest Access - " + _guest.Name;
        }

        private void GuestDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}