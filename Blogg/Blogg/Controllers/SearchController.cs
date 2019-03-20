using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogg.Models;
using Blogg.ViewModels;

namespace Blogg.Controllers
{
    public class SearchController : Controller
    {
        private BlogDBContext _context;

        public SearchController(BlogDBContext context)
        {
            _context = context;
        }

        public ListViewModel Search(string input)
        {
            ListViewModel model = new ListViewModel();
            model.SearchPosts = _context.Post.Where(p => p.Header.Contains(input)).ToList();
            return model;
        }

        public IActionResult SearchedListView(ListViewModel input)
        {
            ListViewModel model = Search(input.SearchValue);
            model.Categories = _context.Category.ToList();
            return View(model);
        }

        public IActionResult SearchOnCategory(int id)
        {
            ListViewModel model = new ListViewModel();
            model.SearchPosts = _context.Post.Where(p => p.CategoryId == id).ToList();
            model.Categories = _context.Category.ToList();
            return View("SearchedListView", model);
        }
    }
}
