using Microsoft.EntityFrameworkCore;
using MyProject.CQRS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.CQRS.Data
{
    public class EFCoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-T90JGBG\SQLEXPRESS;Database=CQRS-API; Trusted_Connection=True;");
        }
        public DbSet<Departments> Departments { get; set; }
    }
}
