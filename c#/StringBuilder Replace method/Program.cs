// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine(StringBuilder2("text text", 'x', 'y', 3, 2));

string StringBuilder2(string text,char oldChar,char newChar, int start, int count)
{
	StringBuilder word = new StringBuilder();
	for (int i = 0; i < text.Length; i++)
	{
		if (text[i] == oldChar && i>count)
		{
			word.Append(newChar);
		}
		else
		{
            word.Append(text[i]);
        }
    }
	return word.ToString();
}