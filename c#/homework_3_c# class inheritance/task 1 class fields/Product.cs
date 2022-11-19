using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1._1_class_fields
{
    internal class Product
    {
        public string name;
        public int costPirce;
        public int saledPirce;
        public Product(string name, int costPirce, int saledPirce)
        {
            this.name = name;
            this.costPirce = costPirce;
            this.saledPirce = saledPirce;
        }
    }
}
