//using Stringbuilder_Clear;
//using System.Text;

//Appends add = new Appends();
//add.AppendS("czxc");
//add.AppendS("knda");
//Console.WriteLine(add.Capacity);
//Console.WriteLine(add.Capacity[0]);

//foreach (var item in add.Capacity)
//{
//    Console.WriteLine(item);
//}

using System.Text;

BuilderString add=new BuilderString();
add.Append("baba zzzzzzzzz ");
Console.WriteLine(add);
add.Remove('b');
Console.WriteLine(add);
//_arr e menimsetmisem
foreach(var x in add._arr)
{
    Console.Write(x);
}


