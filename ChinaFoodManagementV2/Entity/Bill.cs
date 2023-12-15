using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Entity
{
    [Table("tbl_bill")]
    public class Bill
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("date_checkin")]
        public DateTime DateCheckin { get; set; }

        [Column("date_checkout")]
        public DateTime DateCheckout { get; set; }

        [Required]
        [Column("status_paid")]
        public int StatusPaid { get; set; }

        [Column("discount")]
        public int? Discount { get; set; }

        [Column("total_price", TypeName = "bigint")]
        public long? TotalPrice { get; set; }

        //tbl tableseat
        [Required]
        [Column("table_id")]
        public int TableId { get; set; }
        public Table Table { get; set; }

    }
}
