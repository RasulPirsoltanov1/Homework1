using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_3_new
{
    internal class Product
    {
        public string name;
        public int num;
        public int price;
        public Product(string name, int num, int price)
        {
            this.name = name;
            this.num = num; 
            this.price = price; 
        }
    }
}
