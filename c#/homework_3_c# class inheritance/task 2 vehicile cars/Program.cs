//2.1. Vehicle class
//-Color
//- Year

using task_2_vehicile_cars;

Car newCar = new Car("White","mersedes","gle200",2018, 82.9, 0.2,75);
newCar.ShowInfo();
Console.WriteLine();
Console.Write("input distance km: ");
double km = double.Parse(Console.ReadLine());
double enoghFuel = newCar.Drive(km);
if (enoghFuel == -1)
{
    Console.WriteLine("<<fuel Not enough for this distance !");
}
else
{
    Console.WriteLine(enoghFuel+"L");
}
