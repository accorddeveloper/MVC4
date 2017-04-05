using MvcWebApiCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcWebApiCrud.Controllers
{

    public class SupplierApiController : ApiController
    {
        MyContext db = new MyContext();
        // api/Supplier
        public void Post(Supplier s)
        {
            db.Suppliers.Add(s);
            db.SaveChanges();
        }

        public void Put(Supplier s)
        {
            var currentSupplier = db.Suppliers.FirstOrDefault(x => x.ID == s.ID);
            currentSupplier.Name = s.Name;
            currentSupplier.Email = s.Email;
            db.SaveChanges();
        }
        public void Delete(Supplier s)
        {
            var currentSupplier = db.Suppliers.FirstOrDefault(x => x.ID == s.ID);
            db.Suppliers.Remove(currentSupplier);
            db.SaveChanges();
        }
        // api/Supplier
        public List<Supplier>  Get()
        {
            return db.Suppliers.ToList();
        }
    }
}
