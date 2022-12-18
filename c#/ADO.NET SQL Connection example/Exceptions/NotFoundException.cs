using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_SQL_Connection_example.Exceptions
{
     class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
