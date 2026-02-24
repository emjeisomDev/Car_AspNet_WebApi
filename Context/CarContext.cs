using CarTest.Entity;
using Microsoft.EntityFrameworkCore;

namespace CarTest.Context
{
    public class CarContext : DbContext
    {

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Truck> Trucks { get; set; }
                
        public CarContext(DbContextOptions<CarContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===============================
            // VEHICLE
            // ===============================
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.HasKey(v => v.Id);

                entity.Property(v => v.Manufacturer)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(v => v.Model)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(v => v.Year)
                      .IsRequired();

                entity.Property(v => v.Color)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(v => v.VehicleType)
                      .HasConversion<string>()
                      .IsRequired()
                      .HasMaxLength(20);
                      
            });

            // ===============================
            // CAR (TPT)
            // ===============================
            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.HasKey(c => c.Vehicle_id);

                entity.Property(c => c.DoorsQuantity)
                      .IsRequired();

                entity.HasOne(c => c.Vehicle)
                      .WithOne(v => v.Car)
                      .HasForeignKey<Car>(c => c.Vehicle_id)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ===============================
            // MOTORCYCLE (TPT)
            // ===============================
            modelBuilder.Entity<Motorcycle>(entity =>
            {
                entity.ToTable("Motorcycle");

                entity.HasKey(m => m.Vehicle_id);

                entity.Property(m => m.HasElectricStart)
                      .IsRequired();

                entity.HasOne(m => m.Vehicle)
                      .WithOne(v => v.Motorcycle)
                      .HasForeignKey<Motorcycle>(m => m.Vehicle_id)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // ===============================
            // TRUCK (TPT)
            // ===============================
            modelBuilder.Entity<Truck>(entity =>
            {
                entity.ToTable("Truck");

                entity.HasKey(t => t.Vehicle_id);

                entity.Property(t => t.LoadCapacity)
                      .IsRequired()
                      .HasColumnType("decimal(10,2)");

                entity.HasOne(t => t.Vehicle)
                      .WithOne(v => v.Truck)
                      .HasForeignKey<Truck>(t => t.Vehicle_id)
                      .OnDelete(DeleteBehavior.Cascade);
            });







        }


    }
}
