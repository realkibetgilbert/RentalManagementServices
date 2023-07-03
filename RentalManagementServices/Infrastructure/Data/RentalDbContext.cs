using Microsoft.EntityFrameworkCore;
using RentalManagementServices.Core;
using RentalManagementServices.Core.Entities;

namespace RentalManagementServices.Infrastructure.Data
{
    public class RentalDbContext : DbContext
    {
        public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options)
        {
        }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<WorkerRoom> WorkerRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.HasKey(entity => entity.Id);

                entity.Property(entity => entity.Name).IsRequired();

                entity.Property(entity => entity.PhoneNumber).IsRequired();

                entity.HasIndex(entity => entity.PhoneNumber).IsUnique(); 
                
                entity.HasOne(e=>e.Room).WithOne(e=>e.Tenant).HasForeignKey<Room>(e=>e.TenantId).OnDelete(DeleteBehavior.NoAction);  
            });


            modelBuilder.Entity<Pricing>(entity =>
            {
                entity.HasKey(entity => entity.Id);    

                entity.Property(e=>e.Amount).IsRequired();

                entity.Property(e=>e.DepositAmount).IsRequired();

            });

            modelBuilder.Entity<WorkerRoom>(entity =>
            {
                entity.HasKey(e=> new {e.WorkerId,e.RoomId});
                entity.HasOne(e=>e.Room).WithMany(e=>e.WorkerRooms).HasForeignKey(e=>e.RoomId).OnDelete(DeleteBehavior.NoAction);
                entity.HasOne(e=>e.Worker).WithMany(e=>e.WorkerRooms).HasForeignKey(e=>e.WorkerId).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(entity=>entity.Id);

                entity.HasIndex(e => e.Reference).IsUnique();

                entity.HasIndex(e => e.MpesaReference).IsUnique();

                entity.HasIndex(e => e.BankReference).IsUnique();
            });

        }
    }
}
