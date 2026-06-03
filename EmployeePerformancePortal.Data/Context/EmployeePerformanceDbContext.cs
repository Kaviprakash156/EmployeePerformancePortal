using EmployeePerformancePortal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EmployeePerformancePortal.Data.Context;

public class EmployeePerformanceDbContext : DbContext
{
    public EmployeePerformanceDbContext(
        DbContextOptions<EmployeePerformanceDbContext> options)
        : base(options)
    {
    }

    public DbSet<Role> Roles { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<Department> Departments { get; set; }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Role>()
            .HasIndex(x => x.RoleName)
            .IsUnique();

        modelBuilder.Entity<Employee>()
            .HasIndex(x => x.EmployeeCode)
            .IsUnique();

        modelBuilder.Entity<Employee>()
            .HasIndex(x => x.Email)
            .IsUnique();

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(EmployeePerformanceDbContext).Assembly);
    }
}