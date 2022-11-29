using Generic_types1;
Class1 test = new();
Generic1<int> test1 = new();
test1.add(1);
test1.add(2);
test1.add(4);
test1.add(6);
test1[1] = 55;
test1.Show();

test2(test);
void test2<T>(T abyekt)
    where T : class,new()
{
    if(abyekt is int)
    {
        Console.WriteLine("INTEGER");
    }
    else
    {
        Console.WriteLine("INTEGER deil");
    }
}