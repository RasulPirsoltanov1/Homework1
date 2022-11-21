using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_gencay_yildiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A test1=new B();
        }
        class A
        {
            public A()
            {
                Console.WriteLine("bu a cliasidir");
            }
        }
        class B:A
        {
            static  B()
            {
                Console.WriteLine("bu b clasidir.");
            }
        }
    }
}
