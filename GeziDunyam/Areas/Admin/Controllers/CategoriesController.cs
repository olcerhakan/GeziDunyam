﻿using GeziDunyam.Helpers;
using GeziDunyam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GeziDunyam.Areas.Admin.Controllers
{
    public class CategoriesController : AdminBaseController
    {
        // GET: Admin/Categories
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult New(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Slug = UrlService.URLFriendly(category.Slug);
                db.Categories.Add(category);
                db.SaveChanges();
                TempData["SuccessMessage"] = "Kategori başarıyla eklendi";
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Category category = db.Categories.Find(id);

            if (category == null)
            {
                return HttpNotFound();
            }

            return View(category);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Slug = UrlService.URLFriendly(category.Slug);
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                TempData["SuccessMessage"] = "Kategori başarıyla güncellendi.";
                return RedirectToAction("Index");
            }

            return View(db.Categories.Find(category.Id));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var category = db.Categories.Find(id);

            if (category == null)
            {
                return HttpNotFound();
            }
            if (category.Posts.Count > 0)
            {
                TempData["ErrorMessage"] = "Bu kategorinin silinmesi için içindeki yazıların silinmesi gerekir.";
                return RedirectToAction("Index");
            }
            db.Categories.Remove(category);
            db.SaveChanges();
            TempData["SuccessMessage"] = "Kategori başarıyla silindi.";
            return RedirectToAction("Index");
        }
    }
}