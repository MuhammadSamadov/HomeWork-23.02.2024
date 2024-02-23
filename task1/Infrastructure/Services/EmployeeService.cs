using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> _employee = new List<Employee>();
    public List<Employee> GetEmployees()
    {
        return _employee;
    }
    public void AddEmployee(Employee employee)
    {
        _employee.Add(employee);
    }
    public int CountEmployee()
    {
        return _employee.Count;
    }
}
