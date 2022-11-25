namespace ChatLTM
{
    partial class ClientItem
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
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(25, 27);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(104, 20);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "lblClientName";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(160, 23);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(94, 29);
            this.btnSendRequest.TabIndex = 1;
            this.btnSendRequest.Text = "Add friend";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            // 
            // ClientItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblClientName);
            this.Location = new System.Drawing.Point(144, 14);
            this.Name = "ClientItem";
            this.Size = new System.Drawing.Size(283, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblClientName;
        private Button btnSendRequest;
    }
}
