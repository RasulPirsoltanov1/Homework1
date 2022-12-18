using Company_Db.Core.Entities;
using Company_Db.DataAccess;
using Company_Db.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Company_Db.Services
{
    public class Database
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> result = new List<Employee>();
            AppDbContext context = new AppDbContext();
            var employees = context.Employees;
            foreach (var x in employees)
            {
                Employee employee = new Employee()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Surname = x.Surname,
                    Salary = x.Salary,
                };
                result.Add(employee);
            }
            return result;
        }
        //2) GetEmployeeById() - parametr olaraq bir id qebul edecek ve
        //hemin id-li producti geriye qaytaracaq tapmasa NotFoundException qaytaracaq.
        public Employee GetEmployeeById(int Id)
        {
            AppDbContext context = new AppDbContext();
            if (context.Employees.Any(o => o.Id == Id))
            {
                var emp = context.Employees.First(id => id.Id == Id);
                Employee employee = new Employee()
                {
                    Id = emp.Id,
                    Name = emp.Name,
                    Surname = emp.Surname,
                    Salary = emp.Salary
                };
                return employee;
            }
            else
            {
                throw new NotFoundException("\n\nYour Id do not match any other ides !");
            }


        }
        //3) CreateEmployee() - yeni bir employee datasi elave edecek
        //table-a value-lari parametr olaraq alacagsiz
        public async void CreateEmployee(string name, string surname, double salary)
        {
            AppDbContext context = new AppDbContext();
            Employee emp = new Employee()
            {
                Name = name,
                Surname = surname,
                Salary = salary
            };
            await context.Employees.AddAsync(emp);
            //await context.savechngesasync() niye islemir ki ?
            context.SaveChanges();

        }
        //4) SearchEmployeeByName() - employee-leri adina gore
        //axtaracaq ve geriye employee listi qaytaracaq.
        public List<Employee> SearchEmployeeByName(string userName)
        {
            AppDbContext context = new AppDbContext();
            List<Employee> employees = new List<Employee>();
            var emps = context.Employees.Where(name => name.Name == userName);
            foreach (var employee in emps)
            {
                employees.Add(employee);
            }
            return employees;
        }
    }
}
