//FindAll deyə bir generic method olacaq parametr olaraq
//bir array və delegate qəbul edəcək və delegate-dən gələn
//şərtə uyğun olaraq array daxilindəki bütün elementləri başqa
//bir array-ə yığıb geriyə qaytaracaq.

//Məsələn:
//göndərinlən array -> [-1,2,3,5,9]
//göndərinlən şərt -> item > 2

//Qayıdan array -> [3,5,9]


using System;
Finder<int> finder = new Finder<int>();

Console.WriteLine(finder.FindAll(new int[] { 12, 423, 21, 1, 2, 11, 1 }, finder.checkBiggestfromTwo));
int[] a = finder.FindAll(new int[] { 12, 423, 21, 1, 2, 11, 1 }, finder.checkBiggestfromTwo);
Finder<string> finderChar = new Finder<string>();
foreach (var item in a)
{
    Console.WriteLine(item);
}
class Finder<T>
{
    private T[] _arr;
    public Finder()
    {
        _arr = new T[0];
    }
    public T[] FindAll(T[] arr, Delegate1<T> checker)
    {
        T[] newArr = new T[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (checker(arr[i]))
            {
                Array.Resize(ref newArr, newArr.Length + 1);
                newArr[newArr.Length - 1] = arr[i];
            }
        }
        return newArr;
    }
    public bool checkBiggestfromTwo(int arrElement) => arrElement > 2;
    public bool checkBiggestfromTen(int arrElement) => arrElement > 10;
    public delegate bool Delegate1<T>(T arrElement);
}