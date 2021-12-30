using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AK_HighSchool_App.Models;

namespace AK_HighSchool_App._AppDbContext
{
    class AbbDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>

          options.UseSqlServer(@"Data Source=ALAA;Initial Catalog=AlaaHighSchool;Integrated Security=True");

        public DbSet<student> Students { get; set; }
        public DbSet<teacher> Teachers { get; set; }
        public DbSet<subject> Subjects { get; set; }
        public DbSet<Relation> Relations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Seed();
        }
    }
}
