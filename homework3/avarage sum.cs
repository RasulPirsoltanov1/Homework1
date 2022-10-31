//Task - 1: 1 - 10 aralığında olan cüt ədədlərin ədədi ortasını tapan alqoritm yazın.
int sum=0,counter=0;
for(int i = 1; i < 10; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + i;
        counter++;
    }
}

Console.WriteLine("ededi orta = "+sum/counter);