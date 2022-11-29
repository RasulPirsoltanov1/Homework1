using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_27._11._2022
{
    public class Book
    {
        public static int Id { get; set; }
        public string Name{ get; set; }
        public Book(string name)
        {
            Name = name;
            Id++;
        }
        public override string ToString()
        {
            return Name; 
        }
    }
}
