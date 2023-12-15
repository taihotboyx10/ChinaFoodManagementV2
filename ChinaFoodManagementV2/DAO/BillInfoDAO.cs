using ChinaFoodManagementV2.Entity;
using ChinaFoodManagementV2.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinaFoodManagementV2.DAO
{
    public class BillInfoDAO
    {
        public int InsertNewBillInfo(BillInfo billInfo)
        {
            int result = 0;
            try
            {
                using (var context = new ChinaFoodDBContext())
                {
                    context.BillInfos.Add(billInfo);
                    result = context.SaveChanges();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
                return result;
            }
        }

        public int DeleteBillInFo(int billInfoId)
        {
            try
            {
                using (var context = new ChinaFoodDBContext())
                {
                    BillInfo billInfo = context.BillInfos.Find(billInfoId);
                    context.BillInfos.Remove(billInfo);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
                return 0;
            }
        }

    }
}
