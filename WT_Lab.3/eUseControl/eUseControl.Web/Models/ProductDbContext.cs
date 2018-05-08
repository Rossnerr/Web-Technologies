using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eUseControl.BusinessLogic.DBModel;

namespace eUseControl.Web.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("name=eUseControl")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        //public DbSet<Country> Countries { get; set; }
        //public DbSet<Picture> Pictures { get; set; }*/
    }
}