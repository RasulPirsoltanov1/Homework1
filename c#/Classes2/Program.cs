
//class Program
//{
//    public static void Main()
//    {
//        Student newStudent = new Student("Rasul", "Pirsoltanov", 45, 55, 70);
//        newStudent.GetInfo();
//    }
//}
//class Student
//{
//    private string name;
//    private string surname;
//    private int resutlt1;
//    private int resutlt2;
//    private int final;
//     public Student(string _name, string _surname, int _result1, int _result2, int _final)
//    {
//        name = _name;
//        surname = _surname;
//        resutlt1 = _result1;
//        resutlt2 = _result2;
//        final = _final;
//    }
//    public void GetInfo()
//    {
//        double result = (resutlt2 * 0.2) + (resutlt1 * 0.2) + (final * 0.6);
//        Console.WriteLine($"Name : {name} \nSurname : {surname} \nResult : {result}");
//    }
//}





//class Program
//{
//    public static void Main()
//    {
//        Student newStudent = new Student();
//        newStudent.setName("Rasul");
//        Console.WriteLine(newStudent.getName());
//    }

//}

//class Student
//{
//    private string name;
//    private string surname;
//    private int resutlt1;
//    private int resutlt2;
//    private int final;
//    public void setName(string _name)
//    {
//        name= _name;
//    }
//    public string getName()
//    {
//        return name;
//    }
//}


//class Program
//{
//    public static void Main()
//    {
//        Student newStudent = new Student();
//        newStudent.NAME = "Rasul Pirsoltanov";
//        Console.WriteLine($"property : {newStudent.NAME}");
//    }

//}

//class Student
//{
//    private string name;

//    public string NAME
//    {
//        get
//        {
//            return name;
//        }
//        set
//        {
//            name = value;
//        }
//    }
//}





//class Program
//{
//    public static void Main()
//    {
//        Student newStudent = new Student();
//        newStudent.print();
//        Student.printstatic();
//    }

//}

//class Student
//{
//    private string name;

//    public void print()
//    {
//        Console.WriteLine("PRINT METHOD");
//    }
//    public static void printstatic()
//    {
//        Console.WriteLine("STATIC PRINT METHOD");
//    }
//}



using System.Collections;

class Program
{
    public static void Main()
    {
        ArrayList arrN=new ArrayList();
        arrN.Add("12");
        arrN.Add("12sa");
        arrN.Add("1wqe2");
        foreach (int obj in arrN)
        {
            Console.WriteLine(obj);
        }
    }
}
