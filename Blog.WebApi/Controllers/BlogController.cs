using Blog.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private BlogContext blogContext;

        public BlogController (BlogContext blogContext)
        {
            this.blogContext = blogContext;
        }
        
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<BlogItem>> Get()
        {
            return this.blogContext.BlogItems
                .Include(p => p.BlogPosts).ToList<BlogItem>();

        }

        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        public void Post([FromBody] BlogItem value)
        {
            this.blogContext.Add(value);
            this.blogContext.SaveChanges();
        }

        [HttpPut("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(200)]
        public void Put(int id, [FromBody] BlogItem value)
        {
            var blogItem = this.blogContext
                .BlogItems.Where(x => x.BlogItemId == id)
                .Include(p => p.BlogPosts)
                .FirstOrDefault();
            blogItem.Url = value.Url;
            blogItem.Rating = value.Rating;

            if (value.BlogPosts != null)
            {
                foreach (var p in value.BlogPosts)
                {
                    var blogPost = blogItem.BlogPosts.Where(x => x.BlogPostId == p.BlogPostId).FirstOrDefault();
                    if (blogPost != null)
                    {
                        blogPost.Content = p.Content;
                        blogPost.Title = p.Title;
                    };
                }
            }
            
            this.blogContext.BlogItems.Update(blogItem);
            this.blogContext.SaveChanges();
            //throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        public void Delete(int id)
        {
            var blogItem = this.blogContext
                .BlogItems.Where(x => x.BlogItemId == id).FirstOrDefault();
            if (blogItem == null)
                return;

            this.blogContext.BlogItems.Remove(blogItem);
            this.blogContext.SaveChanges();
        }
        
    }
}