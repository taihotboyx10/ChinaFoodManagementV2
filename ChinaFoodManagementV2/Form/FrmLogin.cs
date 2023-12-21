using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ChinaFoodManagementV2.DAO;
using ChinaFoodManagementV2.Utils;
using ChinaFoodManagementV2.Entity;

namespace ChinaFoodManagementV2
{
    public partial class FrmLogin : Form
    {
        private int loginError;
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Validate
        private bool LoginValidate()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Focus();
                lblMessage.Text = Constant.USERNAME_MESSAGE;
                lblMessage.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Focus();
                lblMessage.Text = Constant.PWD_MESSAGE;
                lblMessage.Visible = true;
                return false;
            }
            return true;
        }

        //su kien textchange de xoa lblMessage 
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        //su kien textchange de xoa lblMessage 
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }
        #endregion

        #region Login

        /// <summary>
        /// ５回以上ログインに失敗したかチェック
        /// </summary>
        /// <returns></returns>
        private bool CheckLoginError()
        {
            LoginDAO loginDAO = new LoginDAO();
            Account account = loginDAO.IsUserExist(txtUserName.Text);
            if (account != null && account.LoginError == 5)
            {
                MessageUtil.ShowMessage("ERR_2014", MessageBoxButtons.OK, this.Text);
                return true;
            }

            return false;
        }

        /// <summary>
        /// 入力したアカウントが存在するかチェック
        /// </summary>
        /// <returns></returns>
        private bool CheckLoginAcount()
        {
            LoginDAO loginDAO = new LoginDAO();
            Account account = loginDAO.IsUserExist(txtUserName.Text, txtPassword.Text);

            if(account != null)
            {
                return true;
            }
            return false;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!LoginValidate() || CheckLoginError()){
                return;
            }

            if (CheckLoginAcount())
            {
                loginError = 0;
                FrmMain frmMain = new FrmMain(txtUserName.Text);
                txtUserName.Text = "";
                txtPassword.Text = "";
                frmMain.FormClosed += FrmMain_FormClosed;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                // ユーザー名マッチング場合のみカウント
                LoginDAO loginDAO = new LoginDAO();
                Account account = loginDAO.IsUserExist(txtUserName.Text);
                if(account != null)
                {
                    loginError += 1;
                }
                MessageUtil.ShowMessage("ERR_2003", MessageBoxButtons.OK, this.Text);

                // Qua 5 lan thi luu vao DB
                if(loginError >= 5) 
                {
                    loginDAO.UpdateLoginError(txtUserName.Text);
                }
            }

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        #endregion

        #region Timer
        private void btnPasswordShow_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            TimeLogin.Start();
        }

        private void TimeLogin_Tick(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            TimeLogin.Stop();
        }

        #endregion

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageUtil.ShowMessage("QUES_1001", MessageBoxButtons.OKCancel, this.Text);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
