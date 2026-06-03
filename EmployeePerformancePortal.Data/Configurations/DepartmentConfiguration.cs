using EmployeePerformancePortal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeePerformancePortal.Data.Configurations;

public class DepartmentConfiguration
    : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(x => x.DepartmentId);

        builder.Property(x => x.DepartmentName)
               .HasMaxLength(100)
               .IsRequired();
    }
}