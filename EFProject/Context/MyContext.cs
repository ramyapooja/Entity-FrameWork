using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFProject.Models;


namespace EFProject.Context
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CHU7B0H\SQLEXPRESS;Initial Catalog=EFProject1DB;User ID=sa;Password=pass@word1");

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
