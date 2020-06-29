
using GeziDunyam.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziDunyam.Areas.Admin.ViewModels
{
    public class EditPostViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public string CurrentFeaturedImage { get; set; }

        [Display(Name = "Oluşturulma")]
        public DateTime CreationTime { get; set; }

        [Display(Name = "Son Güncelleme")]
        public DateTime ModificationTime { get; set; }

        [PostedImage]
        public HttpPostedFileBase FeaturedImage { get; set; }

        [Required]
        [Display(Name = "Kısa Url")]
        [StringLength(200)]
        public string Slug { get; set; }
    }
}