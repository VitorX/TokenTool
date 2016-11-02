namespace TokenAssistant
{
    partial class Main
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
            this.listApps = new System.Windows.Forms.ListBox();
            this.btnDelegateToken = new System.Windows.Forms.Button();
            this.btnAppToken = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.btnUserManage = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtAccessToken = new System.Windows.Forms.TextBox();
            this.txtRefreshToken = new System.Windows.Forms.TextBox();
            this.lblAccessToken = new System.Windows.Forms.Label();
            this.lblRefreshToken = new System.Windows.Forms.Label();
            this.btnRenewToken = new System.Windows.Forms.Button();
            this.lstResrouce = new System.Windows.Forms.ListBox();
            this.lblResrouce = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listApps
            // 
            this.listApps.FormattingEnabled = true;
            this.listApps.Location = new System.Drawing.Point(12, 21);
            this.listApps.Name = "listApps";
            this.listApps.Size = new System.Drawing.Size(111, 212);
            this.listApps.TabIndex = 0;
            this.listApps.SelectedIndexChanged += new System.EventHandler(this.listApps_SelectedIndexChanged);
            // 
            // btnDelegateToken
            // 
            this.btnDelegateToken.Location = new System.Drawing.Point(295, 21);
            this.btnDelegateToken.Name = "btnDelegateToken";
            this.btnDelegateToken.Size = new System.Drawing.Size(120, 23);
            this.btnDelegateToken.TabIndex = 1;
            this.btnDelegateToken.Text = "DelegateToken";
            this.btnDelegateToken.UseVisualStyleBackColor = true;
            this.btnDelegateToken.Click += new System.EventHandler(this.btnDelegateToken_Click);
            // 
            // btnAppToken
            // 
            this.btnAppToken.Location = new System.Drawing.Point(295, 50);
            this.btnAppToken.Name = "btnAppToken";
            this.btnAppToken.Size = new System.Drawing.Size(120, 23);
            this.btnAppToken.TabIndex = 1;
            this.btnAppToken.Text = "AppToken";
            this.btnAppToken.UseVisualStyleBackColor = true;
            this.btnAppToken.Click += new System.EventHandler(this.btnAppToken_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(295, 117);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(120, 23);
            this.btnRefreshList.TabIndex = 2;
            this.btnRefreshList.Text = "RefreshList";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(295, 146);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(120, 23);
            this.btnAddApp.TabIndex = 2;
            this.btnAddApp.Text = "AddApp";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnUserManage
            // 
            this.btnUserManage.Location = new System.Drawing.Point(295, 175);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(120, 23);
            this.btnUserManage.TabIndex = 3;
            this.btnUserManage.Text = "UserManage";
            this.btnUserManage.UseVisualStyleBackColor = true;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(295, 204);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "DeleteApp";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtAccessToken
            // 
            this.txtAccessToken.Location = new System.Drawing.Point(12, 267);
            this.txtAccessToken.Multiline = true;
            this.txtAccessToken.Name = "txtAccessToken";
            this.txtAccessToken.Size = new System.Drawing.Size(403, 68);
            this.txtAccessToken.TabIndex = 5;
            this.txtAccessToken.Click += new System.EventHandler(this.txtAccessToken_Click);
            this.txtAccessToken.Enter += new System.EventHandler(this.txtAccessToken_Enter);
            // 
            // txtRefreshToken
            // 
            this.txtRefreshToken.Location = new System.Drawing.Point(12, 369);
            this.txtRefreshToken.Multiline = true;
            this.txtRefreshToken.Name = "txtRefreshToken";
            this.txtRefreshToken.Size = new System.Drawing.Size(403, 68);
            this.txtRefreshToken.TabIndex = 6;
            this.txtRefreshToken.Click += new System.EventHandler(this.txtRefreshToken_Click);
            this.txtRefreshToken.Enter += new System.EventHandler(this.txtRefreshToken_Enter);
            // 
            // lblAccessToken
            // 
            this.lblAccessToken.AutoSize = true;
            this.lblAccessToken.Location = new System.Drawing.Point(13, 246);
            this.lblAccessToken.Name = "lblAccessToken";
            this.lblAccessToken.Size = new System.Drawing.Size(76, 13);
            this.lblAccessToken.TabIndex = 7;
            this.lblAccessToken.Text = "AccessToken:";
            // 
            // lblRefreshToken
            // 
            this.lblRefreshToken.AutoSize = true;
            this.lblRefreshToken.Location = new System.Drawing.Point(12, 346);
            this.lblRefreshToken.Name = "lblRefreshToken";
            this.lblRefreshToken.Size = new System.Drawing.Size(78, 13);
            this.lblRefreshToken.TabIndex = 8;
            this.lblRefreshToken.Text = "RefreshToken:";
            // 
            // btnRenewToken
            // 
            this.btnRenewToken.Location = new System.Drawing.Point(295, 82);
            this.btnRenewToken.Name = "btnRenewToken";
            this.btnRenewToken.Size = new System.Drawing.Size(120, 23);
            this.btnRenewToken.TabIndex = 9;
            this.btnRenewToken.Text = "Renew Token";
            this.btnRenewToken.UseVisualStyleBackColor = true;
            this.btnRenewToken.Click += new System.EventHandler(this.btnRenewToken_Click);
            // 
            // lstResrouce
            // 
            this.lstResrouce.FormattingEnabled = true;
            this.lstResrouce.Location = new System.Drawing.Point(130, 41);
            this.lstResrouce.Name = "lstResrouce";
            this.lstResrouce.Size = new System.Drawing.Size(151, 95);
            this.lstResrouce.TabIndex = 10;
            this.lstResrouce.SelectedIndexChanged += new System.EventHandler(this.lstResrouce_SelectedIndexChanged);
            // 
            // lblResrouce
            // 
            this.lblResrouce.AutoSize = true;
            this.lblResrouce.Location = new System.Drawing.Point(130, 21);
            this.lblResrouce.Name = "lblResrouce";
            this.lblResrouce.Size = new System.Drawing.Size(56, 13);
            this.lblResrouce.TabIndex = 11;
            this.lblResrouce.Text = "Resrouce:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(130, 143);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User:";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(130, 163);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(151, 69);
            this.lstUsers.TabIndex = 13;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            this.lstUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstUsers_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 449);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblResrouce);
            this.Controls.Add(this.lstResrouce);
            this.Controls.Add(this.btnRenewToken);
            this.Controls.Add(this.lblRefreshToken);
            this.Controls.Add(this.lblAccessToken);
            this.Controls.Add(this.txtRefreshToken);
            this.Controls.Add(this.txtAccessToken);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnUserManage);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnAppToken);
            this.Controls.Add(this.btnDelegateToken);
            this.Controls.Add(this.listApps);
            this.Name = "Main";
            this.Text = "TokenAssistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listApps;
        private System.Windows.Forms.Button btnDelegateToken;
        private System.Windows.Forms.Button btnAppToken;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnUserManage;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox txtAccessToken;
        private System.Windows.Forms.TextBox txtRefreshToken;
        private System.Windows.Forms.Label lblAccessToken;
        private System.Windows.Forms.Label lblRefreshToken;
        private System.Windows.Forms.Button btnRenewToken;
        private System.Windows.Forms.ListBox lstResrouce;
        private System.Windows.Forms.Label lblResrouce;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ListBox lstUsers;
    }
}

