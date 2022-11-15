//İstifadəçi arrayin uzunluğunu daxil edir daha sonra isə həmin arrayə ədədlər daxil
//edir arrayin içini doldurduqdan sonra həmin arraydə ki cüt ədədlərin cəmini tapan
//alqoritm yazın.

Console.Write("Input array length: ");
int arrLength=int.Parse(Console.ReadLine());
int[] array = new int[arrLength];
int result = 0;

for (int i = 0; i < arrLength; i++)
{
    Console.Write(i + ". index value : ");
    array[i] = int.Parse(Console.ReadLine());
    
}
Console.WriteLine("*****************Result********************");

for (int i = 0; i < arrLength; i++)
{
    if (array[i] % 2 == 0)
    {
        result += array[i];
    }
}

Console.WriteLine("Plural numbers sum : "+result);
