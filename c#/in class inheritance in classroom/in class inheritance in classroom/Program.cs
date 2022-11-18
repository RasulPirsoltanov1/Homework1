using in_class_inheritance_in_classroom;

Console.Write("input ARRAY length : ");
int count = int.Parse(Console.ReadLine());
Book[] sifarish = new Book[count];
for (int i = 0; i < count; i++)
{
    Console.Write("input genre :");
    string genre = Console.ReadLine();
    Console.Write("input name :");
    string name = Console.ReadLine();
    Console.Write("input num :");
    int no = int.Parse(Console.ReadLine());
    Console.Write("input price :");
    int price = int.Parse(Console.ReadLine());
    Console.WriteLine("*************************\n");
    sifarish[i] = new Book(genre, name, price, no);
}

//for (int i = 0; i < sifarish.Length; i++)
//{
//    Console.WriteLine("****************results***********************");
//    Console.WriteLine($"genre {sifarish[i].genre}  name {sifarish[i].genre}  num {sifarish[i].no}");
//}


while (true)
{

    Console.WriteLine("1-filtr for price");
    Console.WriteLine("2-search");
    Console.WriteLine("3-all books");
    Console.WriteLine("4-exit");
    int case1 = int.Parse(Console.ReadLine());
    if (case1 == 1)
    {
        Console.Write("int max price");
        int max = int.Parse(Console.ReadLine());
        Console.Write("int min price");
        int min = int.Parse(Console.ReadLine());
        for (int i = 0; i < sifarish.Length; i++)
        {
            if (sifarish[i].price > min && sifarish[i].price < max)
            {
                Console.WriteLine("******************result****************");
                Console.WriteLine($"genre : {sifarish[i].genre}  name : {sifarish[i].genre}  num : {sifarish[i].price}");
            }
        }
    }
   else if (case1 == 2)
    {
        Console.Write("int searced text : ");
        string searcedText = Console.ReadLine();
        for (int i = 0; i < sifarish.Length; i++)
        {
            if (sifarish[i].name == searcedText)
            {
                Console.WriteLine("******************result****************");
                Console.WriteLine($"genre : {sifarish[i].genre}  name : {sifarish[i].genre}  num : {sifarish[i].price}");
            }
        }
    }
    else if (case1 == 3)
    {
        for (int i = 0; i < sifarish.Length; i++)
        {
            Console.WriteLine("****************results***********************");
            Console.WriteLine($"genre {sifarish[i].genre}  name {sifarish[i].genre}  num {sifarish[i].no}");
        }
    }
    else if (case1 == 4)
    {
        break;
    }
    else
    {
        Console.WriteLine("dogru secim edin  :");
    }

}

