using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Entity
{
    [Table("tbl_reservation")]
    public class Reservation
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("cust_name")]
        [MaxLength(20)]
        public string CustName { get; set; }

        [Column("phone")]
        [MaxLength(13)]
        public string Phone { get; set; }

        [Required]
        [Column("res_date")]
        public DateTime ResDate { get; set; }

        [Required]
        [Column("res_time", TypeName = "time")]
        public TimeSpan ResTime { get; set; }

        [Column("people_num")]
        public int PeopleNum { get; set; }

    }
}
