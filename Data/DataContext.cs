using Microsoft.EntityFrameworkCore;
using uni.Entities;

namespace uni.Data
{
    public class DataContext(IConfiguration configuration) : DbContext()
    {
        private readonly IConfiguration _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = _configuration.GetConnectionString("DatabaseConnection")!;
            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Student> Students { get; set; }
    }
}
