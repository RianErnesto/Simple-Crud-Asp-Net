using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class RegionModel
    {
        [Key]
        public int RegionID { get; set; }
        [StringLength(50)]
        [Required]
        public string RegionDescription { get; set; }
    }
}
