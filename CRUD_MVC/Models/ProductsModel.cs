using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class ProductsModel
    {
        [Key]
        public int ProductID { get; set; }
        [StringLength(40)]
        [Required]
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        [StringLength(20)]
        public string QuantityPerUnit { get; set; }
        public decimal UnityPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsInOrder { get; set; }
        public int ReorderLevel { get; set; }
        [Required]
        public bool Discontinued { get; set; }
    }
}
