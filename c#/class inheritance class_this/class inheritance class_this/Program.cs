
using class_inheritance_class_this;

Person adam = new Person("Rasul",20);
Console.WriteLine(adam.Info());
Student student = new Student("Filankes", 23);
adam.person.name = "Parent name";
Console.WriteLine(adam.person.name);
//Console.WriteLine(adam.Info());
//Console.WriteLine(student.Info());
//Console.WriteLine(student.parent_name);
