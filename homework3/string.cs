//Task - 2: Ədədin mərtəbələrinin cəmini tapan alqoritm (məsələn: 123 - 1 + 2 + 3)
int number = 1, remain, sum = 0;
while (number > 0)
{
    remain = number % 10;
    sum = remain + sum;
    number = number / 10;
}
Console.WriteLine(sum);
