using Domain.Models;

namespace Infrastructure.Services;

public class DepartmentService
{
    List<Department> _department = new List<Department>();
    public List<Department> GetDepartments()
    {
        return _department;
    }
    public void AddDepartment(Department department)
    {
        _department.Add(department);
    }
    public int CountDepartment()
    {
        return _department.Count;
    }
}
