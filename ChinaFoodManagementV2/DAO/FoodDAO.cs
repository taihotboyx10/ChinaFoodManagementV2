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
    public class FoodDAO
    {
        public List<Food> GetFoodByCategory(int categoryId)
        {
            List<Food> foodList = new List<Food>();
            using(var context = new ChinaFoodDBContext())
            {
                foodList = context.Foods.Where(f => f.CategoryId == categoryId).ToList();
            }
            return foodList;
        } 

        public int AddFoodQuantity(int foodCount, int billInFoId)
        {
            try
            {
                BillInfo billInfo = new BillInfo();
                using (var context = new ChinaFoodDBContext())
                {
                    billInfo = context.BillInfos.Where(b => b.Id == billInFoId).FirstOrDefault();
                    billInfo.FoodCount += foodCount;

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
