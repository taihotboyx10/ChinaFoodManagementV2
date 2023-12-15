using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Entity
{
    [Table("tbl_table")]
    public class Table
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("table_name")]
        [MaxLength(20)]
        public string TableName { get; set; }

        [Required]
        [Column("table_status")]
        public int TableStatus { get; set; }
    }
}
