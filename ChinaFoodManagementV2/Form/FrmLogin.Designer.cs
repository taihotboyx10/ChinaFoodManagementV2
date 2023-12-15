namespace ChinaFoodManagementV2
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnPasswordShow = new Guna.UI2.WinForms.Guna2Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ユーザーID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLogin = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPasswordShow
            // 
            this.btnPasswordShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPasswordShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPasswordShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPasswordShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPasswordShow.FillColor = System.Drawing.Color.White;
            this.btnPasswordShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPasswordShow.ForeColor = System.Drawing.Color.White;
            this.btnPasswordShow.Image = ((System.Drawing.Image)(resources.GetObject("btnPasswordShow.Image")));
            this.btnPasswordShow.Location = new System.Drawing.Point(484, 211);
            this.btnPasswordShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPasswordShow.Name = "btnPasswordShow";
            this.btnPasswordShow.Size = new System.Drawing.Size(45, 39);
            this.btnPasswordShow.TabIndex = 21;
            this.btnPasswordShow.Click += new System.EventHandler(this.btnPasswordShow_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(212, 85);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(59, 22);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.Text = "label3";
            this.lblMessage.Visible = false;
            // 
            // btnOut
            // 
            this.btnOut.BorderColor = System.Drawing.Color.White;
            this.btnOut.BorderRadius = 15;
            this.btnOut.BorderThickness = 2;
            this.btnOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOut.FillColor = System.Drawing.Color.Black;
            this.btnOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(394, 293);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(116, 44);
            this.btnOut.TabIndex = 16;
            this.btnOut.Text = "閉じる";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(233, 293);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 44);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "ログイン";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(214, 210);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "パスワード";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(316, 42);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(214, 120);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "ユーザー名";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(316, 42);
            this.txtUserName.TabIndex = 13;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "パスワード";
            // 
            // ユーザーID
            // 
            this.ユーザーID.AutoSize = true;
            this.ユーザーID.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ユーザーID.Location = new System.Drawing.Point(81, 125);
            this.ユーザーID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ユーザーID.Name = "ユーザーID";
            this.ユーザーID.Size = new System.Drawing.Size(97, 25);
            this.ユーザーID.TabIndex = 18;
            this.ユーザーID.Text = "ユーザー名";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "ログイン";
            // 
            // TimeLogin
            // 
            this.TimeLogin.Interval = 700;
            this.TimeLogin.Tick += new System.EventHandler(this.TimeLogin_Tick);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(715, 387);
            this.ControlBox = false;
            this.Controls.Add(this.btnPasswordShow);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ユーザーID);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPasswordShow;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2Button btnOut;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ユーザーID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimeLogin;
    }
}

