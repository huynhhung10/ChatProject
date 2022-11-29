using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FriendRequestItem : UserControl
    {
        private string username;
        public delegate void OnRequestAccept(object sender, EventArgs e);
        private OnRequestAccept getAccepted;
        public delegate void OnRequestReject(object sender, EventArgs e);
        private OnRequestReject getRegected;
        public FriendRequestItem(string Username)
        {
            InitializeComponent();
            this.Username = Username;
        }
        public event OnRequestAccept GetAccepted
        {
            add { getAccepted += value; }
            remove { getAccepted -= value; }
        }
        public event OnRequestReject GetRejected
        {
            add { getRegected += value; }
            remove { getRegected -= value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; lblClientName.Text = value; }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (getAccepted != null)
            {
                getAccepted.Invoke(this, e);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (getRegected != null)
            {
                getRegected.Invoke(this, e);
            }
        }
    }
}
