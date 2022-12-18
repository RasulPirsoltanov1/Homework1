
using Newtonsoft.Json;

const string apiUrl = @"https://catfact.ninja/fact";
HttpClient client = new HttpClient();

while (true)
{
    Console.WriteLine("do you want to continue : ");
    int a=int.Parse(Console.ReadLine());
    if (a == 1)
    {
        var result = await client.GetStringAsync(apiUrl);
        var catFact=JsonConvert.DeserializeObject<CatFact>(result);
        Console.WriteLine(catFact.fact + "|| lengt - >  "+catFact.length);
        continue;
    }
    else
    {
        break;
    }
}

public class CatFact
{
    public string fact { get; set; }
    public int length { get; set; }
}

