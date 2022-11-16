class ReverseText
{

    public static void Resizenum(ref int[] arr, int num)
    {
        int[] res = new int[num];
        for (int i = 0; i < num; i++)
        {
            if (arr.Length > i)
            {
                res[i] = arr[i];
            }
            else { res[i] = 0; }
        }
        Console.WriteLine(res.Length);
        arr = res;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 12, 43, 56, 23 };
        Console.WriteLine(arr.Length);
        Resizenum(ref arr, 13);
        Console.WriteLine(arr.Length);
        Console.WriteLine( "******************** ");
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}
