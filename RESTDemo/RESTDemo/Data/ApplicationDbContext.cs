﻿using Microsoft.EntityFrameworkCore;
using RESTDemo.Models;

namespace RESTDemo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }

        public DbSet<Book>Books { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
