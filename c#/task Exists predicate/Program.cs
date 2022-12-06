class Program
{
    public static void Main(string[] args)
    {
        mylist<int> newList = new mylist<int>();
        newList.Add(12);
        newList.Add(13);
        newList.Add(133);
        newList.Add(1342);
        newList.Add(7843);
        int[] a_ = newList.arr;
        foreach (int i in a_)
        {
            Console.WriteLine(i);
        }


    }
}

class mylist<t>
{
    public t[] arr;
    public int Capacity { get; set; }
    public static int Count { get; set; } = 0;
    public mylist()
    {
        Capacity = 0;
        arr = new t[Capacity];
    }
    //public mylist(t[] array, int capacity, int count)
    //{
    //    arr = array;
    //    Capacity = capacity;
    //    Count = count;
    //    arr= new t[Capacity];
    //}
    public void Add(t x)
    {
        if (Capacity == 0)
        {
            Capacity = 1;
            Array.Resize(ref arr, Capacity + 1);
            arr[Capacity - 1] = x;
            return;
        }
        Array.Resize(ref arr, Capacity + 1);
        Capacity = Capacity + 1;
        arr[Capacity - 1] = x;
        return;
        Count++;

    }




    public bool exists(test1<t> predicate)
    {
        return true;
    }
    public bool exists1(int x)
    {
        for (int i = 0; i < arr.length; i++)
        {
            if (arr[i] == x)
            {
                return true;
            }
        }
        return false;
    }
    public delegate bool test1<t>(t x);
}