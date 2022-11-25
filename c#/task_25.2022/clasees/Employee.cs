using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_25._2022.Interfaces;

namespace task_25._2022.clasees
{

    internal class Employee : IPerson
    {
        private static int id;
        private  int age;
        private  string name;
        private  int salary;
        public int Salary { get; set; }
        public int Id { get;  }
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
        public int Age
        {
            get
            {
                return age;
            }
            set { age = value; }
        }

        public string ShowInfo()
        {
            return $"{Name} {Age} {Salary} {Id}";
        }
        //Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Employeee obyekt yaradıldıqda avtomatik bir vahid artacaq.
        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            id++;
            Id = id;
            Salary = salary;
        }
        //ShowInfo methodunu implement etdikdə employee-nin bütün məlumatlarını geriyə qaytarmalıdı.
        //ToString methodunu override edin və içində ShowInfo methodunu geriyə qaytarın.
        public override string ToString()
        {
            return ShowInfo();
        }

    }

}
