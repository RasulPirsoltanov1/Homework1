using Company_Db.DataAccess;
using Company_Db.Exceptions;
using Company_Db.Services;

Database DB = new Database();
foreach(var data in DB.GetAllEmployees())
{
    Console.WriteLine(data.Id + " " + data.Name + " " + data.Surname + " " + data.Salary);
}


try
{
    Console.WriteLine("\nSelected EmployeeName = " + DB.GetEmployeeById(22).Name);
}
catch (NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("\n\nCreate new Employee ");
Console.Write("enter name= ");
string name=Console.ReadLine();
Console.Write("enter surnmae = ");
string surname = Console.ReadLine();
Console.Write("salary = ");
double salary =double.Parse(Console.ReadLine());
DB.CreateEmployee(name, surname, salary);
Console.WriteLine("\n\n\n");
foreach (var data in DB.GetAllEmployees())
{
    Console.WriteLine(data.Id + " " + data.Name + " " + data.Surname + " " + data.Salary);
}

Console.WriteLine("\n\n search name : ");
string searchName=Console.ReadLine();   
foreach(var data in DB.SearchEmployeeByName(searchName))
{
    Console.WriteLine(" id : " + data.Id+" name : " + data.Name+ " surname : "+data.Surname+ " salary : "+data.Salary);
}
