namespace task_2_vehicile_cars
{
    //   2.2. Car class (Car classi Vehicle-den miras alir)
    //- Brand
    //- Model
    //- FuelCapacity
    //- FuelFor1Km
    //- CurrentFuel
    //- ShowInfo()
    internal class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public Car(string color, string brand, string model, int year, double fuelCapacity, double fuelFor1Km, double currentFuel) : base(color, year)
        {
            Brand = brand;
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelFor1Km = fuelFor1Km;
            CurrentFuel = currentFuel;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"color: {this.Color}| Brand : {Brand} | Model : {Model}\nYear : {Year} | Fuelcapacity : {FuelCapacity}L | fuelfor1km : {FuelFor1Km}L | Currentfuel : {CurrentFuel}L\n " );
        }
        public double Drive(double km)
        {
            if (CurrentFuel - (km * FuelFor1Km) > 0)
            {
                Console.Write("Now : ");
                return CurrentFuel - (km * FuelFor1Km);
            }
            else
            {
                return -1;
            }
        }
    }
}
