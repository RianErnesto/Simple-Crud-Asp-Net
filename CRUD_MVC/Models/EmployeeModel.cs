using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_MVC.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }
        [StringLength(20)]
        [Required]
        public string LastName { get; set; }
        [StringLength(10)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(30)]
        [Required]
        public string Title { get; set; }
        [StringLength(25)]
        public string TitleOfCourtesy { get; set; }
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime HireDate { get; set; }
        [StringLength(60)]
        public string Address { get; set; }
        [StringLength(15)]
        public string City { get; set; }
        [StringLength(15)]
        public string Region { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(15)]
        public string Country { get; set; }
        [StringLength(24)]
        public string HomePhone { get; set; }
        [StringLength(4)]
        public string Extension { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
    }
}
