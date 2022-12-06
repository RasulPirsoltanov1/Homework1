using Proxy_Pattern.Intervfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    internal class RealImage : IImage
    {
        public string fileName { get; set; }
        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }
        public void display()
        {
            Console.WriteLine("Displaying " + fileName);
        }
        public void loadFromDisk(string name)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}
