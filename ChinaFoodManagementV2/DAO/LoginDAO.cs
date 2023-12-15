using ChinaFoodManagementV2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChinaFoodManagementV2.Utils;

namespace ChinaFoodManagementV2.DAO
{
    public class LoginDAO
    {
        public Account IsUserExist(string username, string password = null)
        {
            using (ChinaFoodDBContext context = new ChinaFoodDBContext())
            {
                if (string.IsNullOrEmpty(password))
                {
                    return context.Accounts
                                  .FirstOrDefault(a => a.UserName == username);
                }
                else
                {
                    return context.Accounts
                                  .FirstOrDefault(a => a.UserName == username && a.Password == password);
                }
            }
        }


        public void UpdateLoginError(string userName)
        {
            Account account = new Account();
            try
            {
                using (var context = new ChinaFoodDBContext())
                {
                    account = (from a in context.Accounts where a.UserName == userName select a).FirstOrDefault();

                    if(account != null)
                    {
                        account.LoginError = 5;
                        context.SaveChanges();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
            }
        }
    }
}
