using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_28._11._2022.Models.Commans
{
    internal class Car : Vehicle
    {
        // Brand
        //- Model
        //- MaxSpeed
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public Car(int year, string brand, string model, int maxspeed, string color) : base(year, color)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxspeed;
        }
        public override string ShowInfo()
        {
            return $"{Year} {Brand} {Model} {MaxSpeed} {Color}";
        }
        public static bool operator >(Car b, Car c)
        {

            if (b.MaxSpeed > c.MaxSpeed)
            {
                return b.MaxSpeed > c.MaxSpeed;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Car b, Car c)
        {
            if (b.MaxSpeed < c.MaxSpeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Car b, Car c)
        {
            if (b.MaxSpeed <= c.MaxSpeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Car b, Car c)
        {
            if (b.MaxSpeed >= c.MaxSpeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
