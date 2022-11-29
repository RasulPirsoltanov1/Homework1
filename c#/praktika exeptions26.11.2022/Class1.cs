using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_exeptions26._11._2022
{
    internal class InCorrectIndex:Exception
    {
        public InCorrectIndex(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
