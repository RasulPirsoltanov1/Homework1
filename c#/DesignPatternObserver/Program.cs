



public interface Gamepad
{
    void PressX();
    void PressY();
    void PressZ();
    void PressD();
}

public class Defance : Gamepad
{
    public void PressD()
    {
        Console.WriteLine("topu al");
    }

    public void PressX()
    {
        Console.WriteLine("geri cekil");
    }

    public void PressY()
    {
        Console.WriteLine("topu uzaqlasdir");

    }

    public void PressZ()
    {
        Console.WriteLine("press ele");

    }
}



public class Attack : Gamepad
{
    public void PressD()
    {
        Console.WriteLine("topu at");
    }

    public void PressX()
    {
        Console.WriteLine("pas ver ");

    }

    public void PressY()
    {
        Console.WriteLine("uzun pas");

    }

    public void PressZ()
    {
        Console.WriteLine("using talent ");

    }
}
class Game
{
    private Gamepad gameStrategy;
    public Game()
    {
        Console.WriteLine("game is started.");
    }
    public void PressX()
    {
        gameStrategy.PressX();
    }
    public void PressY()
    {
        gameStrategy.PressY();
    }
    public void PressZ()
    {
        gameStrategy.PressZ();
    }
    public void PressD()
    {
        gameStrategy.PressD();
    }
    public void TopReqibde()
    {
        gameStrategy=new Defance();
    }
    public void TopSende()
    {
        gameStrategy = new Attack();
    }
}



class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.TopReqibde();
        game.PressD();
        game.TopSende();
        game.PressD();
    }
}