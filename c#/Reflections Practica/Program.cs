//using Reflections_Practica.Interfaces;
//using System.Reflection;
//Assembly asmb = Assembly.GetExecutingAssembly();

//Type[] types= asmb.GetTypes();
//foreach (Type type in types)
//{
//	if (typeof(IUser).IsAssignableFrom(type))
//	{
//        Console.WriteLine(type.FullName);
//    }
//}

using System.Reflection;

Assembly asm = Assembly.GetExecutingAssembly();
Console.WriteLine(asm);
Type[] types = asm.GetTypes();
foreach (var type in types)
{
    //Console.WriteLine(type);
    foreach (var field in type.GetProperties())
    {
        Console.WriteLine($"{field.Name}/{field.PropertyType}");
    }
}