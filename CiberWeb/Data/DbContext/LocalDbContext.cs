using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class LocalDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly string _connectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(_connectionString))
                optionsBuilder.UseSqlServer(_connectionString);
        }
        public LocalDbContext(DbContextOptions<LocalDbContext> options) : base(options)
        {
        }
        public LocalDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public LocalDbContext()
        {
            _connectionString = ConnectionStrings.LocalDbConnectionString;
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
