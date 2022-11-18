using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance_class_this
{
    internal class Student:Person
    {
        public string parent_name;
        public Student(string name,int age):base(name,age)
        {
        }
    }
}
