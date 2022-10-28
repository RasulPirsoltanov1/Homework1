using System;

string month = "aprel";
switch (month)
{
    case "yanvar":
    case "fevral":
    case "mart":
        Console.WriteLine("Qis");
        break;
    case "aprel":
    case "may":
    case "iyun":
        Console.WriteLine("Yaz");
        break;
    case "iyul":
    case "avgust":
    case "sentyabr":
        Console.WriteLine("Yay");
        break;
    case "oktyabr":
    case "dekabr":
    case "noyabr":
        Console.WriteLine("Payiz");
        break;
    default:
        Console.WriteLine("ayin adini duzgun girin!");
        break;
}