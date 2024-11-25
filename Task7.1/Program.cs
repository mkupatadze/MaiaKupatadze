// See https://aka.ms/new-console-template for more information
using Task7._1;



internal class Program
{
    static void Main(string[] args)
    {
        Book mybook = new Book("me vkhedav mzes", "nodar dumbadze", 1962, "Sakartvelo");
        Book mybook1 = new Book("me vkhedav mzes", "nodar dumbadze", 1962, "Sakartvelo");
        Book mybook2 = new Book("me", "nodar dumbadze", 1962, "Sakartvelo");
        Book mybook3 = new Book("mzes", "nodar dumbadze", 1962, "Sakartvelo");
        Book mybook4 = new Book("vkhedav", "nodar dumbadze", 1962, "Sakartvelo");
        Library library = new Library();

        library.AddBook(mybook);
        library.AddBook(mybook1);
        library.AddBook(mybook2);
        library.AddBook(mybook3);
        library.AddBook(mybook4);

        library.PrintBooks();
        Console.WriteLine($"Raodenoba - {library.Count}");
        library.RemoveBook("vkhedav");

        library.PrintBooks();

        var result = library.FindBooks("me vkhedav mzes");

        foreach (var book in result)
        {
            Console.WriteLine($"{book.Title}, {book.Author}, {book.Country}, {book.Year}");
        }
    }
}