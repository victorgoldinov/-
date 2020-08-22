using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyClass
{
    public class Book
    {
        public String Author { get; set; }
        public String Name { get; set; }
        public String Year { get; set; }
        public String PublishingHouse { get; set; }

        public Book(string author, string name, string year, string publishingHouse)
        {
            Author = author;
            Name = name;
            Year = year;
            PublishingHouse = publishingHouse;
        }
        ~Book()
        {
            Author = null;
            Name = null;
            Year = null;
            PublishingHouse = null;
        }
    }
    public class Textbook : Book
    {
        public Textbook(string author, string name, string year, string publishingHouse, string subject, string @class)
            : base(author, name, year, publishingHouse)
        {
            Subject = subject;
            Class = @class;
        }
        ~Textbook()
        {
            Subject = null;
            Class = null;
        }
        public String Subject { get; set; }
        public String Class { get; set; }
    }
    public class ArtBook : Book
    {
        public ArtBook(string author, string name, string year, string publishingHouse, string genre)
            : base(author, name, year, publishingHouse)
        {
            Genre = genre;
        }
        ~ArtBook()
        {
            Genre = null;
        }
        public String Genre { get; set; }
    }
    public class Reader
    {
        public String SecondName { get; set; }
        public String FirstName { get; set; }
        public Int64 YearOfBirth { get; set; }
        public String Address { get; set; }
        public String BookName { get; set; }
        public DateTime? Date { get; set; }
        public Reader(string secondName, string firstName, int yearOfBirth, string address, string bookName, DateTime date)
        {
            SecondName = secondName;
            FirstName = firstName;
            YearOfBirth = yearOfBirth;
            Address = address;
            BookName = bookName;
            Date = date;
        }
        ~Reader()
        {
            SecondName = null;
            FirstName = null;
            YearOfBirth = 0;
            Address = null;
            BookName = null;
            Date = null;
        }
        public Reader Filling()
        {
            var r = new Reader("Иванов", "Иван", 2005, "ул. Советская, дом 10, квартира 1", "C# для чайников", new DateTime());
            return r;
        }
    }
    class Program
    {
        static void Main()
        {
            var r = new Reader("Иванов", "Иван", 2005, "ул. Советская, дом 10, квартира 1", "C# для чайников", new DateTime());
            Console.WriteLine(r.SecondName + " " + r.FirstName + " " + r.YearOfBirth + " " + r.Address + " " + r.BookName + " " + r.Date);
            Console.ReadKey();
        }
    }
}
