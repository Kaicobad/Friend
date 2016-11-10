namespace FriendManagement.Presentation
{
    partial class frmNewFriendInformation
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDuration = new FriendManagement.Presentation.Mycontrol.ucText();
            this.txtFacebook = new FriendManagement.Presentation.Mycontrol.ucText();
            this.txtAddress = new FriendManagement.Presentation.Mycontrol.ucText();
            this.txtPhone = new FriendManagement.Presentation.Mycontrol.ucText();
            this.txtType = new FriendManagement.Presentation.Mycontrol.ucText();
            this.txtName = new FriendManagement.Presentation.Mycontrol.ucText();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(289, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.AutoSize = true;
            this.txtDuration.Location = new System.Drawing.Point(20, 315);
            this.txtDuration.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(374, 35);
            this.txtDuration.TabIndex = 5;
            this.txtDuration.txtRequired = true;
            this.txtDuration.txtTextLabel = "Duration";
            this.txtDuration.txtTextValue = "";
            // 
            // txtFacebook
            // 
            this.txtFacebook.AutoSize = true;
            this.txtFacebook.Location = new System.Drawing.Point(20, 253);
            this.txtFacebook.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(374, 35);
            this.txtFacebook.TabIndex = 4;
            this.txtFacebook.txtRequired = true;
            this.txtFacebook.txtTextLabel = "Facebook";
            this.txtFacebook.txtTextValue = "";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(20, 190);
            this.txtAddress.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(374, 35);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.txtRequired = true;
            this.txtAddress.txtTextLabel = "Address";
            this.txtAddress.txtTextValue = "";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(20, 132);
            this.txtPhone.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(374, 35);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.txtRequired = true;
            this.txtPhone.txtTextLabel = "Phone";
            this.txtPhone.txtTextValue = "";
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Location = new System.Drawing.Point(20, 75);
            this.txtType.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(374, 35);
            this.txtType.TabIndex = 1;
            this.txtType.txtRequired = true;
            this.txtType.txtTextLabel = "Type";
            this.txtType.txtTextValue = "";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(20, 24);
            this.txtName.MinimumSize = new System.Drawing.Size(200, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(374, 35);
            this.txtName.TabIndex = 0;
            this.txtName.txtRequired = true;
            this.txtName.txtTextLabel = "Name";
            this.txtName.txtTextValue = "";
            // 
            // frmNewFriendInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 403);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Name = "frmNewFriendInformation";
            this.ShowIcon = false;
            this.Text = "New Friend Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private Mycontrol.ucText txtName;
        private Mycontrol.ucText txtType;
        private Mycontrol.ucText txtPhone;
        private Mycontrol.ucText txtAddress;
        private Mycontrol.ucText txtFacebook;
        private Mycontrol.ucText txtDuration;
        private System.Windows.Forms.Button btnExit;
    }
}