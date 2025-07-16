using Microsoft.EntityFrameworkCore;
using SalesDashboard.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDashboard.Infrastructure.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure your entities here
            // e.g., modelBuilder.Entity<User>().ToTable("Users");
        }
        // Define DbSets for your entities
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }
        
    }
}
