using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_28._11._2022.Models.Commans
{
    internal static class Compare
    {
        public static bool operator <(Compare b, Compare c)
        {
            if (b.MaxSpeed <= c.MaxSpeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Compare b, Compare c)
        {
            if (b.MaxSpeed >= c.MaxSpeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
