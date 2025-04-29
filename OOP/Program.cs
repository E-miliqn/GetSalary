using System.Runtime.CompilerServices;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете брой книги:");
            sbyte n = sbyte.Parse(Console.ReadLine());
            Books[] books = BooksInformation(n);
            Print(books);
        }
        static Books[] BooksInformation(sbyte n)
        {
            Books[] books = new Books[n];
            Console.WriteLine("Въведи <заглавие><автор><година на издава><в наличност>(True/False)");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}.Книга:");
                string[] infoparts = Console.ReadLine().Split(' ');
                string title = infoparts[0];
                string author = infoparts[1];
                short year = short.Parse(infoparts[2]);
                bool isAvailiable = bool.Parse(infoparts[3]);
                books[i] = new Books(title,author,year,isAvailiable);
            }

            return books;
        }
        static void Print(Books[] book)
        {
            for (int i = 0; i < book.Length;i++)
            {

                Console.WriteLine($"{book[i].Title}, {book[i].Author}, {book[i].Year}, {book[i].IsAvailable}");
                Console.WriteLine("============================================================");
            }
        }
    }
}
