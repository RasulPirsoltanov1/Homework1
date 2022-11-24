//string test = "za fd";
//string word = string.Empty;
//string reverse = string.Empty;

//for (int i = 0; i < test.Length; i++)
//{
//    word += test[i];
//    if(test[i] == ' ' || i==test.Length-1)
//    {
//        for(int j = word.Length-1; j >=0; j--)
//        {
//            reverse=reverse + word[j];
//        }
//        reverse = reverse + ' ';
        
//        word = string.Empty;
//    }
//}
//Console.WriteLine(reverse.Trim());
//foreach (char c in reverse)
//{
//    Console.WriteLine(c);
//}

string getReverseText(string arrText)
{
    string word = string.Empty;
    string reverse=string.Empty;
    for(int i = 0; i < arrText.Length; i++)
    {
        word = word + arrText[i];
        if(arrText[i] == ' ' || i == arrText.Length - 1)
        {
            if(i==arrText.Length - 1)
            {
                reverse = reverse + " ";
            }
            reverse += getReverseWord(word);
            word = string.Empty;
        }
    }
    return reverse.Trim();
}

string getReverseWord(string word)
{
    string reverse = string.Empty;
    for (int i = word.Length-1; i >=0; i--)
    {
        reverse= reverse + word[i];
    }
    return reverse;
}
Console.WriteLine(getReverseText("sen yaxsi oglansan"));