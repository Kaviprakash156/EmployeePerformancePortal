using EmployeePerformancePortal.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeePerformancePortal.Data.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(x => x.RoleId);

        builder.Property(x => x.RoleName)
               .HasMaxLength(50)
               .IsRequired();

        builder.HasData(
            new Role { RoleId = 1, RoleName = "Admin" },
            new Role { RoleId = 2, RoleName = "HR" },
            new Role { RoleId = 3, RoleName = "Manager" },
            new Role { RoleId = 4, RoleName = "Employee" }
        );
    }
}