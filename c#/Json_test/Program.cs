string path = @"C:\Users\user\Desktop\Homeworks\Homework1\c#\Json_test\Data\text.txt";

StreamWriter stream = new(path, true);
stream.WriteLine("nfhjavfdjbfhsbfdsak");
stream.Close();

StreamReader read = new StreamReader(path);
Console.WriteLine(read.ReadToEnd());