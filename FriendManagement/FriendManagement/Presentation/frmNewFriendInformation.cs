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
    public partial class frmNewFriendInformation : Form
    {
        public frmNewFriendInformation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL.clsFriendInformation fndinfo = new DAL.clsFriendInformation();
            int er = 0;

            er = txtName.TxtVlidate();
            er = txtType.TxtVlidate();
            er = txtPhone.TxtVlidate();
            er = txtAddress.TxtVlidate();
            er = txtFacebook.TxtVlidate();
            er = txtDuration.TxtVlidate();

            if (er==0)
            {
                fndinfo.Name = txtName.txtTextValue;
                fndinfo.Type = txtType.txtTextValue;
                fndinfo.Phone = txtPhone.txtTextValue;
                fndinfo.Address = txtAddress.txtTextValue;
                fndinfo.Facebook = txtFacebook.txtTextValue;
                fndinfo.Duration = txtDuration.txtTextValue;

                if (fndinfo.Insert())
                {
                    MessageBox.Show("FriendInformation Inserted ");
                    txtName.txtTextValue = "";
                    txtType.txtTextValue = "";
                    txtPhone.txtTextValue = "";
                    txtAddress.txtTextValue = "";
                    txtFacebook.txtTextValue = "";
                    txtDuration.txtTextValue = "";
                }

                else
                {
                    MessageBox.Show(fndinfo.Error);
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
