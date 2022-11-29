internal class Program
{
	private static void Main(string[] args)
	{
		int[] new1 = new int[] { 12, 54, 7, 32, 4 };
		Console.WriteLine(Find(new1, 7));

		int Find<T>(T[] obj, T element)
		{
			for (int i = 0; i < obj.Length; i++)
			{
				if (check(obj[i],element))
				{
					return i;
				}
			}
			return -1;
		}
		bool check(object x,object y)
		{
			if (x==y)
			{
                return true;
            }
			else
			{
                return false;
            }
        }
	}
}

delegate int MyDelegate(object[] arr,object element);

