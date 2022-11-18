using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_class_task1
{
    internal class Book:Product
    {
        public string genre;
        public Book(string genre, int no, string name, int price) :base(no,name, price)
        {

            if(genre == "false")
            {
                this.genre = "false";
            }
            else if(genre == "true")
            {
                this.genre = "true";
            }
            
        }
        public string getInfo()
        {
            if (genre=="false")
            {
                return  "dont create";
            }
            else
            {
                return $"{genre}  {no} {price} {name}";

            }
        }
    }
}
