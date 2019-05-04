using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoshCoreCourse.Models;

namespace MoshCoreCourse.Persistence
{
    public class VegaDbContext :DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Model> Models { get; set; }

        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>()
                .HasKey(bc => new { bc.VehicleId, bc.FeatureId });  
            modelBuilder.Entity<VehicleFeature>()
                .HasOne(bc => bc.Vehicle)
                .WithMany(b => b.Features)
                .HasForeignKey(bc => bc.VehicleId);  
            modelBuilder.Entity<VehicleFeature>()
                .HasOne(bc => bc.Feature)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(bc => bc.FeatureId);
        }
    }
}
