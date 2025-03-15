using book_lst;
using MyNamespace;
using MyNamespace2;

internal class Program
{
    static void Main(string[] args)
    {
        // 1
        book_list obj = new book_list();
        obj = obj + "hello";
        obj = obj + "world";
        obj.print();

        obj = obj - 0;
        Console.WriteLine();
        obj.print();

        Console.WriteLine(obj == "world");
        Console.WriteLine();

        // 2
        TemperatureArray array = new TemperatureArray(15.5, 17.2, 20.1, 22.0, 18.4, 16.8, 14.3);
        array.Show();
        
        Console.WriteLine(array[0]);
        
        array[0] = 25.0;
        array.Show();
        Console.WriteLine(array.Average());
        Console.WriteLine();

        // 3
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(1, 3);
        
        Fraction result = f1 + f2;
        Console.WriteLine(result);

        Fraction result1 = f1 - f2;
        Console.WriteLine(result1);
        Console.WriteLine(f1 == f2);
    }
}
