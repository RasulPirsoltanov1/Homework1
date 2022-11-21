using System;

namespace dotNet_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cats pisik = new Cats();
            pisik.count = 12;
            pisik.getName();
        }
    }
    public class Cats : Animals
    {
        public void getName()
        {
            Console.WriteLine(count);
        }
    }
    public class Animals
    {
        public int count;
    }
}
