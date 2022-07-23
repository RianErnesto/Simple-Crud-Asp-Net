using CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC.Data
{
    public class ContextDataBase : DbContext
    {
        public ContextDataBase(DbContextOptions<ContextDataBase> options) : base(options)
        { 

        }

        public DbSet<CategoriesModel> Categories { get; set; }
        public DbSet<CustomerCustomerDemoModel> CustomerCustomerDemo { get; set; }
        public DbSet<CustomerDemographicsModel> CustomerDemographics { get; set; }
        public DbSet<CustomersModel> Customers { get; set; }
        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<EmployeeTerritoriesModel> EmployeeTerritories { get; set; }
        public DbSet<OrderDetailsModel> OrderDetails { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<RegionModel> Region { get; set; }
        public DbSet<ShippersModel> Shipper { get; set; }
        public DbSet<SuppliersModel> Supplier { get; set; }
        public DbSet<TerritoriesModel> Territory { get; set; }
    }
}
