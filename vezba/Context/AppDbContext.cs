﻿using Microsoft.EntityFrameworkCore;
using vezba.Models;

namespace vezba.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base (options)
        {
            
        }
        public DbSet<User> users { get; set; }
    }
}
