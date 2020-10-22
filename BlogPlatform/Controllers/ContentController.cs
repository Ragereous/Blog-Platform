﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Microsoft.AspNetCore.Mvc;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }

        public ViewResult Index()
        {
            var model = contentRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = contentRepo.GetById(id);

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreateByCategoryId(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Content content)
        {
            content.PublishDate = DateTime.Now.ToString("MM/dd/yyyy");

            if (ModelState.IsValid)
            {
                contentRepo.Create(content);
                return RedirectToAction("");
            }
            return View(content);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Content model = contentRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Content content)
        {
            if (ModelState.IsValid)
            {
                contentRepo.Update(content);
                return RedirectToAction();
            }
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Content model = contentRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Content content)
        {
            contentRepo.Delete(content);
            return RedirectToAction("");
        }
    }
}
