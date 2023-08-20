using System.Runtime.CompilerServices;
using task_sinif;

internal class Program
{
    private static void Main(string[] args)
    {
        book book = new book("qorxu", "bb203", 1, 10);
        book book1 = new book("action", "sefiller", 2, 5);
        book book2 = new book("dram", "jack London", 5, 8);

        Library library = new Library();
        library.AddBook(book);
        library.AddBook(book1);
        library.AddBook(book2);


        foreach(var item in library.books)
        {
            Console.WriteLine(item.Janr);
            Console.WriteLine(item.Name);
            Console.WriteLine(item.No);
            Console.WriteLine(item.Price);
        }




    }




}