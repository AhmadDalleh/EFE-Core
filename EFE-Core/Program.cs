
using EFE_Core;
using static EFE_Core.ApplicationDbContext;
using System.Linq;

var _context = new ApplicationDbContext();

SeedData();
static void SeedData()
{
    using var context = new ApplicationDbContext();

    //context.Database.EnsureCreated();

    //var blog = context.Blogs.FirstOrDefault(b => b.Url == "www.google.com");

    //if(blog == null)
    //    context.Blogs.Add(new Blog { Url = "www.google.com" });

    context.SaveChanges();
    
}