namespace ChatLTM
{
    partial class Chat
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
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.flbChat = new System.Windows.Forms.FlowLayoutPanel();
            this.lblChatName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(14, 522);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(375, 84);
            this.textMessage.TabIndex = 2;
            this.textMessage.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblChatName);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 47);
            this.panel1.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(395, 536);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 57);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(395, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 47);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // flbChat
            // 
            this.flbChat.Location = new System.Drawing.Point(14, 66);
            this.flbChat.Name = "flbChat";
            this.flbChat.Size = new System.Drawing.Size(459, 450);
            this.flbChat.TabIndex = 4;
            // 
            // lblChatName
            // 
            this.lblChatName.AutoSize = true;
            this.lblChatName.Location = new System.Drawing.Point(15, 12);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(96, 20);
            this.lblChatName.TabIndex = 0;
            this.lblChatName.Text = "lblChatName";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flbChat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textMessage);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(490, 629);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textMessage;
        private Panel panel1;
        private Button btnSend;
        private Button btnClose;
        private Label lblChatName;
        private FlowLayoutPanel flbChat;
    }
}
