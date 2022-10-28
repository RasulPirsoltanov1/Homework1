// 1 - Verilmiş ədədin ikinin qüvvəti olub olmadığını yoxlayan alqoritm yazın
int a = 15;
bool checker = true;

if (a == 0)
{
    checker=false;
}
while(a != 1)
{
    if(a%2 != 0)
    {
        checker = false;
    }
    a=a/2;
}

if (checker)
{
    Console.WriteLine("2 nin quvvetidir!");
}
else
{
    Console.WriteLine("2 nin quvveti deyil!");
}
