

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 12, 32, 453, -1 };
        Console.WriteLine(Min(arr));
    }
    public static int Min(int[] arr)
    {
        int minValue = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }
        return minValue;
    }
}