﻿using Microsoft.EntityFrameworkCore;

namespace LAB1
{
    internal class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; } = null;
        public ApplicationContext() { 
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=1111");
        }
    }
}
