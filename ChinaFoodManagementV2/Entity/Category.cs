using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Entity
{
    [Table("tbl_category")]
    public class Category
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("category_name")]
        [MaxLength(20)]
        public string CategoryName { get; set; }
    }
}
