using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Diagnostics.CodeAnalysis;
using tester.Models;

namespace tester.Data
{
    public class ApplicationDbContext : DbContext
    {

        protected readonly IConfiguration Configuration;
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration)
            : base(options)
        {
           Configuration = configuration;
       }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = Configuration.GetConnectionString("CarConnection");
            // options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                     "Server=127.0.0.1;Port=3306;Database=CarValetDB;User=root;Password=Password;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarModel>().ToTable("Car");
            modelBuilder.Entity<CustomerModel>().ToTable("Customer");

        }

        public DbSet<CarModel> CarModel { get; set; }
        public DbSet<CustomerModel> CustomerModel { get; set; }


    }
}

