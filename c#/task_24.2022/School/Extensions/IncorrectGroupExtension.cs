using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.IncorrectGroup
{
    internal class IncorrectGroupExtension:Exception
    {
        public IncorrectGroupExtension(string message):base(message)
        {
                
        }
    }
}
