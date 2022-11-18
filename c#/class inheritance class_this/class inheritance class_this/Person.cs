using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance_class_this
{
    internal class Person
    {
        public string name;
        public int age;
        public string surname;
        public Person person;
        public Person()
        {
            this.surname = "Pirsoltanov";
        }
        public Person(string name):this()
        {
            this.name = name;
        }
        public Person(string name,int age):this(name)
        {
            this.age = age; 
        }
        public string Info()
        {
            return $"{this.name} {this.age} {this.surname}";
        }
    }
}
