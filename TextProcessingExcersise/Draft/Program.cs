/// <summary>
///   Reflection
/// </summary>

using System;
using System.Reflection;
using System.Timers;

namespace Reflect;

class Program
{
    static void Main()
    {
        Type humanType = typeof(Human);

        ConstructorInfo? withAllParams =
            humanType.GetConstructor(
                [
                    typeof(string),
                    typeof(int),
                    typeof(int),
                    typeof(int),
                    typeof(string),
                    typeof(string),
                ]
            );

        Human? tsvetelin = withAllParams!.Invoke(["Tsvetelin Marinov", 25, 186, 65, "Bulgaria", "Software Engineer"]) as Human;

        FieldInfo[] fields = humanType.GetFields(
            BindingFlags.NonPublic |
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.Static
        );
        PropertyInfo[] props = humanType.GetProperties();
        ConstructorInfo[] constructors = humanType.GetConstructors(
            BindingFlags.NonPublic |
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.Static
        );
        MethodInfo[] methods = humanType.GetMethods();

        Console.WriteLine("------------------- Fields -------------------");
        Array.ForEach(fields, field =>
            Console.WriteLine(
                $"\nField name : {field.Name}\n" +
                $"Field data type : {field.FieldType}\n" +
                $"Field value : {field.GetValue(tsvetelin)}\n" +
                $"Private member : {field.IsPrivate}\n\n"
            )
        );
        Console.WriteLine("------------------- Properties -------------------");
        Array.ForEach(props, prop =>
            Console.WriteLine(
                $"\nProperty name : {prop.Name}\n" +
                $"Property data type : {prop.PropertyType}\n" +
                $"Property value : {prop.GetValue(tsvetelin)}\n\n"
            )
        );
        Console.WriteLine("------------------- Constructors -------------------");
        Array.ForEach(constructors, constructor =>
            Console.WriteLine(
                $"\nField name : {constructor.Name}\n" +
                $"Private member : {constructor.IsPrivate}\n\n"
            )
        );
        Console.WriteLine("------------------- Methods -------------------");
        Array.ForEach(methods, method =>
            Console.WriteLine(
                $"\nMethod name : {method.Name}\n" +
                $"Method return data type : {method.ReturnType}\n" +
                $"Private member : {method.IsPrivate}\n\n"
            )
        );

        Test();
    }

    private static void Test()
    {
        double weigth = 65.67;
        int weigthAsInt = (int)Convert.ChangeType(weigth, typeof(int));
        Console.WriteLine(weigthAsInt);

        Timer timer = new();
        timer.Start();
        Console.WriteLine(Object.Equals(weigth, weigthAsInt));
        timer.Stop();
        Console.WriteLine(timer.Interval);
    }
}
