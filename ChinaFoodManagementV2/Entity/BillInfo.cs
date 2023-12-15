using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Entity
{
    [Table("tbl_bill_info")]
    public class BillInfo
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Column("food_count")]
        [Required]
        public int FoodCount { get; set; }



        //tbl bill
        [Required]
        [Column("bill_id")]
        public int BillId { get; set; }
        public Bill Bill { get; set; }


        //tbl food
        [Required]
        [Column("food_id")]
        public int FoodId { get; set; }
        public Food Food { get; set; }






    }
}
