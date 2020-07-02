namespace OnlineBookStore
{
    partial class UC_CustomerSettings
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerUserName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerNewPassword = new System.Windows.Forms.Label();
            this.pnlChangePassword = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtBoxCustomerOldPassword = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerNewPassword = new System.Windows.Forms.TextBox();
            this.lblCustomerOldPassword = new System.Windows.Forms.Label();
            this.pnlChangeCustomerInformation = new System.Windows.Forms.Panel();
            this.txtBoxPasswordControl = new System.Windows.Forms.TextBox();
            this.lblPasswordControl = new System.Windows.Forms.Label();
            this.btnUptadeCustomerInformations = new System.Windows.Forms.Button();
            this.txtBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerUsername = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerName = new System.Windows.Forms.TextBox();
            this.btnEnableUptadeChangePasswordPanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlChangePassword.SuspendLayout();
            this.pnlChangeCustomerInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(54, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(84, 26);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // lblCustomerUserName
            // 
            this.lblCustomerUserName.AutoSize = true;
            this.lblCustomerUserName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerUserName.Location = new System.Drawing.Point(6, 53);
            this.lblCustomerUserName.Name = "lblCustomerUserName";
            this.lblCustomerUserName.Size = new System.Drawing.Size(132, 26);
            this.lblCustomerUserName.TabIndex = 1;
            this.lblCustomerUserName.Text = "Username:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(30, 95);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(108, 26);
            this.lblCustomerAddress.TabIndex = 2;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(54, 198);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(83, 26);
            this.lblCustomerEmail.TabIndex = 3;
            this.lblCustomerEmail.Text = "Email:";
            // 
            // lblCustomerNewPassword
            // 
            this.lblCustomerNewPassword.AutoSize = true;
            this.lblCustomerNewPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerNewPassword.Location = new System.Drawing.Point(3, 12);
            this.lblCustomerNewPassword.Name = "lblCustomerNewPassword";
            this.lblCustomerNewPassword.Size = new System.Drawing.Size(177, 26);
            this.lblCustomerNewPassword.TabIndex = 4;
            this.lblCustomerNewPassword.Text = "New Password:";
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChangePassword.Controls.Add(this.btnChangePassword);
            this.pnlChangePassword.Controls.Add(this.txtBoxCustomerOldPassword);
            this.pnlChangePassword.Controls.Add(this.txtBoxCustomerNewPassword);
            this.pnlChangePassword.Controls.Add(this.lblCustomerOldPassword);
            this.pnlChangePassword.Controls.Add(this.lblCustomerNewPassword);
            this.pnlChangePassword.Location = new System.Drawing.Point(287, 446);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.Size = new System.Drawing.Size(390, 170);
            this.pnlChangePassword.TabIndex = 5;
            this.pnlChangePassword.Visible = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(264, 114);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(119, 43);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtBoxCustomerOldPassword
            // 
            this.txtBoxCustomerOldPassword.Location = new System.Drawing.Point(186, 58);
            this.txtBoxCustomerOldPassword.Name = "txtBoxCustomerOldPassword";
            this.txtBoxCustomerOldPassword.PasswordChar = '*';
            this.txtBoxCustomerOldPassword.Size = new System.Drawing.Size(197, 22);
            this.txtBoxCustomerOldPassword.TabIndex = 9;
            // 
            // txtBoxCustomerNewPassword
            // 
            this.txtBoxCustomerNewPassword.Location = new System.Drawing.Point(186, 17);
            this.txtBoxCustomerNewPassword.Name = "txtBoxCustomerNewPassword";
            this.txtBoxCustomerNewPassword.PasswordChar = '*';
            this.txtBoxCustomerNewPassword.Size = new System.Drawing.Size(197, 22);
            this.txtBoxCustomerNewPassword.TabIndex = 8;
            // 
            // lblCustomerOldPassword
            // 
            this.lblCustomerOldPassword.AutoSize = true;
            this.lblCustomerOldPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomerOldPassword.Location = new System.Drawing.Point(12, 53);
            this.lblCustomerOldPassword.Name = "lblCustomerOldPassword";
            this.lblCustomerOldPassword.Size = new System.Drawing.Size(168, 26);
            this.lblCustomerOldPassword.TabIndex = 5;
            this.lblCustomerOldPassword.Text = "Old Password:";
            // 
            // pnlChangeCustomerInformation
            // 
            this.pnlChangeCustomerInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChangeCustomerInformation.Controls.Add(this.txtBoxPasswordControl);
            this.pnlChangeCustomerInformation.Controls.Add(this.lblPasswordControl);
            this.pnlChangeCustomerInformation.Controls.Add(this.btnUptadeCustomerInformations);
            this.pnlChangeCustomerInformation.Controls.Add(this.txtBoxCustomerEmail);
            this.pnlChangeCustomerInformation.Controls.Add(this.txtBoxCustomerAddress);
            this.pnlChangeCustomerInformation.Controls.Add(this.txtBoxCustomerUsername);
            this.pnlChangeCustomerInformation.Controls.Add(this.txtBoxCustomerName);
            this.pnlChangeCustomerInformation.Controls.Add(this.lblCustomerEmail);
            this.pnlChangeCustomerInformation.Controls.Add(this.lblCustomerName);
            this.pnlChangeCustomerInformation.Controls.Add(this.lblCustomerUserName);
            this.pnlChangeCustomerInformation.Controls.Add(this.lblCustomerAddress);
            this.pnlChangeCustomerInformation.Location = new System.Drawing.Point(287, 27);
            this.pnlChangeCustomerInformation.Name = "pnlChangeCustomerInformation";
            this.pnlChangeCustomerInformation.Size = new System.Drawing.Size(390, 413);
            this.pnlChangeCustomerInformation.TabIndex = 6;
            // 
            // txtBoxPasswordControl
            // 
            this.txtBoxPasswordControl.Location = new System.Drawing.Point(108, 312);
            this.txtBoxPasswordControl.Name = "txtBoxPasswordControl";
            this.txtBoxPasswordControl.PasswordChar = '*';
            this.txtBoxPasswordControl.Size = new System.Drawing.Size(197, 22);
            this.txtBoxPasswordControl.TabIndex = 9;
            // 
            // lblPasswordControl
            // 
            this.lblPasswordControl.AutoSize = true;
            this.lblPasswordControl.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordControl.Location = new System.Drawing.Point(59, 268);
            this.lblPasswordControl.Name = "lblPasswordControl";
            this.lblPasswordControl.Size = new System.Drawing.Size(301, 26);
            this.lblPasswordControl.TabIndex = 8;
            this.lblPasswordControl.Text = "Enter Password to Change";
            // 
            // btnUptadeCustomerInformations
            // 
            this.btnUptadeCustomerInformations.Location = new System.Drawing.Point(148, 351);
            this.btnUptadeCustomerInformations.Name = "btnUptadeCustomerInformations";
            this.btnUptadeCustomerInformations.Size = new System.Drawing.Size(120, 45);
            this.btnUptadeCustomerInformations.TabIndex = 7;
            this.btnUptadeCustomerInformations.Text = "Uptade";
            this.btnUptadeCustomerInformations.UseVisualStyleBackColor = true;
            this.btnUptadeCustomerInformations.Click += new System.EventHandler(this.btnUptadeCustomerInformations_Click);
            // 
            // txtBoxCustomerEmail
            // 
            this.txtBoxCustomerEmail.Location = new System.Drawing.Point(163, 203);
            this.txtBoxCustomerEmail.Name = "txtBoxCustomerEmail";
            this.txtBoxCustomerEmail.Size = new System.Drawing.Size(197, 22);
            this.txtBoxCustomerEmail.TabIndex = 7;
            // 
            // txtBoxCustomerAddress
            // 
            this.txtBoxCustomerAddress.Location = new System.Drawing.Point(163, 100);
            this.txtBoxCustomerAddress.Multiline = true;
            this.txtBoxCustomerAddress.Name = "txtBoxCustomerAddress";
            this.txtBoxCustomerAddress.Size = new System.Drawing.Size(197, 86);
            this.txtBoxCustomerAddress.TabIndex = 6;
            // 
            // txtBoxCustomerUsername
            // 
            this.txtBoxCustomerUsername.Location = new System.Drawing.Point(163, 58);
            this.txtBoxCustomerUsername.Name = "txtBoxCustomerUsername";
            this.txtBoxCustomerUsername.Size = new System.Drawing.Size(197, 22);
            this.txtBoxCustomerUsername.TabIndex = 5;
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.Location = new System.Drawing.Point(163, 17);
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.Size = new System.Drawing.Size(197, 22);
            this.txtBoxCustomerName.TabIndex = 4;
            // 
            // btnEnableUptadeChangePasswordPanel
            // 
            this.btnEnableUptadeChangePasswordPanel.Location = new System.Drawing.Point(299, 561);
            this.btnEnableUptadeChangePasswordPanel.Name = "btnEnableUptadeChangePasswordPanel";
            this.btnEnableUptadeChangePasswordPanel.Size = new System.Drawing.Size(177, 43);
            this.btnEnableUptadeChangePasswordPanel.TabIndex = 11;
            this.btnEnableUptadeChangePasswordPanel.Text = "Change Password";
            this.btnEnableUptadeChangePasswordPanel.UseVisualStyleBackColor = true;
            this.btnEnableUptadeChangePasswordPanel.Click += new System.EventHandler(this.btnEnableUptadeChangePasswordPanel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlChangeCustomerInformation);
            this.panel1.Controls.Add(this.btnEnableUptadeChangePasswordPanel);
            this.panel1.Controls.Add(this.pnlChangePassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 684);
            this.panel1.TabIndex = 12;
            // 
            // UC_CustomerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_CustomerSettings";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.UC_CustomerSettings_Load);
            this.pnlChangePassword.ResumeLayout(false);
            this.pnlChangePassword.PerformLayout();
            this.pnlChangeCustomerInformation.ResumeLayout(false);
            this.pnlChangeCustomerInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerUserName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerNewPassword;
        private System.Windows.Forms.Panel pnlChangePassword;
        private System.Windows.Forms.Label lblCustomerOldPassword;
        private System.Windows.Forms.Panel pnlChangeCustomerInformation;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtBoxCustomerOldPassword;
        private System.Windows.Forms.TextBox txtBoxCustomerNewPassword;
        private System.Windows.Forms.TextBox txtBoxPasswordControl;
        private System.Windows.Forms.Label lblPasswordControl;
        private System.Windows.Forms.Button btnUptadeCustomerInformations;
        private System.Windows.Forms.TextBox txtBoxCustomerEmail;
        private System.Windows.Forms.TextBox txtBoxCustomerAddress;
        private System.Windows.Forms.TextBox txtBoxCustomerUsername;
        private System.Windows.Forms.TextBox txtBoxCustomerName;
        private System.Windows.Forms.Button btnEnableUptadeChangePasswordPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
