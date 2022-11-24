// See https://aka.ms/new-console-template for more information
using School.Students;

Student studentNew = new Student("Rasul","Pirsoltanov","BB101");
Student studentNew2 = new Student("Rasul","Pirsoltanov","BB101");
studentNew2.StudentInfo();
Console.WriteLine(Student.CheckGroupNo("BB133"));