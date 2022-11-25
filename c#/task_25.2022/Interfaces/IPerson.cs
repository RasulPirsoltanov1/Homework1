using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_25._2022.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string ShowInfo();
    }
}
