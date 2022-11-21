getReverse("za fd");

void getReverse(string text)
{
    char[] reverse = new char[text.Length];
    string result = String.Empty;
    string result2 = String.Empty;
    string word = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] != ' ' || i == text.Length - 1)
        {
            word+= text[i];
        }
        if (text[i] == ' ' || i == text.Length - 1)
        {
            result2 = result2+textreturner(word);
            result = string.Empty;
        }

    }
    Console.WriteLine(result);

}


string textreturner(string text)
{
    string result = String.Empty;
    for (int j = text.Length; j >=0; j--)
    {
        result+=text[j];
        
    }
    return result;

}