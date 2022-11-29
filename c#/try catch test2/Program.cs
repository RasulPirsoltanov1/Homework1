try
{
	Console.Write("enter value : ");
	int a = int.Parse(Console.ReadLine());
    Console.Write("enter second value : ");
    int b = int.Parse(Console.ReadLine());
	Console.WriteLine("sum = "+(a/b));
}
catch(DivideByZeroException)
{
	Console.WriteLine("cant devide to zero!");
}
catch (OverflowException)
{
    Console.WriteLine("you overflow the int32 type value!");
}