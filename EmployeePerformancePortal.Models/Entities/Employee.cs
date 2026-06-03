namespace EmployeePerformancePortal.Models.Entities;

public class Employee : BaseEntity
{
    public int EmployeeId { get; set; }

    public string EmployeeCode { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public DateTime JoinDate { get; set; }

    public string Status { get; set; } = string.Empty;

    public int DepartmentId { get; set; }

    public Department Department { get; set; }

    public int? ManagerId { get; set; }
}