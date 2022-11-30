using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_27._11._2022
{
    public class Library
    {
        public string Name{ get; set; }
        public Book[] books;
        public Library(string name)
        {
            Name = name;
            this.books = new Book[100];
        }
        public Book this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }
    }
}
