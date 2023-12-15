using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Utils
{
    public class Validate
    {
        public bool ValidatePassword(string password)
        {
            // Kiểm tra xem mật khẩu có ít nhất 6 ký tự không
            if (password.Length < 6)
            {
                return false;
            }

            // Kiểm tra xem mật khẩu có ít nhất 1 chữ hoa không
            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                return false;
            }

            // Kiểm tra xem mật khẩu có ít nhất 1 số không
            if (!Regex.IsMatch(password, @"\d"))
            {
                return false;
            }

            // Nếu mật khẩu thoả mãn tất cả các điều kiện, trả về true
            return true;
        }

        public bool PhoneValid(string phone)
        {
            string pattern = @"^(?:\+?(\d{1,3}))?[-.\s]?(\d{3})[-.\s]?(\d{3})[-.\s]?(\d{4})$";
            var result = Regex.IsMatch(phone, pattern);
            return result;
        }
    }
}
