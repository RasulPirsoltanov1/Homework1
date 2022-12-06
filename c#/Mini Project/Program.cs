//Exceptions
//- NotFoundException

//Status class
//-Id
//- Title
//- Content
//- SharedDate - DateTime tipindən bir property, statusdan yeni bir obyekt yaranan zaman yarandığı tarix set olunacaq.
//- GetStatusInfo() -geriyə "Title: test title - Content: test content - shared 5 seconds ago"(burda qeyd olunan "shared
//5 seconds ago" hissəsi dinamik olmalıdı status neçə saniyə əvvəl paylaşılıbsa o yazılmalıdı) bu tipdə bir məlumat qaytaracaq.
using Mini_Project.Expections;
using Mini_Project.Models;

Status testStatus = new Status("test1", "lorem ipsum dolor sit amet");

Status testStatus1 = new Status("test2", "lorem ipsum dolor sit amet");
Status testStatus2 = new Status("test3", "lorem ipsum dolor sit amet");
testStatus.GetStatusInfo();
//Console.WriteLine(testStatus.GetStatusInfo());
User newUser = new User("FirstUser");

newUser.ShareStatus(testStatus);

newUser.ShareStatus(testStatus1);
newUser.ShareStatus(testStatus2);
//newUser.GetStatus();
Console.WriteLine(newUser.GetStatusById(1).Title);


foreach (var itrm in newUser.GetAllStatuses())
{
    Console.WriteLine(itrm.Title);
}

try
{
    Console.WriteLine(newUser.FilterStatusByDate(DateTime.Now));
}
catch (NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}




//Menu
//1. Share status
//2. Get all statuses
//3. Get status by id
//4. Filter status by date 
//0. Quit
//--

Console.Write("enter the name : ");
string name = Console.ReadLine();
User newStatus = new(name);

bool a = true;
while (a)
{
    Console.WriteLine("\r\n//Menu\r\n//1.Share status\r\n//2.Get all statuses\r\n//3. Get status by id\r\n//4. Filter status by date \r\n//0. Quit\r\n//--");
    Console.Write("enter a process : ");
    int _case = int.Parse(Console.ReadLine());

    switch (_case)
    {
        case 1:
            Console.Write("Status name: ");
            string statusName = Console.ReadLine();
            Console.Write("Status content: ");
            string statusContent = Console.ReadLine();
            newStatus.ShareStatus(new Status(statusName, statusContent));
            Console.WriteLine("Status shared...");
            break;
        case 2:
            foreach (var itrm in newStatus.GetAllStatuses())
            {
                Console.WriteLine(itrm.Title);
            }
            break;
        case 3:
            Console.Write("enter Id : ");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine(newUser.GetStatusById(id).Title);
            break;
        case 4:
            Console.WriteLine("quit");
            a = false;
            break;
    }
}