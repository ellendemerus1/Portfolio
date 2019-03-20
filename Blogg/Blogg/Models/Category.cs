using System;
using System.Collections.Generic;

namespace Blogg.Models
{
    public partial class Category
    {
        public Category()
        {
            Post = new HashSet<Post>();
        }

        public string CategoryName { get; set; }
        public int CategoryId { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
