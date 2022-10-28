using System;

int a = 12;
bool checker = false;
for (int i = 1; i < a; i++)
{
    if (a % i == 0 && i != 1)
    {
        checker = true;
    }
}
if (checker)
{
    Console.WriteLine("Cuttdur");
}
else
{
    Console.WriteLine("Tekdir");
}
