// Task 1:
// - Havanın temperaturu verilir. Əgər temperatur 15 - dən kiçikdirsə ekrana yazılsın "Hava soyuqdur", 15 - dən böyükdürsə ekrana yazılsın "Hava istidir".
using System;

int weatherTemprature = 14;


if (weatherTemprature < 15)
{
    Console.WriteLine("Hava Soyuqdur");
}
else if (weatherTemprature > 15)
{
    Console.WriteLine("Hava Istidir");
}
else
{
    Console.WriteLine("Error!");
}