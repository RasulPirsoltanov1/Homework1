using classes_access_modifiers_test;
using classes_access_modifiers_test.props;
Bmw test=new Bmw();
test.getStop();
test.Class1 newClass=new test.Class1();
namespace test
{
    class Class1
    {
        public Class1()
        {
            Console.WriteLine("test is working...");
        }
    }

}
