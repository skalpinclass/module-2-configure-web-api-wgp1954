using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApi.Models
{
    public class BlogItem
    {
        public int BlogItemId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
    }
}
