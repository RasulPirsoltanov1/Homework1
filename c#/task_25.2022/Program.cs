//using System.Xml.Linq;
//Aşağıdakı custom exception-ı yaradın:
//-CapacityLimitException
//IPerson interface
//-Name
//- Age
//- ShowInfo() - geriyə string qaytarır.
//Employee class (IPerson interface-ni implement edir)

using task_25._2022.clasees;

Employee employeeNew = new Employee("Rasul",20,3000);
Employee employeeNew2 = new Employee("Rasul",20,3000);
Console.WriteLine(employeeNew2.ShowInfo());