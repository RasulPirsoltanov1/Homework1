//3 - Sahe deyə Method(lar) yaradılır.
//Çevrənin sahəsi - S = p*r² (p=3)
//Düzbucaqlının sahəsi - S = a*b
//Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p = (a + b + c) / 2
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("area of circile : "+Area(2));
        Console.WriteLine("area of rectangle : " + Area(2,32));
        Console.WriteLine("area of circile in triangular : " + AreaOfCircileInTriangle(2,3,3,2));
    }
    public static double Area(double radius)
    {
        int pi = 3;
        return pi * radius;
    }
    public static double Area(double a,double b)
    {
        return b * a;
    }
    public static double AreaOfCircileInTriangle(double radius,double a, double b,double c)
    {
        double p = (a + b + c) / 2;
        return p * radius;
    }
}
