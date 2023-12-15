using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.DTO
{
    public class BillMngDTO
    {
        public int BillId { get; set; }
        public string TableName { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public int? Discount { get; set; }
        public long? Total { get; set; }
    }
}
