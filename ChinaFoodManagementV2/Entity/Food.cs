using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Entity
{
    [Table("tbl_food")]
    public class Food
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("food_name")]
        [MaxLength(20)]
        public string FoodName { get; set; }

        [Required]
        [Column("food_price", TypeName = "bigint")]
        [MaxLength(20)]
        public long Price { get; set; }

        //tbl category
        [Column("category_id")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
