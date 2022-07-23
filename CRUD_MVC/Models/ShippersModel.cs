using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class ShippersModel
    {
        [Key]
        public int ShipperID { get; set; }
        [StringLength(40)]
        [Required]
        public string CompanyName { get; set; }
        [StringLength(24)]
        public string Phone { get; set; }
    }
}
