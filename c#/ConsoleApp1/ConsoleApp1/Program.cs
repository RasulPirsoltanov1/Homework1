class ReverseText
{

    public static void Resizenum(ref int[] arr, int num)
    {
        int[] res = new int[arr.Length+1];
        for (int i = 0; i < 1+arr.Length; i++)
        {
            if (arr.Length > i)
            {
                res[i] = arr[i];
            }
            else { res[i] = num; }
        }
        Console.WriteLine("then : "+res.Length);
        arr = res;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 12, 43, 56, 23 };
        Console.WriteLine("now : "+arr.Length);
        Resizenum(ref arr, 13);
        Console.WriteLine("main : "+arr.Length);
        Console.WriteLine("******************** ");
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}
