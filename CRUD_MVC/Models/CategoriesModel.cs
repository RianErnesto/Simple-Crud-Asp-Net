using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class CategoriesModel
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(15)]
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
