using GeziDunyam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeziDunyam.ViewModels
{
    public class ShowPostViewModel
    {
        public Post Post { get; set; }
        public CommentViewModel CommentViewModel { get; set; }
    }
}