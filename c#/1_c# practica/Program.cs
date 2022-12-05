
using System.Diagnostics.CodeAnalysis;

class Program
{
    public static void Main(string[] args)
    {
        area test = new area();
        test.calcarea(new circle());
        test.calcarea(new rectangle());
    }
}


public class area
{
    public void calcarea(Ifigure type)
    {
        type.calc();
    }
}


public class circle : Ifigure
{
    public void calc()
    {
        Console.WriteLine("circle");
    }
}

public interface Ifigure
{
    public void calc();

}
public interface IfigureSum
{
    public void figureSum();

}
public class rectangle : Ifigure, IfigureSum
{
    public void calc()
    {
        Console.WriteLine("rectangle");
    }

    public void figureSum()
    {
        throw new NotImplementedException();
    }
}