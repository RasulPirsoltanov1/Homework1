//Task - 2: Ədədin mərtəbələrinin cəmini tapan alqoritm (məsələn: 123 - 1 + 2 + 3)
int reqem = 1, qaliq, cem = 0;
while (reqem > 0)
{
    qaliq = reqem % 10;
    cem = qaliq + cem;
    reqem = reqem / 10;
}
Console.WriteLine(cem);
