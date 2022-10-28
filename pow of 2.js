// 1 - Verilmiş ədədin ikinin qüvvəti olub olmadığını yoxlayan alqoritm yazın
let a = 15;
let checker = true;

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
    console.log("2 nin quvvetidir!");
}
else
{
    console.log("2 nin quvveti deyil!");
}
