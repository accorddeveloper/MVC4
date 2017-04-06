using HaveYouSeenMeApp.CustomAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaveYouSeenMeApp.Models
{
    public class MessageModel
    {
        [Required(ErrorMessage ="Enter your name")]
        [FullName(ErrorMessage ="Your name should be two part")]
        public string From { get; set; }

        [Required(ErrorMessage = "Enter your email address")]
        [EmailAddress(ErrorMessage ="Email is not valid")] 
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your subject")]
        [StringLength(10, ErrorMessage ="Subject cannot be more than 10 character")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Enter your message")]
        [StringLength(250, ErrorMessage = "Subject cannot be more than 10 character")]
        public string Message { get; set; }
    }
}