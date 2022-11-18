using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_class_task1
{
    internal class Product
    {
        public int no;
        public string name;
        public int price;
        public int count;
        public Product(int no, string name, int price)
        {
            if(no == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                this.no = no;
                this.name = name;
                this.price = price;
            }
            
        }
        //public void getInfo()
        //{
        //    Console.WriteLine($"{no} {name} {price} {count} {genre}");
        //}
    }
}
