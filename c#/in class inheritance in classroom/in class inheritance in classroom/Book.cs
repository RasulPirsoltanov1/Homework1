using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_class_inheritance_in_classroom
{
    internal class Book:Product
    {
        public string genre;
        public Book(string genre, string name, int no, int price):base(name,no,price)
        {
            this.genre = genre;
        }
    }
}
