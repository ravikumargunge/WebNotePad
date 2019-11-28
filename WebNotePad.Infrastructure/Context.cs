using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using WebNotePad.Core.Models;

namespace WebNotePad.Infrastructure
{
    public class MyApplicationDbContext : DbContext
    {
        public MyApplicationDbContext(DbContextOptions options) : base(options){ 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FRVPCX230;Initial Catalog=WebNotePad;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        // entities

        DbSet<Note> Notes { get; set; }
        DbSet<Tag> Tags { get; set; }

    }
}
