//StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\Homeworks\Homework1\c#\StramRead and SreamWrite\text.txt");


//int count = 0;
//object locker1 = new object();
//Thread i = new Thread(Increase);
//Thread d = new Thread(Decrease);

//i.Start();
//d.Start();
//Console.WriteLine(count);
//void Increase()
//{
//    for(int i = 0; i < 100000; i++)
//    {
//        lock (locker1)
//        {
//            count++;
//        }

//    }
//}

//void Decrease()
//{
//    for (int i = 0; i < 100000; i++)
//    {
//        lock (locker1)
//        {
//            count--;
//        }
//    }
//}



using Newtonsoft.Json;
using StramRead_and_SreamWrite.Exceptions;
using StramRead_and_SreamWrite.Models;
using System.Text.Json;

try
{
   

    var testPost = await Get(@"https://jsofnplaceholder.typicode.com/todos");
    foreach (var i in testPost)
    {
        Console.WriteLine(i.Title);
    }
}
catch (NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}

static async Task<List<Post>> Get(string path)
{
    string result;
    List<Post> post = default;
    using (HttpClient client = new HttpClient())
    {
        var response = await client.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            result = await response.Content.ReadAsStringAsync();
            post = JsonConvert.DeserializeObject<List<Post>>(result);
        }
        else
        {
            throw new NotFoundException("data not found");
        }
        return post;
    }

}
