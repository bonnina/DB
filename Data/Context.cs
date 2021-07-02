using Microsoft.EntityFrameworkCore;
using DB.Models;

namespace DB.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Illness> Illnesses { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<Trade> Trades { get; set; }
    }
}
