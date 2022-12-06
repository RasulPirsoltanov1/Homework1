using Proxy_Pattern.Intervfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    internal class ProxyImage : IImage
    {
        public RealImage realImage { get; set; }
        public string fileName;
        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }
        public void display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.display();
        }
    }
}
