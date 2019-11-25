using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WebNotePad.Infrastructure
{
    public class Context : DbContext
    {
        public Context(): base { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-U7TPA9V\SQLEXPRESS;User Id= sa; Password=Fuck@123;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        // entities

        DbSet<Note> Notes { get; set; }
        DbSet<Tag> Tags { get; set; }

    }
}
