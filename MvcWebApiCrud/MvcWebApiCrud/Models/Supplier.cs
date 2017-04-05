using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcWebApiCrud.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class MyContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }
    }
}