using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCCrudEvidenceDemo.Controllers
{
    public class ProductApiController : ApiController
    {
        AdventureEntities db = new AdventureEntities();

        //ProductApi/Product
        public string PostProduct(ProductDescription p)
        {

            p.rowguid = Guid.NewGuid();
            p.ModifiedDate = DateTime.Now;
            db.ProductDescriptions.Add(p);
            db.SaveChanges();
            return "Success";
        }

        public List<ProductDescription> GetProduct()
        {
            return db.ProductDescriptions.ToList();
        }
    }
}