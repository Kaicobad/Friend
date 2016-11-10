using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void registeredFriendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.frmFriendInformation fdin = new Presentation.frmFriendInformation();

            fdin.Show();
            fdin.MdiParent = this;
            if (fdin.IsDisposed)
                fdin = new Presentation.frmFriendInformation();

        }

        private void newFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentation.frmNewFriendInformation fndnew = new Presentation.frmNewFriendInformation();
            fndnew.Show();
        }
    }
}
