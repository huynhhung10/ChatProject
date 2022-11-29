using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client { 
    public partial class FriendProfile : UserControl
    {
        private string username;
        private string gender;
        public delegate void OnClose(object sender, EventArgs e);
        private OnClose getClosed;
        public delegate void OnSendMessage(object sender, EventArgs e);
        private OnSendMessage sendMessage;
        public FriendProfile(string Username)
        {
            InitializeComponent();
            this.Username = Username;
        }
        public string Username
        {
            set { username = value; lblUsername.Text = value; }
            get { return username; }
        }
       
        public string Gender
        {
            set { gender = value; lblGender.Text = value; }
            get { return gender; }
        }
        public string Message
        {
            get
            {
                string q = "";
                foreach (string str in textMessage.Lines)
                {
                    q += str + Environment.NewLine;
                }
                return q;
            }
        }
        public event OnClose GetClosed
        {
            add { getClosed += value; }
            remove { getClosed -= value; }
        }
        public event OnSendMessage SendMessage
        {
            add { sendMessage += value; }
            remove { sendMessage -= value; }
        }
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (Message.Length > 0)
            {
                if (sendMessage != null)
                {
                    sendMessage.Invoke(this, e);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (getClosed != null)
            {
                getClosed.Invoke(this, e);
            }
        }
    }
}
