using Microsoft.EntityFrameworkCore;
using RentalManagementServices.Core;
using RentalManagementServices.Core.Entities;

namespace RentalManagementServices.Infrastructure.Data
{
    public class RentalDbContext : DbContext
    {
        public RentalDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<WorkerRoom> WorkerRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tenant>().HasOne<Room>(r => r.Room).WithOne(t => t.Tenant).HasForeignKey<Room>(k => k.Id);

            

        }
    }
}
