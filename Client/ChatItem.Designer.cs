namespace Client
{
    partial class ChatItem
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblChatName = new System.Windows.Forms.Label();
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.lblDateLastMessage = new System.Windows.Forms.Label();
            this.lblUnread = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChatName
            // 
            this.lblChatName.AutoSize = true;
            this.lblChatName.Location = new System.Drawing.Point(13, 14);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(96, 20);
            this.lblChatName.TabIndex = 0;
            this.lblChatName.Text = "lblChatName";
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.Location = new System.Drawing.Point(13, 46);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(110, 20);
            this.lblLastMessage.TabIndex = 1;
            this.lblLastMessage.Text = "lblLastMessage";
            // 
            // lblDateLastMessage
            // 
            this.lblDateLastMessage.AutoSize = true;
            this.lblDateLastMessage.Location = new System.Drawing.Point(207, 14);
            this.lblDateLastMessage.Name = "lblDateLastMessage";
            this.lblDateLastMessage.Size = new System.Drawing.Size(69, 20);
            this.lblDateLastMessage.TabIndex = 2;
            this.lblDateLastMessage.Text = "03/10/20";
            // 
            // lblUnread
            // 
            this.lblUnread.AutoSize = true;
            this.lblUnread.Location = new System.Drawing.Point(144, 14);
            this.lblUnread.Name = "lblUnread";
            this.lblUnread.Size = new System.Drawing.Size(57, 20);
            this.lblUnread.TabIndex = 3;
            this.lblUnread.Text = "Unread";
            // 
            // ChatItem
            // 
            this.Controls.Add(this.lblUnread);
            this.Controls.Add(this.lblDateLastMessage);
            this.Controls.Add(this.lblLastMessage);
            this.Controls.Add(this.lblChatName);
            this.Name = "ChatItem";
            this.Size = new System.Drawing.Size(283, 75);
            this.Click += new System.EventHandler(this.ChatItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChatName;
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblDateLastMessage;
        private System.Windows.Forms.Label lblUnread;
    }
}
