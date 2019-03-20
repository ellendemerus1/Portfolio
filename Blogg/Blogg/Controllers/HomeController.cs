using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogg.Models;
using Blogg.ViewModels;


namespace Blogg.Controllers
{
    public class HomeController : Controller
    {
        private BlogDBContext _context;

        public HomeController(BlogDBContext context)
        {
            _context = context;
        }

        public IActionResult ListView()
        {
            ListViewModel model = GetValues();
            return View(model);
        }

        public IActionResult PostDetails(int id)
        {
            Post model = _context.Post.SingleOrDefault(p => p.PostId == id);
            return PartialView("_PostDetails", model);
        }

        public ListViewModel GetValues()
        {
            ListViewModel model = new ListViewModel();
            model.Categories = _context.Category.ToList();
            model.Posts = _context.Post.OrderByDescending(p => p.Time).ToList();
            return model;
        }
    }
}
