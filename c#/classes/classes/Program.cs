
var sagird = new Student("Rasul", 20);
sagird.getInfo();
class Student
{
    public string name;
    public int age;
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void getInfo()
    {
        Console.WriteLine($"Name : {this.name} Age : {this.age}");
    }
}