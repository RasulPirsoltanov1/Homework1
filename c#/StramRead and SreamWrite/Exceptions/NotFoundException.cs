using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StramRead_and_SreamWrite.Exceptions
{
    internal class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)   
        {

        }
    }
}
