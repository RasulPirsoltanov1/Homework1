public class Program
{
    public static void Main(string[] args)
    {
        Students sagird1 = new Students();
        System.Console.WriteLine(sagird1.name);
    }
}

class Students
{
    public string name;
    public string surname;
    public int age;
}