using BookManagerProject;

namespace BookLibrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myBook = new Book("Harry Potter", "Joahn Rowling", "Fantasy"); var myBook2 = new Book("Harry Potter 2", "Joahn Rowling", "Fantasy");
            Console.WriteLine($"{myBook.Title} by {myBook.Author}");
            Console.WriteLine($"{myBook2.Title} by {myBook2.Author}");
        }
    }
}