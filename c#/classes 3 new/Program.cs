using classes_3_new;

//Book newBook = new Book("Iphone","Telephone",23,1700);

//newBook.getInfo();
Console.Write("input product count: ");
int count = int.Parse(Console.ReadLine());
Book[] arrBook = new Book[count];

for (int i = 0; i < arrBook.Length; i++)
{
    Console.WriteLine("*********************Next product**********************\n");
    Console.Write("input name: ");
    string name = Console.ReadLine();
    Console.Write("input category: ");
    string category = Console.ReadLine();
    Console.Write("input num: ");
    int num = int.Parse(Console.ReadLine());
    Console.Write("input price: ");
    int price = int.Parse(Console.ReadLine());
    arrBook[i] = new Book(name, category, num, price);
}
Console.WriteLine("*********************Exited loop**********************\n");
getProcess(arrBook);

void getProcess(Book[] arr)
{
    bool checker = true;
    while (checker)
    {
        Console.WriteLine("*************Operations*****************");
        Console.WriteLine("1- filter books for price\n2-search books\n3-all books\n4-exit");
        Console.Write("choose: ");
        int choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
                Console.Write("input max price: ");
                int maxValue = int.Parse(Console.ReadLine());
                Console.Write("input min price: ");
                int minValue = int.Parse(Console.ReadLine());
                for (int i = 0; i < arrBook.Length; i++)
                {
                    if (minValue < arrBook[i].price && maxValue > arrBook[i].price)
                    {
                        arrBook[i].getInfo();
                    }
                }
                Console.WriteLine("--------------------process succesfully----------------");
                break;
            case 2:
                Console.Write("input search text: ");
                string searchedText = Console.ReadLine();
                for (int i = 0; i < arrBook.Length; i++)
                {
                    if (searchedText == arrBook[i].name)
                    {
                        arrBook[i].getInfo();
                    }
                }
                break;
            case 3:
                for (int i = 0; i < arrBook.Length; i++)
                {
                    arrBook[i].getInfo();
                    Console.WriteLine("------------------------------------------");
                }
                break;
            case 4:
                checker = false;
                break;
            default:
                Console.WriteLine("Please input correct process num: ");
                break;
        }

    }
}