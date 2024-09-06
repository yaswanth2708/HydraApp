using System.Collections.Generic;
using System.Reflection.Emit;

using Microsoft.EntityFrameworkCore;
using HydraApp.Models;
namespace HydraApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Customize the model as needed
        }
    }
}
