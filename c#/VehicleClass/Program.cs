
using classes_access_modifiers_test;
using classes_access_modifiers_test.props;

class test3 : Vehicle
{
    private int test2;
    public int Test
    {
        get
        {
            return test2;
        }
        set
        {
            test2 = value;
        }
    }
    Bmw ad = new();
}
