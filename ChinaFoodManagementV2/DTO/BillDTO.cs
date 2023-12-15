using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.DTO
{
    public class BillDTO
    {
        public int BillInFoId { get; set; }
        public string FoodName { get; set; }
        public long Price { get; set; }
        public int FoodCount { get; set; }
        public long Total { get; set; }
        public int FoodId { get; set; }
    }
}
