using Microsoft.AspNet.Identity;
using GeziDunyam.Areas.Admin.ViewModels;
using GeziDunyam.Helpers;
using GeziDunyam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziDunyam.Areas.Admin.Controllers
{
    public class PostsController : AdminBaseController
    {
        
            public ActionResult New()
            {
                ViewBag.CategoryId = new SelectList(db.Categories.OrderBy(x => x.CategoryName).ToList(), "Id", "CategoryName");
                return View();
            }

            [HttpPost, ValidateAntiForgeryToken]
            public ActionResult New(NewPostViewModel vm)
            {
                if (ModelState.IsValid)
                {
                    Post post = new Post
                    {
                        CategoryId = vm.CategoryId,
                        Title = vm.Title,
                        Content = vm.Content,
                        AuthorId = User.Identity.GetUserId(),
                        Slug = UrlService.URLFriendly(vm.Title),
                        CreationTime = DateTime.Now,
                        ModificationTime = DateTime.Now,
                        PhotoPath = ""
                    };
                    db.Posts.Add(post);
                    db.SaveChanges();

                    // todo: Posts/Index'e yönlendir
                    return RedirectToAction("Index", "Dashboard");
                }

                ViewBag.CategoryId = new SelectList(db.Categories.OrderBy(x => x.CategoryName).ToList(), "Id", "CategoryName");
                return View();
            }
        
    }
}