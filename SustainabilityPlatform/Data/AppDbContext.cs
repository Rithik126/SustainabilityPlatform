using Microsoft.EntityFrameworkCore;
using SustainabilityPlatform.Model;

namespace SustainabilityPlatform.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Appliance> Appliances { get; set; }
        public DbSet<ApplianceType> ApplianceTypes { get; set; }
        public DbSet<SensorData> SensorData { get; set; }
        public DbSet<EnergyUsage> EnergyUsages { get; set; }
        public DbSet<WaterUsage> WaterUsages { get; set; }
        public DbSet<SustainabilityScore> SustainabilityScores { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}