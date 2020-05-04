using ef_gardening.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ef_gardening
{
    class GardeningContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source = Gardening.db");
        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
