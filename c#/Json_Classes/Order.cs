using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Classes
{
    internal class Order
    {
        public int Id { get; set; }
        public List<OrderProduct> Items { get; set; }
        public Order()
        {
            Items = new List<OrderProduct>();
        }
    }
}
