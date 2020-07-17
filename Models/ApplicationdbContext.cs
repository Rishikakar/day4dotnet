using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace day4dotnet.Models
{
    public class ApplicationdbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3BG16TQ;user id=sa;password=rishika@;database=day4Db");
        }
        public DbSet<User> users { get; set; }

    }
}