using homework_mini_project.Models;

//Status status = new("testTitle", "test content");
//Status status1 = new("title1", "test conten2t");
//Status status2 = new("Title2", "test content3");
//Console.Read();
//User user = new User("newUser");
//user.ShareStatus(status);
//user.ShareStatus(status1);
//var date = DateTime.Now;
//user.ShareStatus(status2);
//user.getStatuses();
//Console.WriteLine("************************");
//Console.WriteLine(user.GetStatusById(1).GetStatusInfo());
//Console.WriteLine("************************");
//foreach (var i in user.GetAllStatuses())
//    Console.WriteLine(i.GetStatusInfo());
//Console.WriteLine("************************");
//foreach (var i in user.GetAllStatuses())
//    Console.WriteLine(i.GetStatusInfo());


Console.WriteLine("************************************");

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
                Console.WriteLine(itrm.GetStatusInfo());
            }
            break;
        case 3:
            Console.Write("enter Id : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(newStatus.GetStatusById(id).GetStatusInfo());
            break;
        case 4:
            Console.WriteLine("quit");
            a = false;
            break;
    }
}