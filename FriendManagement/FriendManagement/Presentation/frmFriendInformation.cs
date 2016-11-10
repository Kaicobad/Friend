using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendManagement.Presentation
{
    public partial class frmFriendInformation : Form
    {
        public frmFriendInformation()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Presentation.frmNewFriendInformation nwfd = new frmNewFriendInformation();
            nwfd.ShowDialog();
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            DAL.clsFriendInformation fndinfo = new DAL.clsFriendInformation();
            dgvData.DataSource = fndinfo.Select().Tables[0];
        }
    }
}
