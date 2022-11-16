Console.Write("ayin nomresini qirin : ");
int montId = Convert.ToInt32(Console.ReadLine());

var result = montId switch
{
    1 or 2 or 3 or 4 or 5 => "32",
    6 or 7 or 8 => "28",
    9 => "30",
    10 => "34",
    11 => "30",
    12 => "12",
    _ => "please input correct num !",
};

Console.WriteLine(result);
Console.WriteLine("------------------Automatic-------------------------");
var result2 = montId switch
{
    int x when x > 0 && x < 6 => " 30 day",
    int x when x >= 6 && x <= 12 => " 23 day",
    _ => "please input correct num !"
};

Console.WriteLine(result2);
