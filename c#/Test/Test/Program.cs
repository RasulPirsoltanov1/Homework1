

//class Program
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = {1, 12, 32, 453, -1 };
//        Console.WriteLine(Min(arr));
//    }
//    public static int Min(int[] arr)
//    {
//        int minValue = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < minValue)
//            {
//                minValue = arr[i];
//            }
//        }
//        return minValue;
//    }
//}




//class Program
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 1, 12, 32, 453, -1 };
//        Console.WriteLine(Sum(arr));
//    }
//    public static int Sum(int[] arr)
//    {
//        int result = 0;
//        foreach (int element in arr)
//        {
//            result += element;
//        }
//        return result;
//    }
//}






//class program
//{
//    public static void main(string[] args)
//    {
//        int[] arr = { 1, 2, 2, 3 };
//        sum(arr);
//    }
//    public static void sum(int[] arr)
//    {
//        int[] reversearray = new int[arr.length];
//        for (int i = 0; i < arr.length; i++)
//        {
//            reversearray[i] = arr[arr.length - i - 1];
//        }
//        foreach (int i in reversearray)
//        {
//            console.writeline(i);
//        }
//    }
//}




//class program
//{
//    public static void main(string[] args)
//    {
//        int[] arr = { 1, 2, 2, 12,3 };
//        indexof(arr, 3);
//    }
//    public static void indexof(int[] arr, int num)
//    {
//        int max = arr.length - 1;
//        int min = 0;
//        bool checker = true;
//        int mid = (max + min) / 2;
//        for (int i = 0; i < arr.length; i++)
//        {
//            mid = (max + min) / 2;
//            if (arr[mid] == num)
//            {
//                console.writeline(mid);
//                checker = false;
//                break;
//            }
//            else if (arr[0] == num)
//            {
//                console.writeline(0);
//                checker = false;
//                break;
//            }
//            

//            else if (num > mid)
//            {
//                min = mid + 1;
//            }
//            else if (num < mid)
//            {
//                max = mid - 1;
//            }
//        }
//        if (checker)
//        {
//            console.writeline("yoxdua");
//        }
//    }

//}



//class ReverseText
//{
//    public static int[] AddNumToArray(int[] arr, int num)
//    {
//        int[] res = new int[arr.Length + 1];
//        for (int i = 0; i < arr.Length + 1; i++)
//        {
//            if (arr.Length > i)
//            {
//                res[i] = arr[i];
//            }
//            else
//            {
//                res[i] = num;
//            }
//        }
//        return res;
//    }

//    public static void Main(string[] args)
//    {
//        int[] GivenArr = { 12, 43, 56, 23 };
//        int[] addedArray = AddNumToArray(GivenArr, 1112);
//        for (int i = 0; i < addedArray.Length; i++)
//        {
//            Console.Write(addedArray[i]);
//            if (addedArray.Length - 1 > i)
//            {
//                Console.Write(",");
//            }
//        }
//    }
//}





//using System;
//class program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(Replace("assa ssss cccc-> sss ddd ddd", 's', 't')); 
//    }
//    public static string Replace(string text,char char1,char char2)
//    {
//        string result=string.Empty;
//        for (int i = 0; i < text.Length; i++)
//        {
//            if (text[i] == char1)
//            {
//                result += char2;
//            }
//            else
//            {
//                result += text[i];
//            }
//        }
//        return result;
//    }
//}




//class program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine(Join(',', 12, 54, 34));
//    }
//    public static string Join(char char1, params int[] array)
//    {
//        string result = string.Empty;
//        for (int i = 0; i < array.Length; i++)
//        {

//            result = result + array[i];
//            if (i < array.Length - 1)
//            {
//                result = result + char1;
//            }
//        }
//        return result;
//    }
//}



internal class Program
{
    public static void Main()
    {

    }

}
