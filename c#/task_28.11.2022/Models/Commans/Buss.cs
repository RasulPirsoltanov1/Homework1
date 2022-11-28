using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_28._11._2022.Models.Commans
{
    internal class Buss : Vehicle
    {
        public int PassangerCount { get; set; }
        public Buss(int year,int passengercount,string color) : base(year,color)
        {
            PassangerCount = passengercount;
        }
        public override string ShowInfo()
        {
            return $"{Year}  {PassangerCount} {Color}";
        }
    }
}
