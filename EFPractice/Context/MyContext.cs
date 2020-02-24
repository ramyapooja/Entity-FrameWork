using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFPractice.Models;


namespace EFPractice.Context
{
    public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CHU7B0H\SQLEXPRESS;Initial Catalog=EFPracticeDB;User ID=sa;Password=pass@word1");

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
