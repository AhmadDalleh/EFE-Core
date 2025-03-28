using EFE_Core.Dtos;
using EFE_Core.Models;
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
            options.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFE_Core;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(b =>b.Posts)
                .WithOne(p => p.Blog)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Blog>()
                .Property(b => b.AddeOn)
                .HasDefaultValueSql("GETUTCDATE()");

            modelBuilder.Entity<Author>()
               .HasOne(author => author.Nationality)
               .WithMany(nationality => nationality.Authors)
               .HasForeignKey(author => author.NationalityId);

            modelBuilder.Entity<Book>()
                .HasOne(book => book.Author)
                .WithMany(author => author.Books)
                .HasForeignKey(book => book.AuthorId);
            modelBuilder.Entity<BookDto>(e => { e.HasNoKey().ToView(null);});

                
        }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookDto> BookDto { get; set; }
    }
}