using System.Runtime.InteropServices;

namespace Biblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.Write("How many books: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Book book = new Book();
                Console.Write("Enter title: ");
                book.title = Console.ReadLine();
                Console.Write("Enter author: ");
                book.author = Console.ReadLine();
                Console.Write("Enter jenre: ");
                book.jenre = Console.ReadLine();
                book.Onstock = true;
                library.Spisak.Add(book);
            }
        }
    }
}
