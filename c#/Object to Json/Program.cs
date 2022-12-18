using Newtonsoft.Json;
using Object_to_Json;
using Object_to_Json.Models;

class Program
{
    static public void Main(string[] args)
    {
        User user = new User()
        {
            Id = 1,
            ChildCount = 3,
            Person = new Person()
            {
                Name = "Rasul",
                Surname = "Pirsoltanov"
            },
            Childs = new Childrens[]
            {
                new Childrens()
                {
                    Id=1,
                    Name="Arif"
                },
                new Childrens()
                {
                    Id=1,
                    Name="Azer"
                },
                 new Childrens()
                {
                    Id=1,
                    Name="Rauf"
                }
            }
        };
        ConvertToJsonFormat.GetTask(user);
    }
}
