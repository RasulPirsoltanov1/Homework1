using abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Factory.Figure
{
    public class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Obj");
        }
    }
}
