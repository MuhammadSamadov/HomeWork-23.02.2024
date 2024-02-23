

using Domain.Models;
using Infrastructure.Services;

var  emp1 = new Employee();
emp1.FirstName="Muahammad";
emp1.LastName="Samadov";
emp1.BirthDate= new DateTime(2006,02,04);
emp1.Salary=5000;
var  emp2 = new Employee();
emp2.FirstName="Alexandr";
emp2.LastName="Pushkin";
emp2.BirthDate= new DateTime(1799,06,06);
emp2.Salary=100;

var empService = new EmployeeService();
empService.AddEmployee(emp1);
empService.AddEmployee(emp2);

var dep1 = new Department();
dep1.Name="IT";
dep1.Description="The best programmer";

var dep2 = new Department();
dep2.Name="Poet";
dep2.Description="Good poet";
var depService = new DepartmentService();
depService.AddDepartment(dep1);
depService.AddDepartment(dep2);
System.Console.Write("Count of Employee - ");
System.Console.WriteLine(empService.CountEmployee());
System.Console.Write("Count of Department - ");
System.Console.WriteLine(depService.CountDepartment());
System.Console.WriteLine("--------------------");
foreach (var item in empService.GetEmployees())
{
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine(item.BirthDate);
    System.Console.WriteLine("--------------------");
}
foreach (var item in depService.GetDepartments())
{
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
    System.Console.WriteLine("--------------------");
}
