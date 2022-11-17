//2 -Repeat deyə bir method olsun və iki parametr qəbul etsin biri
//"word" digəri "count" yəni bu şəkildə "Repeat(string word, int count)"
//bu method göndərilən word-ü göndərilən count qədər
//yan-yana yazdırıb geri qaytarsın. Məsələn:Repeat("Ha!") //Ha!
//Repeat("Ha!", 2) //Ha!Ha!
//Repeat("Ha!", 3) //Ha!Ha!Ha!
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input word : ");
        string word = Console.ReadLine();
        Console.Write("Input count : ");
        int count = int.Parse(Console.ReadLine());
        Repeat(word, count);
    }
    public static void Repeat(string word, int count)
    {
        Console.WriteLine("******************");
        for (int i = 0; i < count; i++)
        {
            Console.Write(word);
            if (count - i > 1)
            {
                Console.Write(",");
            }
        }
    }
}