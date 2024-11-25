namespace Task7._1
{
    public class Book
    {
        public string Title { get; set; }   

        public string Author { get; set; }

        public int Year { get; set; }

        public string Country { get; set; }

        public Book(string title, string author, int year, string country)
        {
            Title = title;
            Author = author;
            Year = year;
            Country = country;

        }
    }   
}