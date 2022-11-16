class ReverseText
{

    public static string Revers(string Text)
    {
        string result = "";
        for(int i = Text.Length-1; i >=0 ; i--)
        {
            result += Text[i];
        }
        return result;
    }

    public static void Main(string[] args)
    {
        string A = "DKJSAKSAJ";
        Console.WriteLine(Revers("DKJSAKSAJ")); ;
    }
}
