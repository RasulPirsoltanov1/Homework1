//using System.Xml.Linq;
//Aşağıdakı custom exception-ı yaradın:
//-CapacityLimitException
//IPerson interface
//-Name
//- Age
//- ShowInfo() - geriyə string qaytarır.
//Employee class (IPerson interface-ni implement edir)

using task_25._2022.clasees;
using task_25._2022.exceptions;

Employee employeeNew = new Employee("Rasul", 20, 3000);
Employee employeeNew2 = new Employee("Rasul", 20, 3000);
Console.WriteLine(employeeNew2.ShowInfo());
Console.Write("enter Limit of employees : ");
try
{
    int employelimit = int.Parse(Console.ReadLine());
    Department newDepartment = new Department("Rasul", employelimit);
    newDepartment.addemployee("rasul", 20, 3000);
    newDepartment.addemployee("rasul", 24, 4000);
    newDepartment.addemployee("rasul", 24, 4000);
    newDepartment.employees[0].Name = "fasdk";
    //updateDepartment
    newDepartment.UpdateDepartment("Kitabxana1", 4);
    //Indexer 
    Console.WriteLine("INdexer result = " + newDepartment[0]);
    newDepartment.getinfo();
}
catch (CapacityLimitException ex)
{
    Console.WriteLine(ex.Message);
}


//Console.WriteLine(newDepartment.);