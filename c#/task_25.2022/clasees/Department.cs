using task_25._2022.exceptions;

namespace task_25._2022.clasees
{
    internal class Department
    {
        private string name;
        public static int employelimit;
        public static int Id = 0;
        public Employee[] employees = new Employee[employelimit];
        public Department(string name, int employeLimit)
        {
            Name = name;
            EmployeeLimit = employeLimit;
        }
        //- Name
        //- EmployeeLimit
        //- Employees array
        //- AddEmployee() -
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int EmployeeLimit
        {
            get
            {
                return employelimit;
            }
            set
            {
                employelimit = value;
            }
        }


        public void addemployee(string name, int age, int salary)
        {
            Id++;
            if (Id >= employelimit)
            {
                throw new CapacityLimitException("over the Employee limit");
            }
            else
            {
                this.employees[Id] = new(name, age, salary);

            }


        }
        public void getinfo()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    Console.WriteLine(employees[i].Name + " " + employees[i].Age + " " + employees[i].Salary + "  " + i);
                }
            }

        }

        public void UpdateDepartment(string newName, int newEmployeeLimit)
        {
            this.Name = newName;
            this.EmployeeLimit = newEmployeeLimit;
        }
        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }

            set
            {
                employees[index] = value;
            }
        }
    }
}
