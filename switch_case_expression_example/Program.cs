#region switch case type
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int a = 0;
//string n = a switch
//{
//    int c when c > 0 => "musbetdir",
//    int c when c < 0 => "menfi",
//    _ => "default"
//};
//Console.WriteLine(n);
#endregion

#region methods

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(getName("Rasul", "Pirsoltanov", 20)); 
//    }
//    public static string getName(string name,string surname)
//    {
//        return $"{name}.{surname}";
//    }
//    public static string getName(string name,string surname,int age)
//    {
//        return $"{getName(name, surname)} yas : {age}";
//    }
//}

#endregion

#region reference value types
class Program
{
    public static void Main(string[] args)
    {
        int a = 4;
        Console.WriteLine("old : "+a);
        Change(ref a);
        Console.WriteLine("then : " + a);
    }
    public static void Change(ref int a)
    {

    }
}
#endregion