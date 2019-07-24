using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebApi.Models
{
    public class BlogContext : DbContext
    {
        // TODO: May use later
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=GEORGEH-PC;Database=Blogging;Integrated Security=true");
        //}
        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
