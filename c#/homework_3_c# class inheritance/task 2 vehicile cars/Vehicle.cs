namespace task_2_vehicile_cars
{
    internal class Vehicle
    {
        public string Color;
        public int Year = 2022;
        public Vehicle(string color, int year = 2012)
        {
            this.Color = color;
            this.Year = year;
        }
    }
}
