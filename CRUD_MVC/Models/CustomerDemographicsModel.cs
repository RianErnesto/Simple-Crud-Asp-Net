using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class CustomerDemographicsModel
    {
        [StringLength(10)]
        [Key]
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    }
}
