﻿namespace TokenAssistant
{
    partial class AppsAdd
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
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblSecret = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.lblRedirectURL = new System.Windows.Forms.Label();
            this.txtRedirectURL = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textAppName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(16, 54);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(45, 13);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "ClientId:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(93, 51);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(164, 20);
            this.txtClientId.TabIndex = 1;
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Location = new System.Drawing.Point(16, 150);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(41, 13);
            this.lblSecret.TabIndex = 2;
            this.lblSecret.Text = "Secret:";
            // 
            // txtSecret
            // 
            this.txtSecret.Location = new System.Drawing.Point(93, 147);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(164, 20);
            this.txtSecret.TabIndex = 3;
            // 
            // lblRedirectURL
            // 
            this.lblRedirectURL.AutoSize = true;
            this.lblRedirectURL.Location = new System.Drawing.Point(16, 86);
            this.lblRedirectURL.Name = "lblRedirectURL";
            this.lblRedirectURL.Size = new System.Drawing.Size(72, 13);
            this.lblRedirectURL.TabIndex = 4;
            this.lblRedirectURL.Text = "RedirectURL:";
            // 
            // txtRedirectURL
            // 
            this.txtRedirectURL.Location = new System.Drawing.Point(93, 84);
            this.txtRedirectURL.Name = "txtRedirectURL";
            this.txtRedirectURL.Size = new System.Drawing.Size(164, 20);
            this.txtRedirectURL.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textAppName
            // 
            this.textAppName.Location = new System.Drawing.Point(93, 18);
            this.textAppName.Name = "textAppName";
            this.textAppName.Size = new System.Drawing.Size(164, 20);
            this.textAppName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(19, 118);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(93, 118);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(164, 21);
            this.comboType.TabIndex = 13;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // AppsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 246);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.textAppName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRedirectURL);
            this.Controls.Add(this.lblRedirectURL);
            this.Controls.Add(this.txtSecret);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.lblClientId);
            this.Name = "AppsAdd";
            this.Text = "AppsAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Label lblRedirectURL;
        private System.Windows.Forms.TextBox txtRedirectURL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textAppName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboType;
    }
}