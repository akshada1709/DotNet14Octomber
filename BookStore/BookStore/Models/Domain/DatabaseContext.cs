﻿using Microsoft.EntityFrameworkCore;

namespace BookStore.Models.Domain
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
        
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<General> Genre { get; set; }

    }
}
