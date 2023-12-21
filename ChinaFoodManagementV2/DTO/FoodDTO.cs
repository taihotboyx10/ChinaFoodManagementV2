using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.DTO
{
    public class FoodDTO
    {
        public int FoodId { get; set; } 
        public string FoodName { get; set; }
        public string CategoryName { get; set; }
        public long Price { get; set; }
    }
}
