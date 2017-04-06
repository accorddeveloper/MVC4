using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HaveYouSeenMeApp.Models
{
    public class PictureViewModel
    {
        [Required]
        [Display(Name = "Picture File")]
        public HttpPostedFileBase PictureFile { get; set; }

        [Required]
        [Display(Name = "Height")]
        public int ImageHeight { get; set; }

        [Required]
        [Display(Name = "Width")]
        public int ImageWidth { get; set; }
    }
}