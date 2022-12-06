using Proxy_Pattern;
using Proxy_Pattern.Intervfaces;
using static System.Net.Mime.MediaTypeNames;

public class ProxyPatternDemo
{

    public static void Main(string[] args)
    {
        IImage image = new ProxyImage("test_10mb.jpg");

        //image will be loaded from disk
        image.display();
        Console.WriteLine("");

        //image will not be loaded from disk
        image.display();
    }
}  