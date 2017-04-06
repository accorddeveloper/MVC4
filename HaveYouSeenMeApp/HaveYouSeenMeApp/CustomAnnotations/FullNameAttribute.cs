using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaveYouSeenMeApp.CustomAnnotations
{
    public class FullNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var name = value.ToString().Split(' ');
            //return name.Length > 1 ? true: false;
            return name.Length == 2;
        }
    }
}