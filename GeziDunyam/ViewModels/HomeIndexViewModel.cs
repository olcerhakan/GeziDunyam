﻿using GeziDunyam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using X.PagedList;


namespace GeziDunyam.ViewModels
{
    public class HomeIndexViewModel
    {
        public IPagedList<Post> Posts { get; set; }

        public Category Category { get; set; }

        public string SearchTerm { get; set; }
        public int? CategoryId { get; set; }
    }
}