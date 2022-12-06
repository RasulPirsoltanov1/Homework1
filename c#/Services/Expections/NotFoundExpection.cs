using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Expections
{
    public sealed class NotFoundExpection:Exception
    {
        public NotFoundExpection():base("Not Found!")
        {


        }
        public NotFoundExpection(string message) : base(message)
        {


        }

    }
}
