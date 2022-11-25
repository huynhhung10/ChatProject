namespace ChatLTM
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProfileName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Chatss = new System.Windows.Forms.TabPage();
            this.flpChats = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchChat = new System.Windows.Forms.TextBox();
            this.NewChats = new System.Windows.Forms.TabPage();
            this.btnCreateChat = new System.Windows.Forms.Button();
            this.flbAddChatMembers = new System.Windows.Forms.FlowLayoutPanel();
            this.txtChatName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabFriends = new System.Windows.Forms.TabControl();
            this.Friends = new System.Windows.Forms.TabPage();
            this.flbFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchFriends = new System.Windows.Forms.TextBox();
            this.Others = new System.Windows.Forms.TabPage();
            this.flbClients = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchClients = new System.Windows.Forms.TextBox();
            this.FriendRequest = new System.Windows.Forms.TabPage();
            this.flbRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Chatss.SuspendLayout();
            this.NewChats.SuspendLayout();
            this.tabFriends.SuspendLayout();
            this.Friends.SuspendLayout();
            this.Others.SuspendLayout();
            this.FriendRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(146, 17);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(109, 20);
            this.lblProfileName.TabIndex = 0;
            this.lblProfileName.Text = "lblProfileName";
            this.lblProfileName.Click += new System.EventHandler(this.lblProfileName_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMyProfile);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.lblProfileName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 632);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(11, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Location = new System.Drawing.Point(85, 13);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(55, 29);
            this.btnMyProfile.TabIndex = 3;
            this.btnMyProfile.Text = "button2";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Chatss);
            this.tabControl1.Controls.Add(this.NewChats);
            this.tabControl1.Location = new System.Drawing.Point(3, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(252, 566);
            this.tabControl1.TabIndex = 2;
            // 
            // Chatss
            // 
            this.Chatss.Controls.Add(this.flpChats);
            this.Chatss.Controls.Add(this.txtSearchChat);
            this.Chatss.Location = new System.Drawing.Point(4, 29);
            this.Chatss.Name = "Chatss";
            this.Chatss.Padding = new System.Windows.Forms.Padding(3);
            this.Chatss.Size = new System.Drawing.Size(244, 533);
            this.Chatss.TabIndex = 0;
            this.Chatss.Text = "chats";
            this.Chatss.UseVisualStyleBackColor = true;
            // 
            // flpChats
            // 
            this.flpChats.Location = new System.Drawing.Point(4, 39);
            this.flpChats.Name = "flpChats";
            this.flpChats.Size = new System.Drawing.Size(234, 488);
            this.flpChats.TabIndex = 1;
            // 
            // txtSearchChat
            // 
            this.txtSearchChat.Location = new System.Drawing.Point(4, 6);
            this.txtSearchChat.Name = "txtSearchChat";
            this.txtSearchChat.Size = new System.Drawing.Size(234, 27);
            this.txtSearchChat.TabIndex = 0;
            // 
            // NewChats
            // 
            this.NewChats.Controls.Add(this.btnCreateChat);
            this.NewChats.Controls.Add(this.flbAddChatMembers);
            this.NewChats.Controls.Add(this.txtChatName);
            this.NewChats.Controls.Add(this.label6);
            this.NewChats.Location = new System.Drawing.Point(4, 29);
            this.NewChats.Name = "NewChats";
            this.NewChats.Padding = new System.Windows.Forms.Padding(3);
            this.NewChats.Size = new System.Drawing.Size(244, 533);
            this.NewChats.TabIndex = 1;
            this.NewChats.Text = "New Chat";
            this.NewChats.UseVisualStyleBackColor = true;
            // 
            // btnCreateChat
            // 
            this.btnCreateChat.Location = new System.Drawing.Point(69, 479);
            this.btnCreateChat.Name = "btnCreateChat";
            this.btnCreateChat.Size = new System.Drawing.Size(94, 42);
            this.btnCreateChat.TabIndex = 0;
            this.btnCreateChat.Text = "Create Chat";
            this.btnCreateChat.UseVisualStyleBackColor = true;
            this.btnCreateChat.Click += new System.EventHandler(this.button1_Click);
            // 
            // flbAddChatMembers
            // 
            this.flbAddChatMembers.Location = new System.Drawing.Point(6, 46);
            this.flbAddChatMembers.Name = "flbAddChatMembers";
            this.flbAddChatMembers.Size = new System.Drawing.Size(232, 427);
            this.flbAddChatMembers.TabIndex = 0;
            // 
            // txtChatName
            // 
            this.txtChatName.Location = new System.Drawing.Point(83, 13);
            this.txtChatName.Name = "txtChatName";
            this.txtChatName.Size = new System.Drawing.Size(155, 27);
            this.txtChatName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chat name";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(276, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 629);
            this.panel2.TabIndex = 2;
            // 
            // tabFriends
            // 
            this.tabFriends.Controls.Add(this.Friends);
            this.tabFriends.Controls.Add(this.Others);
            this.tabFriends.Controls.Add(this.FriendRequest);
            this.tabFriends.Location = new System.Drawing.Point(772, 12);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.SelectedIndex = 0;
            this.tabFriends.Size = new System.Drawing.Size(263, 632);
            this.tabFriends.TabIndex = 3;
            // 
            // Friends
            // 
            this.Friends.Controls.Add(this.flbFriends);
            this.Friends.Controls.Add(this.txtSearchFriends);
            this.Friends.Location = new System.Drawing.Point(4, 29);
            this.Friends.Name = "Friends";
            this.Friends.Padding = new System.Windows.Forms.Padding(3);
            this.Friends.Size = new System.Drawing.Size(255, 599);
            this.Friends.TabIndex = 0;
            this.Friends.Text = "Friends";
            this.Friends.UseVisualStyleBackColor = true;
            // 
            // flbFriends
            // 
            this.flbFriends.Location = new System.Drawing.Point(6, 37);
            this.flbFriends.Name = "flbFriends";
            this.flbFriends.Size = new System.Drawing.Size(243, 556);
            this.flbFriends.TabIndex = 1;
            // 
            // txtSearchFriends
            // 
            this.txtSearchFriends.Location = new System.Drawing.Point(6, 6);
            this.txtSearchFriends.Name = "txtSearchFriends";
            this.txtSearchFriends.Size = new System.Drawing.Size(244, 27);
            this.txtSearchFriends.TabIndex = 0;
            // 
            // Others
            // 
            this.Others.Controls.Add(this.flbClients);
            this.Others.Controls.Add(this.txtSearchClients);
            this.Others.Location = new System.Drawing.Point(4, 29);
            this.Others.Name = "Others";
            this.Others.Padding = new System.Windows.Forms.Padding(3);
            this.Others.Size = new System.Drawing.Size(255, 599);
            this.Others.TabIndex = 1;
            this.Others.Text = "Others";
            this.Others.UseVisualStyleBackColor = true;
            // 
            // flbClients
            // 
            this.flbClients.Location = new System.Drawing.Point(8, 39);
            this.flbClients.Name = "flbClients";
            this.flbClients.Size = new System.Drawing.Size(241, 551);
            this.flbClients.TabIndex = 1;
            // 
            // txtSearchClients
            // 
            this.txtSearchClients.Location = new System.Drawing.Point(6, 6);
            this.txtSearchClients.Name = "txtSearchClients";
            this.txtSearchClients.Size = new System.Drawing.Size(243, 27);
            this.txtSearchClients.TabIndex = 0;
            // 
            // FriendRequest
            // 
            this.FriendRequest.Controls.Add(this.flbRequests);
            this.FriendRequest.Location = new System.Drawing.Point(4, 29);
            this.FriendRequest.Name = "FriendRequest";
            this.FriendRequest.Size = new System.Drawing.Size(255, 599);
            this.FriendRequest.TabIndex = 2;
            this.FriendRequest.Text = "Friend Request";
            this.FriendRequest.UseVisualStyleBackColor = true;
            // 
            // flbRequests
            // 
            this.flbRequests.Location = new System.Drawing.Point(5, 3);
            this.flbRequests.Name = "flbRequests";
            this.flbRequests.Size = new System.Drawing.Size(250, 593);
            this.flbRequests.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 646);
            this.Controls.Add(this.tabFriends);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Chatss.ResumeLayout(false);
            this.Chatss.PerformLayout();
            this.NewChats.ResumeLayout(false);
            this.NewChats.PerformLayout();
            this.tabFriends.ResumeLayout(false);
            this.Friends.ResumeLayout(false);
            this.Friends.PerformLayout();
            this.Others.ResumeLayout(false);
            this.Others.PerformLayout();
            this.FriendRequest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblProfileName;
        private Panel panel1;
        private Button btnLogout;
        private Button btnMyProfile;
        private TabControl tabControl1;
        private TabPage Chatss;
        private TabPage NewChats;
        private FlowLayoutPanel flpChats;
        private TextBox txtSearchChat;
        private Button btnCreateChat;
        private FlowLayoutPanel flbAddChatMembers;
        private TextBox txtChatName;
        private Label label6;
        private Panel panel2;
        private TabControl tabFriends;
        private TabPage Friends;
        private FlowLayoutPanel flbFriends;
        private TextBox txtSearchFriends;
        private TabPage Others;
        private TabPage FriendRequest;
        private FlowLayoutPanel flbClients;
        private TextBox txtSearchClients;
        private FlowLayoutPanel flbRequests;
    }
}