using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaFoodManagementV2.Entity
{
    [Table("tbl_account")]
    public class Account
    {
        [Key]
        [Required]
        [Column("user_name")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Column("display_name")]
        [MaxLength(50)]
        public string DisplayName { get; set; }

        [Required]
        [Column("password")]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [Column("user_type")]
        [MaxLength(2)]
        public string UserType { get; set; }

        [Column("login_error")]
        public int LoginError { get; set; }
    }
}
