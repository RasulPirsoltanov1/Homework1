int counter = 0;
Console.Write("input name: ");
string name = Console.ReadLine();
name = name.ToLower();
Console.Write("input character: ");
string charakter = Console.ReadLine();
bool loop = true;
while (loop)
{
    if (charakter.Length > 1)
    {
        Console.WriteLine("Please input only one character! ");
    }
    else if (charakter == string.Empty)
    {
        Console.WriteLine("character can not be null!");
    }
    else
    {
        var a = Char.ToLower(charakter[0]);
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == a)
            {
                counter++;
            }
        }

        Console.WriteLine("sayi : " + counter);
    }


    Console.WriteLine("do you want to contunue...");


}



