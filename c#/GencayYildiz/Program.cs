//try
//{
//	int a = int.Parse(Console.ReadLine());
//	Console.WriteLine("the value : "+a);
//}
//catch (Exception error)
//{

//	Console.WriteLine(error.Message);
//}


class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine(Sum(123, 43));
    }
    public static int Sum(int a, int b)
    {
        return Divide(a,b)+a+b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }
}

