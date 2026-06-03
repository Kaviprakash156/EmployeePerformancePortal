namespace EmployeePerformancePortal.Models.Entities;

public class Department : BaseEntity
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = string.Empty;

    public ICollection<Employee> Employees { get; set; }
        = new List<Employee>();
}