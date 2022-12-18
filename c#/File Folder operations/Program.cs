
string path = @"C:\Users\user\Desktop\Homeworks\Homework1\c#\File Folder operations\Folders\";
ShowFolders(path);
 void ShowFolders(string path,string space="")
{
    var x = Directory.GetDirectories(path);
    var y = Directory.GetFiles(path);
    foreach (var item in x)
    {
        Console.WriteLine(space+item);
        if (Directory.CreateDirectory(item).Exists)
        {
            space = space + "->  ";
            ShowFolders(item, space);
        }
        else
        {
            space = string.Empty;
            ShowFolders(path, space);
        }
    }
    foreach (var item in y)
    {
        Console.WriteLine(space + item);
    }
}

























//int Sum(int start,int end)
//{

//    if (start == end)
//    {
//        return 1;
//    }
//    start=start+1;
//    return start+Sum(start,end);
//}
//Console.WriteLine(Sum(1,3));


//if (!Directory.CreateDirectory(path).Exists)
//{
//    var a = Directory.CreateDirectory(path);
//    Console.WriteLine(a.Name);
//}
//if (!File.Exists(path + @"\Test.txt"))
//{
//    File.Create(path + @"\Test.txt");
//}

