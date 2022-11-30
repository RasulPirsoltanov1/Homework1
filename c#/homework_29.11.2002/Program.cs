class Program
{
    static public void Main(string[] args)
    {
        GenericTest<int> test1 = new GenericTest<int>();
        test1.Add(1);
        test1.Add(3);
        test1.Add(4);
        test1.Add(5);
        test1.Show();
        test1[1] = 5;
        Console.WriteLine("*****************");
        test1.Show();
        GenericTest<string> test2 = new GenericTest<string>();
        test2.Add("ASdsad");
        test2.Add("ASdsad");
        test2.Add("ASdsad");
        test2.Add("ASdsad");
        test2.Show();
    }
}

class GenericTest<T>
{
    private T[] obj;
    public GenericTest()
    {
        obj = new T[0];
    }
    public void Add(T obj2)
    {
        Array.Resize(ref obj, obj.Length + 1);
        this.obj[obj.Length-1] = obj2;
    }
    public void Show()
    {
        for (int i = 0; i < obj.Length; i++)
        {
            Console.WriteLine(obj[i]);
        }
    }
    public T this[int index]
    {
        get
        {
            return obj[index];
        }
        set
        {
            obj[index] = value;
        }
    }
    private bool PositiveNums(int abyekt)
    {
        if (abyekt>0)
        {
            return true;
        }
        return false;
    }

}
