using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class CustomerCustomerDemoModel
    {
        [StringLength(5)]
        [Key]
        public string CustomerID { get; set; }
        [StringLength(10)]
        [Required]
        public string CustomerTypeID { get; set; }
    }
}
