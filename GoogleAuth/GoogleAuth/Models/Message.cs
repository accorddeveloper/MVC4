using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleAuth.Models
{
    public class Message
    {
        [AllowHtml]
        public string Test { get; set; }
    }
}