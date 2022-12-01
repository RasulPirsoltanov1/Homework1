class Program
{
    public static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(112);
        myList.Add(211);
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
        MyList<string> stringList = new MyList<string>();
        stringList.Add("bir");
        stringList.Add("iki");
        stringList.Add("uc");
        stringList.Add("uc");
        Console.WriteLine("******String******");
        stringList[2] = "dort";
        for (int i = 0; i < stringList.Count; i++)
        {
            Console.WriteLine(stringList[i]) ;
        }
        Console.WriteLine(stringList.Exists("ucw"));
        stringList[2] = "dort";
        Console.WriteLine(stringList[2]);
    }
}
class MyList<T>
{
    private T[] arr;
    public int Capacity { get; set; }
    public int Count { get; set; }
    public int Length { get; set; }
    public MyList()
    {
        Capacity = 0;
        arr = new T[Capacity];
    }
    public void Add(T a)
    {
        if (Capacity == 0)
        {
            Capacity = Capacity + 1;
            Array.Resize(ref arr, Capacity);
            arr[Capacity - 1] = a;
        }
        else if (Capacity <= arr.Length)
        {
            Capacity = arr.Length + 1;
            Array.Resize(ref arr, Capacity);
            arr[Capacity - 1] = a;
        }
        Count++;
    }
    public bool Exists(T element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (checker(arr[i], element))
            {
                return true;
            }
        }
        return false;
    }
    public bool checker(object a, object b)
    {
        if (a == b)
        {
            return true;
        }
        return false;
    }
    public T this[int index]
    {
        get
        {
            return arr[index];
        }
        set
        {
            arr[index] = value;
        }
    }
}

