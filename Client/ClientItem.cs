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
    public partial class ClientItem : UserControl
    {
        private bool send;
        private string username;
        public delegate void OnSendingRequest(object sender, EventArgs e);
        private OnSendingRequest sendingRequest;
        public ClientItem(string Username, bool Send)
        {
            InitializeComponent();
            this.Username = Username;
            this.Send = Send;

        }
        public event OnSendingRequest SendingRequest
        {
            add { sendingRequest += value; }
            remove { sendingRequest -= value; }
        }
        public bool Send
        {
            set
            {
                send = value;
                if (value)
                {
                   /* this.btnSendRequest.BackgroundImage = Properties.Resources.RequestSended;*/
                    this.btnSendRequest = this.btnSendRequest;
                }
                else
                {
                    /*this.btnSendRequest.BackgroundImage = Properties.Resources.SendRequest;
                    this.btnSendRequest.BackgroundImage = Properties.Resources.SendRequest;*/
                }
            }
            get { return send; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; lblClientName.Text = value; }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (sendingRequest != null)
            {
                sendingRequest.Invoke(this, e);
            }
        }
    }
}
