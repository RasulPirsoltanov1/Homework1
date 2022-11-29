
Console.WriteLine(Find(new int[] { -2, 23, 432, 4 }, CheckElement));

int Find<T>(T[] arr, PositiveChecker<T> check)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (check(arr[i]))
		{
			return i;
		}
	}
	return -1;	
}
bool CheckElement(int a)
{
	if (a > 0)
	{
		return true;
	}
	return false;
}
delegate bool PositiveChecker<T>(T a);