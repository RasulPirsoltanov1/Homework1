public class Program
{

    public static void Main(String[] args)
    {
        ShapeFactory shapeFactory = new ShapeFactory();

        //get an object of Circle and call its draw method.
        Shape shape1 = shapeFactory.getShape(Figure.CIRCLE);

        //call draw method of Circle
        shape1.draw();

        //get an object of Rectangle and call its draw method.
        Shape shape2 = shapeFactory.getShape(Figure.RECTANGLE);

        //call draw method of Rectangle
        shape2.draw();

        //get an object of Square and call its draw method.
        Shape shape3 = shapeFactory.getShape(Figure.SQUARE);

        //call draw method of square
        shape3.draw();
        //get an object of Square and call its draw method.
        Shape shape4 = shapeFactory.getShape(Figure.SQUARE);

        //call draw method of square
        shape3.draw();
    }
}
public interface Shape
{
    void draw();
}

public class Rectangle : Shape
{

    public void draw()
    {
        Console.WriteLine("Inside Rectangle::draw() method.");
    }
}


public class Square : Shape
{
    public void draw()
    {
        Console.WriteLine("Inside Square::draw() method.");
    }
}
public class Circle : Shape
{
    public void draw()
    {
        Console.WriteLine("Inside Circle::draw() method.");
    }
}

public class ShapeFactory
{

    //use getShape method to get object of type shape 
    public Shape getShape(Figure shapeType)
    {
        if (shapeType == null)
        {
            return null;
        }
        if (shapeType==(Figure.CIRCLE))
        {
            return new Circle();

        }
        else if (shapeType.Equals(Figure.RECTANGLE))
        {
            return new Rectangle();

        }
        else if (shapeType.Equals(Figure.SQUARE))
        {
            return new Square();
        }

        return null;
    }
}

public enum Figure
{
    CIRCLE,
    RECTANGLE,
    SQUARE,
}