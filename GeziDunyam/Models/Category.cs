using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeziDunyam.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public virtual ICollection<Post>  Posts{ get; set; }

        [Required]
        [Display(Name = "Short Url")]
        public string Slug { get; set; }
    }
}