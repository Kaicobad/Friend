using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendManagement.Presentation.Mycontrol
{
    public partial class ucText : UserControl
    {
        public bool txtRequired { get; set; }

        public string txtTextLabel 
        {
            get 
            {
                return lblLabel.Text;
            }
            set
            {
               lblLabel.Text = value;

            }
        }

        public string txtTextValue { 
            get 
            {
                return txtText.Text;
            } 
            set 
            {
                txtText.Text = value;
            } 
        }


        public int TxtVlidate()
        {
            lblError.Text = "";

            if (txtRequired && txtText.Text == "")
            {
                lblError.Text = "Reqired";
                return 1;
            }
            return 0;
        }

        public ucText()
        {
            InitializeComponent();
        }
    }
}
