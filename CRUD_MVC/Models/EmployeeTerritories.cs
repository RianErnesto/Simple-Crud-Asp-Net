using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class EmployeeTerritories
    {
        [Key]
        public int EmployeeId { get; set; }
        [StringLength(20)]
        [Required]
        public string TerritoryId { get; set; }
    }
}
