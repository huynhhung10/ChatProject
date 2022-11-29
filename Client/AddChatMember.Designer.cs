using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    partial class AddChatMember
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
            this.lblFriendName = new System.Windows.Forms.Label();
            this.chkChosen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFriendName
            // 
            this.lblFriendName.AutoSize = true;
            this.lblFriendName.Location = new System.Drawing.Point(14, 27);
            this.lblFriendName.Name = "lblFriendName";
            this.lblFriendName.Size = new System.Drawing.Size(107, 20);
            this.lblFriendName.TabIndex = 0;
            this.lblFriendName.Text = "lblFriendName";
            // 
            // chkChosen
            // 
            this.chkChosen.AutoSize = true;
            this.chkChosen.Location = new System.Drawing.Point(167, 27);
            this.chkChosen.Name = "chkChosen";
            this.chkChosen.Size = new System.Drawing.Size(101, 24);
            this.chkChosen.TabIndex = 1;
            this.chkChosen.Text = "checkBox1";
            this.chkChosen.UseVisualStyleBackColor = true;
            // 
            // AddChatMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkChosen);
            this.Controls.Add(this.lblFriendName);
            this.Name = "AddChatMember";
            this.Size = new System.Drawing.Size(283, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFriendName;
        private CheckBox chkChosen;
    }
}
