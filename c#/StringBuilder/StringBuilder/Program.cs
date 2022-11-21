
Console.WriteLine(StringBuilder2("Hellolll", 'l', 'd', 1, 3));
string StringBuilder2(string text, char old, char newchar, int start, int count)
{
    string word = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {

        if (text[i] != old )
        {
            word += text[i];
        }
        if (i > start)
        {
            if (start + count > i)
            {
                if (text[i] == old)
                {
                    word += newchar;
                }
            }
        }


    }
    return word;
}