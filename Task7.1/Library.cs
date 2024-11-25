namespace Task7._1
{
    public class Library
    {
        private List<Book> mybooks = new List<Book>();
        public int Count => mybooks.Count;

        public void PrintBooks()
        {
            foreach (var book in mybooks)
            {
                Console.WriteLine($"{book.Title}, {book.Author}, {book.Country}, {book.Year}");
            }
        }
        public void AddBook(Book book)
        {
            mybooks.Add(book);
        }
        public bool RemoveBook(string title)
        {
            foreach (var book in mybooks)
            {
                if (book.Title == title)
                {
                    mybooks.Remove(book);
                    return true;
                }
            }

            return false;
        }

        public List<Book> FindBooks(string title)
        {
            var result = new List<Book>();

            foreach (var book in mybooks)
            {
                if (book.Title == title)
                {
                    result.Add(book);
                }
            }

            return result;
        }
    }
}
