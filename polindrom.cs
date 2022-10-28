
int n, r, sum = 0, temp;
n = 121;
temp = n;
while (n > 0)
{
    r = n % 10;
    sum = (sum * 10) + r;
    n = n / 10;
}
if (temp == sum)
    Console.Write("Polindromdur");
else
    Console.Write("Polindrom deyil");