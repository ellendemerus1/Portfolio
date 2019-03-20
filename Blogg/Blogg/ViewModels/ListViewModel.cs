using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Blogg.Models;
using System.ComponentModel.DataAnnotations;

namespace Blogg.ViewModels
{
    public class ListViewModel
    {
        public Post NewPost;

        public List<Post> Posts { get; set; }
        public List<Category> Categories { get; set; }

        [DisplayName("Sök inlägg: ")]
        public string SearchValue { get; set; }
        public List<Post> SearchPosts { get; set; }

        public ListViewModel()
        {
            NewPost = new Post();
            Posts = new List<Post>();
            Categories = new List<Category>();
            SearchPosts = new List<Post>();
        }
    }
}
