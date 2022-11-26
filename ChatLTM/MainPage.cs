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


        private async void GetChat(int chatId)
        {
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            await streamWriter.WriteLineAsync("GetChat&" + chatId.ToString());
        }
        private async void FriendRequestAccept(object sender, EventArgs e)
        {
            FriendRequestItem friendRequestItem = (FriendRequestItem)sender;
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            string Username = friendRequestItem.Username;
            tabFriends.TabPages[2].Controls.Find("flbRequests", false)[0].Controls.Remove(friendRequestItem);
            await streamWriter.WriteLineAsync("Status&" + Username);
            FriendItem friendItem = new FriendItem(Username, "Online");
            friendItem.GetClicked += FriendClick;
            MyFriends.Add(friendItem);
            foreach (ClientItem clientItem in Clients)
            {
                if (clientItem.Username == Username)
                {
                    Clients.Remove(clientItem);
                    break;
                }
            }
           /* UpdateClients();*/
            await streamWriter.WriteLineAsync("Request Accepted" + "&" + Username);
           /* UpdateFriends();*/
        }
        private async void FriendRequestReject(object sender, EventArgs e)
        {
            FriendRequestItem friendRequestItem = (FriendRequestItem)sender;
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            string Username = friendRequestItem.Username;
            tabFriends.TabPages[2].Controls.Find("flbRequests", false)[0].Controls.Remove(friendRequestItem);
            await streamWriter.WriteLineAsync("Request Rejected" + "&" + Username);
        }
        async void LoadProfile()
        {
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            await streamWriter.WriteLineAsync("GetProfile");
        }
        void GetProfile(string[] Queries)
        {
            int ind = 1;
            lblProfileName.Text = Queries[ind++];
            this.Text = lblProfileName.Text;
            ChatItems.Clear();
            int ChatID = int.Parse(Queries[ind++]);
            while (ChatID != -1)
            {
                string chatName = Queries[ind++];
                bool type = Queries[ind++] == "True";
                string lastMessage = Queries[ind++];
                lastMessage += " : ";
                lastMessage += Queries[ind++];
                string dateLastMessage = Queries[ind++];
                ChatItem chatItem = new ChatItem(ChatID, chatName, lastMessage, dateLastMessage, false, type);
                chatItem.GetClicked += ChatItemClicked;
                ChatItems.Add(chatItem);
                ChatID = int.Parse(Queries[ind++]);
            }
            /*UpdateChats();*/
            MyFriends.Clear();
            string username = Queries[ind++];
            while (username != "-1")
            {
                string Status = Queries[ind++];
                FriendItem friendItem = new FriendItem(username, Status);
                friendItem.GetClicked += FriendClick;
                MyFriends.Add(friendItem);
                username = Queries[ind++];
            }
           /* UpdateFriends();*/
            Clients.Clear();
            username = Queries[ind++];
            while (username != "-1")
            {
                string requestSended = Queries[ind++];
                ClientItem clientItem;
                if (requestSended == "True")
                {
                    clientItem = new ClientItem(username, true);
                }
                else
                {
                    clientItem = new ClientItem(username, false);
                }
                clientItem.SendingRequest += FriendRequestToClient;
                Clients.Add(clientItem);
                username = Queries[ind++];
            }
            /*UpdateClients();*/
            tabFriends.TabPages[2].Controls.Find("flbRequests", false)[0].Controls.Clear();
            username = Queries[ind++];
            while (username != "-1")
            {
                FriendRequestItem friendRequestItem = new FriendRequestItem(username);
                friendRequestItem.GetAccepted += FriendRequestAccept;
                friendRequestItem.GetRejected += FriendRequestReject;
                tabFriends.TabPages[2].Controls.Find("flbRequests", false)[0].Controls.Add(friendRequestItem);
                username = Queries[ind++];
            }
        }
        private async void ChatItemClicked(object sender, EventArgs e)
        {
            ChatItem chatItem = (ChatItem)sender;
            foreach (Control control in this.Controls)
            {
                try
                {
                    Chat chat = (Chat)control;
                    if (chat.ChatID == chatItem.ChatID)
                    {
                        chat.BringToFront();
                        return;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            await streamWriter.WriteLineAsync("GetChat&" + chatItem.ChatID.ToString());
        }
        private async void FriendRequestToClient(object sender, EventArgs e)
        {
            ClientItem clientItem = (ClientItem)sender;
            foreach (FriendRequestItem friendRequestItem in tabFriends.Controls.Find("flbRequests", true)[0].Controls)
            {
                if (friendRequestItem.Username == clientItem.Username)
                {
                    MessageBox.Show("You have friend request from this person !!");
                    return;
                }
            }
            if (clientItem.Send)
            {
                clientItem.Send = false;
            }
            else
            {
                clientItem.Send = true;
            }
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            if (clientItem.Send)
            {
                await streamWriter.WriteLineAsync("Send Request" + "&" + clientItem.Username);
            }
            else
            {
                await streamWriter.WriteLineAsync("Cancel Request" + "&" + clientItem.Username);
            }
            /*UpdateClients();*/
        }
        private async void FriendClick(object sender, EventArgs e)
        {
            FriendItem friendItem = (FriendItem)sender;
            FriendProfile friendProfile = new FriendProfile(friendItem.FriendName);
            friendProfile.Location = panel2.Location;
            friendProfile.Size = panel2.Size;
            friendProfile.GetClosed += FriendProfileClose;
            friendProfile.SendMessage += FriendStartChat;
            this.Controls.Add(friendProfile);
            friendProfile.Show();
            friendProfile.BringToFront();
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            await streamWriter.WriteLineAsync("GetFriendProfile&" + friendItem.FriendName);
        }
        private async void FriendStartChat(object sender, EventArgs e)
        {
            FriendProfile friendProfile = (FriendProfile)sender;
            this.Controls.Remove(friendProfile);
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            await streamWriter.WriteLineAsync("SendMessage&" + friendProfile.Username + "&" + friendProfile.Message);
        }
        private void FriendProfileClose(object sender, EventArgs e)
        {
            FriendProfile friendProfile = (FriendProfile)sender;
            this.Controls.Remove(friendProfile);
        }
        private void ChatClosed(object sender, EventArgs e)
        {
            Chat chat = (Chat)sender;
            this.Controls.Remove(chat);
        }
        private async void ChatSendMessage(object sender, EventArgs e)
        {
            Chat chat = (Chat)sender;
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            await streamWriter.WriteLineAsync("SendMessage&" + chat.ChatID.ToString() + "&" + chat.Message);
        }
        private async void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                NetworkStream networkStream = tcpClient.GetStream();
                StreamWriter streamWriter = new StreamWriter(networkStream);
                streamWriter.AutoFlush = true;
                await streamWriter.WriteLineAsync("Logout");
                StartPage startPage = new StartPage();
                startPage.Show();
                this.Hide();
            }
        }
        private async void btnCreateChat_Click(object sender, EventArgs e)
        {
            string cchatname = tabControl1.Controls.Find("txtChatName", true)[0].Text;
            if (cchatname == "")
            {
                MessageBox.Show("Please Enter Chat Name !!");
                return;
            }
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            string ChatName = tabControl1.Controls.Find("txtChatName", true)[0].Text;
            string Q = "NewChat&" + ChatName;
            bool ok = false;
            foreach (AddChatMember addChatMember in tabControl1.Controls.Find("flbAddChatMembers", true)[0].Controls)
            {
                if (addChatMember.Chosen)
                {
                    Q += "&" + addChatMember.FriendName;
                    ok = true;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Please Choose Chat Members !!");
                return;
            }
            await streamWriter.WriteLineAsync(Q);
            tabControl1.Controls.Find("txtChatName", true)[0].Text = "";
            foreach (AddChatMember addChatMember in tabControl1.Controls.Find("flbAddChatMembers", true)[0].Controls)
            {
                addChatMember.Chosen = false;
            }
        }
        /*private void txtSearchChat_TextChanged(object sender, EventArgs e)
        {
            UpdateChats();
        }

        private void txtSearchFriends_TextChanged(object sender, EventArgs e)
        {
            UpdateFriends();
        }

        private void txtSearchClients_TextChanged(object sender, EventArgs e)
        {
            UpdateClients();
        }*/
        private async void btnMyProfile_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                try
                {
                    MyProfile profile = (MyProfile)control;
                    profile.BringToFront();
                    return;
                }
                catch
                {

                }
            }
            NetworkStream networkStream = tcpClient.GetStream();
            StreamWriter streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;
            await streamWriter.WriteLineAsync("GetMyInformation");
            MyProfile myProfile = new MyProfile();
            myProfile.Location = panel2.Location;
            myProfile.Size = panel2.Size;
            myProfile.GetClosed += MyProfileClosed;
            myProfile.GetSaved += MyProfileSaved;
            this.Controls.Add(myProfile);
            myProfile.Show();
            myProfile.BringToFront();
        }

        private void MyProfileClosed(object sender, EventArgs e)
        {
            MyProfile myProfile = (MyProfile)sender;
            this.Controls.Remove(myProfile);
        }
        private async void MyProfileSaved(object sender, EventArgs e)
        {
            MyProfile myProfile = (MyProfile)sender;
            if (Validation.Valid_UserName(myProfile.Username))
            {
                if (myProfile.Password == myProfile.ConfirmPassword)
                {
                    if (Validation.Valid_password(myProfile.Password))
                    {
                        if (Validation.Valid_Date(myProfile.Birthdate))
                        {
                            NetworkStream networkStream = tcpClient.GetStream();
                            StreamWriter streamWriter = new StreamWriter(networkStream);
                            streamWriter.AutoFlush = true;
                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update your profile ?", "", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                await streamWriter.WriteLineAsync("UpdateMyInformation&" + myProfile.Username + "&" + myProfile.Password + "&" + myProfile.Birthdate.ToString("dd-MM-yyyy") + "&" + myProfile.Gender);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You should be greater than 14 years old !!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password should contains more than 8 characters consists of lower and upper case letters and digits !!");
                    }
                }
                else
                {
                    MessageBox.Show("Password doesn't match !!");
                }
            }
            else
            {
                MessageBox.Show("Username should contains more than 4 characters !!");
            }
        }
    }
}
