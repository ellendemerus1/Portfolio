using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogg.ViewModels;
using Blogg.Models;

namespace Blogg.Controllers
{
    public class CreateController : Controller
    {
        private BlogDBContext _context;

        public CreateController(BlogDBContext context)
        {
            _context = context;
        }

        public IActionResult CreatePost()
        {
            ListViewModel model = new ListViewModel();
            model.Categories = _context.Category.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreatePost(Post newPost)
        {
            ListViewModel model = new ListViewModel();
            model.Categories = _context.Category.ToList();
            model.NewPost = newPost;

            if (ModelState.IsValid)
            {
                newPost.Time = DateTime.Now;
                _context.Post.Add(newPost); //Lägger in nytt inlägg i databasen
                _context.SaveChanges();

                ModelState.Clear();  //Tömmer textboxarna

                return View("ConfirmNewPost", model);
            }
            else
            {
                return View(model);
            }

        }
    }
}
