using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Utils
{
    public class Constant
    {
        public static readonly string USERNAME_MESSAGE = "ユーザー名は入力されていません。";
        public static readonly string PWD_MESSAGE = "パスワードは入力されていません。";

        public static readonly Dictionary<int, string> TABLE_STATUS = new Dictionary<int, string>
        {
            { 0, "空"},
            { 1, "満"},
            { 2, "予約済み"},
        };

        public static readonly Dictionary<int, string> ACCOUNT_TYPE = new Dictionary<int, string>
        {
            { 0, "一般ユーザー"},
            { 1, "マネージャー"},
        };
    }
}
