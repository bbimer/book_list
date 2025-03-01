using book_lst;

internal class Program
{
    static void Main(string[] args)
    {
        book_list obj = new book_list();
        obj = obj + "hello";
        obj = obj + "world";
        obj.print();

        obj = obj - 0;
        Console.WriteLine();
        obj.print();

        Console.WriteLine(obj == "world");
    }
}
