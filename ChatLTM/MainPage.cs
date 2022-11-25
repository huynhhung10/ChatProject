using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatLTM
{
    public partial class MainPage : Form
    {
        TcpClient tcpClient;
        List<ChatItem> ChatItems;
        List<FriendItem> MyFriends;
        List<ClientItem> Clients;
        public MainPage(TcpClient tcpClient)
        {
            InitializeComponent();
            this.tcpClient = tcpClient;
            ChatItems = new List<ChatItem>();
            MyFriends = new List<FriendItem>();
            Clients = new List<ClientItem>();
          /*  LoadProfile();
            ReadNotifications();*/

        }


        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProfileName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flpChats_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
