using ADO.NET_SQL_Connection_example.Exceptions;
using ADO.NET_SQL_Connection_example.Models;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

string query = @"Data Source=DESKTOP-O87JGVH\SQL_SERVER;Initial Catalog=Company;Trusted_Connection=True;";

//1) GetAllEmployees() - geriye employee listi qaytaracaq.
List<Employee> GetAllEmployees()
{
    using (SqlConnection connection = new SqlConnection(query))
    {
        connection.Open();
        List<Employee> employees = new List<Employee>();
        string sql = "Select * from Employee";
        SqlCommand command = new SqlCommand(sql, connection);
        SqlDataReader Data = command.ExecuteReader();
        //Console.WriteLine("| Id: " + "| Name: " + " | Surname: " + " | Salary: " + " |");
        while (Data.Read())
        {
            Employee emp = new Employee();
            emp.Id = (int)Data["Id"];
            emp.Name = (string)Data["Name"];
            emp.Surname = (string)Data["Surname"];
            emp.Salary = (int)Data["Salary"];
            employees.Add(emp);
        }
        connection.Dispose();
        return employees;
    }

}

List<Employee> employees = GetAllEmployees();

Console.WriteLine("GetAllEmployees start");
foreach (Employee emp in employees)
{
    Console.WriteLine(emp.Id + "  " + emp.Name + "  " + emp.Surname + "  " + emp.Salary);
}


//2) GetEmployeeById() - parametr olaraq bir id qebul edecek
//ve hemin id-li producti geriye qaytaracaq tapmasa NotFoundException qaytaracaq.



Console.WriteLine("\n\n\nGetEmployeeById start");
Employee GetEmployeeById(int searchId)
{
    using (SqlConnection connection = new SqlConnection(query))
    {
        connection.Open();
        string command = "Select * from Employee where Id =@id;";
        SqlCommand sqlCommand = new SqlCommand(command, connection);
        sqlCommand.Parameters.AddWithValue("@id", searchId);
        SqlDataReader data = sqlCommand.ExecuteReader();

        data.Read();
        if (data.HasRows)
        {
            Employee emp = new Employee();
            emp.Id = (int)data[0];
            emp.Name = (string)data[1];
            emp.Surname = (string)data[2];
            emp.Salary = (int)data[3];
            return emp;
        }
        else
        {
            throw new NotFoundException("Data not found");
        }
    }
}
try
{
    Console.WriteLine(GetEmployeeById(4132).Name);
}
catch (NotFoundException ex)
{

    Console.WriteLine(ex.Message);
}


//3) CreateEmployee() - yeni bir employee datasi
//elave edecek table-a value-lari parametr olaraq alacagsiz

Console.WriteLine("\n\n\nCreateEmployee start");
void CreateEmployee(string name, string surname, int salary)
{
    using (SqlConnection conn = new SqlConnection(query))
    {
        conn.Open();
        string sqlCommand = "Insert into Employee values(@Name,@Surname,@Salary)";
        SqlCommand command = new SqlCommand(sqlCommand, conn);
        command.Parameters.AddWithValue("@Name", name);
        command.Parameters.AddWithValue("@Surname", surname);
        command.Parameters.AddWithValue("@Salary", salary);
        command.ExecuteNonQuery();
    }
}

CreateEmployee("test", "testtov", 432);


Console.WriteLine("\n\nCreateEmployee start");
foreach (Employee emp in employees)
{
    Console.WriteLine(emp.Id + "  " + emp.Name + "  " + emp.Surname + "  " + emp.Salary);
}



//4) SearchEmployeeByName() - employee - leri adina
//gore axtaracaq ve geriye employee listi qaytaracaq.


List<Employee> SearchEmployeeByName(string name)
{
    List<Employee> emp = new List<Employee>();
    using (SqlConnection connection = new SqlConnection(query))
    {
        connection.Open();
        string sqlCommand = "select * from Employee where Name=@name ";
        SqlCommand command = new SqlCommand(sqlCommand, connection);
        command.Parameters.AddWithValue("@name",name);
        SqlDataReader data = command.ExecuteReader();
        while (data.Read())
        {
            Employee employee = new Employee();
            employee.Id = (int)data[0];
            employee.Name = (string)data[1];
            employee.Surname = (string)data[2];
            employee.Salary = (int)data[3];
            emp.Add(employee);
        }
        connection.Dispose();
        return emp;

    }
}


Console.WriteLine("\n\nSearchEmployeeByName start");

List<Employee> GetEmployees = new List<Employee>();
GetEmployees = SearchEmployeeByName("Rasul");
foreach (Employee emp in GetEmployees)
{
    Console.WriteLine(emp.Id + "  " + emp.Name + "  " + emp.Surname + "  " + emp.Salary);
}