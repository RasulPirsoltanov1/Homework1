using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_to_Json.Models
{
    internal class User
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public int ChildCount{ get; set; }
        public Childrens[] Childs { get; set; }
        public User()
        {
            Childs = new Childrens[this.ChildCount];
        }
    }
}
