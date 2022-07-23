using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class TerritoriesModel
    {
        [StringLength(20)]
        [Key]
        public string TerritoryID { get; set; }
        [StringLength(50)]
        [Required]
        public string TerritoryDescription { get; set; }
        [Required]
        public int RegionID { get; set; }
    }
}
