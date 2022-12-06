using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_mini_project.Exeptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {
        }
    }
}
