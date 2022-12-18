
using ORM_Entitiy_Framework.Core.Entities;
using ORM_Entitiy_Framework.DataAccess;
using System.Diagnostics;

AppDbContext context = new();
Employee emp = new Employee()
{
    Name = "Rasul",
    Surname = "Pirsoltanov",
    Salary = 1321
};
Employee emp2 = new Employee()
{
    Name = "Test",
    Surname = "Testvi",
    Salary = 324
};
context.Employees.Add(emp);
context.Employees.Add(emp2);
var employees = context.Employees;
context.SaveChanges();
foreach (var x in employees)
{
    Console.WriteLine(x.Id+" : "+x.Name+" : "+x.Salary);
}