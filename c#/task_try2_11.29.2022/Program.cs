int[] arr = new int[] { 12, 324, 3, 2, 1 };
//Console.WriteLine(Find<int>(arr, 2));

//[-2,3,4,5] value > 0 1
int Find<T>(T[] obj1,T element, Checker<T> checker)
{
	for (int i = 0; i < obj1.Length; i++)
	{
		if (checker(obj1[i],element))
		{
			return i;
		}
	}
	return -1;
}

Console.WriteLine(Find<int>(arr, 3, check));

bool check(int obj1,int element)
{
    if(obj1 == element)
    {
		return true;
	}
	return false;
}
delegate bool Checker<T>(T x,T y);
