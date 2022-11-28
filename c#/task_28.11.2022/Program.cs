//Program class-ında bir Vehicle tipindən bir array yaradılsın və içi Car və Bus obyektlərilə doldurulsun

using task_28._11._2022.Models.Commans;

Car newCar1 = new Car(2012, "mersedes", "gle200", 236, "brown");
Car newCar2 = new Car(2032, "Lada", "07", 236, "green");
Buss newBus1 = new Buss(2001, 60, "red");
Buss newBus2 = new Buss(2089, 650, "blue");

Vehicle[] vehicless = new Vehicle[] { newBus1, newCar1, newBus2, newCar2 };
foreach (Vehicle v in vehicless)
{
    Console.WriteLine(v.ShowInfo());
}
Console.WriteLine(newCar1 > newCar2);
