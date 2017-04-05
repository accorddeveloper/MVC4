using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstCrudPractice.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class MyDatabase: DbContext
    {
        public DbSet<Person> persons { get; set; }
    }
}