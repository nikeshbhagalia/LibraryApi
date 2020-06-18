using LibraryApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LibraryApi.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public void Seed()
        {
            if (!this.Books.Any())
            {
                this.Books.Add(
                    new Book
                    {
                        Id = Guid.NewGuid(),
                    }
                );

                this.SaveChanges();
            }
        }
    }
}
