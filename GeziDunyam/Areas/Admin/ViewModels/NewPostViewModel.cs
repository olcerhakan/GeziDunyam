using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeziDunyam.Helpers;

namespace GeziDunyam.Areas.Admin.ViewModels
{
    public class NewPostViewModel
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public string PhotoPath { get; set; }
        [PostedImage]
        public HttpPostedFileBase FeaturedImage { get; set; }

        [Required]
        [Display(Name = "Kısa Url")]
        [StringLength(200)]
        public string Slug { get; set; }
    }
}