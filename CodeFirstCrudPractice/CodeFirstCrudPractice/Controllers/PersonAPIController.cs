using CodeFirstCrudPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeFirstCrudPractice.Controllers
{
    public class PersonAPIController : ApiController
    {
        MyDatabase db = new MyDatabase();

        //api/PersonAPI/Person
        public void Post(string name, string address)
        {
            Person person = new Person();
            person.Name = name;
            person.Address = address;
            db.persons.Add(person);
            db.SaveChanges();
            //return person;
        }

  
        
    }
}
