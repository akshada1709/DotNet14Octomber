﻿using Microsoft.EntityFrameworkCore;
using ProductCrud.Models;

namespace ProductCrud.Services
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        {
           
        }
        public DbSet<Product> Products {  get; set; }
    }
}
