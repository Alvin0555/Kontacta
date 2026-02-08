using Kontacta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kontacta.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CEP1GCL\SQLSERVEREXPRESS;Database=KontactaDB;Trusted_Connection=True; TrustServerCertificate=True;");
        }
    }
}
