using abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Factory.Figure
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square Obj");
        }
    }
}
