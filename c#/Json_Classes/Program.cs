



using Json_Classes;
using Newtonsoft.Json;

Product p1 = new()
{
    Id = 1,
    Name = "Iphone 14 pro max",
    Stock = 234,
    Price = 2699,
};
Product p2 = new()
{
    Id = 2,
    Name = "Samsung s20",
    Stock = 74,
    Price = 4699,
};

OrderProduct item1 = new()
{
    Id = 1,
    Product = p1,
    Count = 1,
    Price = 231
};

OrderProduct item2 = new()
{
    Id = 2,
    Product = p2,
    Count = 3,
    Price = 3193
};

Order ord = new();
ord.Id = 1;
ord.Items.Add(item1);
ord.Items.Add(item2);

//Console.WriteLine(ord.Items[0].Id);

var js = JsonConvert.SerializeObject(ord);

StreamWriter sw=new StreamWriter(@"C:\Users\user\Desktop\Homeworks\Homework1\c#\Json_Classes\data.json",true);
sw.WriteLine(js);
sw.Close();