using abstract_Factory.Factories;
using abstract_Factory.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        AbstractFactory shapeFactory = FactoryProducer.getFactory(true);
        //get an object of Shape Rectangle
        IShape shape1 = shapeFactory.getShape("rectangle");
        shape1.Draw();
    }
}