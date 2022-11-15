Console.Write("Input Text: ");
string biggest = Console.ReadLine();
Console.Write("Input Subtext: ");
string smallest = Console.ReadLine();
Console.WriteLine("**************************RESULT********************************");
Console.WriteLine("");
int counter=0;
bool ok=true;
for (int i = 0; i < biggest.Length; i++)
{
    for (int j = 0; j < smallest.Length; j++)
    {
        if ((i + j) < biggest.Length)
        {
            if (biggest[i + j] == smallest[j])
            {
                counter++;
                if (counter == smallest.Length)
                {
                    Console.WriteLine("Subtext found. ");
                    ok = false;
                }
            }
            else
            {
                counter = 0;
                break;
            }
        }
    }
}
if(ok)
{
    Console.WriteLine("Subtext not found.");
}

