//2.1. Vehicle class
//-Color
//- Year

using task_2_vehicile_cars;

Car newCar = new Car("Black","mersedes","gle200",2015, 82.9, 0.2,234);
newCar.ShowInfo();
Console.WriteLine();
double enoghFuel = newCar.Drive(342);
if (enoghFuel == -1)
{
    Console.WriteLine("fuel Not enough");
}
else
{
    Console.WriteLine(enoghFuel);
}
