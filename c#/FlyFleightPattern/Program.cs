using System;
using System.Collections.Generic;
namespace Flyweight.Structural
{
    /// <summary>
    /// Flyweight Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Arbitrary extrinsic state
            int extrinsicstate = 22;
            FlyweightFactory factory = new FlyweightFactory();
            // Work with different flyweight instances
            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(extrinsicstate);
            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(extrinsicstate);
            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(extrinsicstate);
            UnsharedConcreteFlyweight fu = new
                UnsharedConcreteFlyweight();
            fu.Operation(extrinsicstate);
            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights { get; set; } = new Dictionary<string, Flyweight>();
        // Constructor
        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }
        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight)flyweights[key]);
        }
    }
    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
    /// <summary>
    /// The 'UnsharedConcreteFlyweight' class
    /// </summary>
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
                extrinsicstate);
        }
    }
}