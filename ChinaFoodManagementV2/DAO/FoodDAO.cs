using ChinaFoodManagementV2.DTO;
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

        public List<FoodDTO> GetAllFood()
        {
            List<FoodDTO> foodDTOs = new List<FoodDTO>();
            using(var context = new ChinaFoodDBContext())
            {
                foodDTOs = (from f in context.Foods
                            join c in context.Categories on f.CategoryId equals c.Id
                            select new FoodDTO
                            {
                                FoodId = f.Id,
                                FoodName = f.FoodName,
                                CategoryName = c.CategoryName,
                                Price = f.Price
                            }).ToList();
            }

            return foodDTOs;
        }
        
        public int AddNewFood(Food food)
        {
            try
            {
                using(var context = new ChinaFoodDBContext())
                {
                    context.Foods.Add(food);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
                return 0;
            }

        }

        public int UpdateFood(Food food)
        {
            try
            {
                using (var context = new ChinaFoodDBContext())
                {
                    Food baseFood = context.Foods.Where(f => f.Id == food.Id).SingleOrDefault();
                    if (baseFood != null)
                    {
                        baseFood.FoodName = food.FoodName;
                        baseFood.CategoryId = food.CategoryId;
                        baseFood.Price = food.Price;
                    }
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage("ERR_9999", MessageBoxButtons.OK, ex.Message);
                return 0;
            }
        }

        public int DeleteFood(int foodId)
        {
            try
            {
                using (var context = new ChinaFoodDBContext())
                {
                    Food food = context.Foods.Where(f => f.Id == foodId).SingleOrDefault();
                    context.Foods.Remove(food);
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
