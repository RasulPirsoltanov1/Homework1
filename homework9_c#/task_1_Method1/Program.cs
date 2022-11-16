//1 - Bir method yazın parametr olaraq bir array və size parametrləri
//qəbul etsin etsin həmin arrayin ölçüsünü göndərilən size-a bərabər etsin.

class Program
{

    public static void Main(string[] args)
    {
        int[] currentArray = { 12, 32, 34, 3 };
        
        Console.WriteLine("*************************");
        Console.WriteLine("first array length before : " + currentArray.Length);
        Resize(ref currentArray, 2);
        Console.WriteLine("first array length then : "+currentArray.Length);
    }
    public static void Resize(ref int[] array,int newSize)
    {
        int[] newArray = new int[newSize];
        for (int i = 0; i < newSize; i++)
        {
            if (array.Length > i)
            {
                newArray[i] = array[i];
            }
            else
            {
                newArray[i] = 0;
            }
        }
        array = newArray;

    }


}
