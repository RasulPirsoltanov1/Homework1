using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_28._11._2022.Models.Commans
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }

        public abstract string ShowInfo();
        public Vehicle(int year,string color)
        {
            Color = color;
            Year = year;
        }
    }
}
  