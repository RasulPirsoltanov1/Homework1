using System.Diagnostics.Contracts;

class Program
{
    public static void Main(string[] args)
    {
        Thread newThead1 = new(method1);
        Thread newThead2 = new(method2);
        newThead1.Start();
        newThead2.Start();
    }
    public static void method1()
    {
        for(int i = 0; i < 100; i++)
        {
            Console.WriteLine($"Method1 : {i}");
            Thread.Sleep(100);
        }
    }
    public static void method2()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"Method2 : {i}");
            Thread.Sleep(100);
        }
    }
}