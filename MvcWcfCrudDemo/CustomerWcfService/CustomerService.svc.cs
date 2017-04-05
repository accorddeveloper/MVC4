using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CustomerWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomer
    {
        public void Delete(string Id)
        {
            using (MyDbContext db = new MyDbContext())
            {
                int _id = Convert.ToInt32(Id);
                var cust = db.Customers.FirstOrDefault(x => x.ID == _id);
                db.Customers.Remove(cust);
                db.SaveChanges();
            }
        }

        public List<Customer> GetCustomer()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return db.Customers.ToList();
                
            }
        }

        public void Save(Customer obj)
        {
            using (MyDbContext db = new MyDbContext ())
            {
                if(obj.ID > 0)
                {
                    var currentCust = db.Customers.FirstOrDefault(x => x.ID == obj.ID);
                    currentCust.Email = obj.Email;
                    currentCust.Name = obj.Name;
                    db.SaveChanges();
                }
                else
                {
                    db.Customers.Add(obj);
                    db.SaveChanges();
                }
                
            }
        }
    }
}
