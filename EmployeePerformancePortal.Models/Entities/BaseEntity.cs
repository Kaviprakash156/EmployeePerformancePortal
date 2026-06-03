namespace EmployeePerformancePortal.Models.Entities;

public abstract class BaseEntity
{
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public DateTime? ModifiedDate { get; set; }

    public bool IsDeleted { get; set; }
}