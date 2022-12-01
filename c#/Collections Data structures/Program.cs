#region  Dictionary

//Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
//keyValuePairs.Add("Rasul", 21);
//keyValuePairs.Add("Flankes", 41);
//keyValuePairs.Add("besmakes", 31);
//keyValuePairs.Add("xalxin usagi", 32);

////foreach (var pair in keyValuePairs)
////{
////    Console.WriteLine($"{pair.Key} {pair.Value}");
////}
//Console.WriteLine(keyValuePairs["Rasul"]);


//Console.Write("enter key ");

//string keyName = Console.ReadLine();
//if (keyValuePairs.ContainsKey(keyName))
//{
//    Console.WriteLine(keyValuePairs[keyName]);
//}
//else
//{
//    Console.WriteLine("does not exists the value for this key!");
//}
#endregion

#region Queue

//Queue<int> newQueue = new Queue<int>();
//newQueue.Enqueue(1);
//newQueue.Enqueue(2);
//newQueue.Enqueue(3);
//newQueue.Enqueue(4);
//Console.WriteLine(newQueue.Count);
//int countQueue = newQueue.Count;
//for (int i = 0; i < countQueue; i++)
//{
//    Console.WriteLine(newQueue.Dequeue());
//}

#endregion
#region HashSet
HashSet<string> keys = new HashSet<string>();
keys.Add("Salam");
keys.Add("Salam1");
HashSet<string> keys2 = new HashSet<string>();
keys2.Add("Salam");
keys2.Add("Salam2");
keys.IntersectWith(keys2);
Console.ReadLine();
#endregion
