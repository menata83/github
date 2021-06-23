
namespace Data
{
    using country;
    using Microsoft.EntityFrameworkCore;
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Excursion> Excursions { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Extra> Extras { get; set; } 
        public DbSet<TransportExtra> TransportExtra { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server = localhost\MSSQLSERVER
            //Database = ExcursionProject
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER;Database=ExcursionProject;Trusted_Connection=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
