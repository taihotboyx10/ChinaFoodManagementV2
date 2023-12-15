using ChinaFoodManagementV2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.DAO
{
    public class CategoryDAO
    {
        public List<Category> GetAllCategory()
        {
            List<Category> categories = new List<Category>();
            using(var context = new ChinaFoodDBContext())
            {
                categories = context.Categories.ToList();
            }

            return categories;
        }
    }
}
