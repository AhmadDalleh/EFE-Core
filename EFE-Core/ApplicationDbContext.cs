using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFE_Core
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFE_Core;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
               .HasOne(author => author.Nationality)
               .WithMany(nationality => nationality.Authors)
               .HasForeignKey(author => author.NationalityId);

            modelBuilder.Entity<Book>()
                .HasOne(book => book.Author)
                .WithMany(author => author.Books)
                .HasForeignKey(book => book.AuthorId);

                
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string? Url { get; set; }

        public List<Post>? Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
    }

    public class Stock
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public string? Sector { get; set; }
        public string? Industry { get; set; }
        public string? Balance { get; set; }


    }
    public class Nationality
    {
        public int NationalityId { get; set; }
        public string? Name { get; set; }

        public List<Author>? Authors { get; set; }

    }

    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }

        public int NationalityId { get; set; }

        public Nationality? Nationality { get; set; }
        public List<Book>? Books { get; set; }
    }
}