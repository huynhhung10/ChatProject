using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatLTM
{
    public partial class AddChatMember : UserControl
    {
        private string friendName;
        public AddChatMember(string FriendName)
        {
            InitializeComponent();
            this.FriendName = FriendName;

        }
        public string FriendName
        {
            get { return friendName; }
            set { friendName = value; lblFriendName.Text = value; }
        }
        public bool Chosen
        {
            get { return chkChosen.Checked; }
            set { chkChosen.Checked = value; }
        }

    }
}
