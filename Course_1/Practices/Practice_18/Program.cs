using System;
using System.Linq;
using System.Collections.Generic;

namespace Practice_18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();

            Textbook t1 = new Textbook("Математика 101", "Иванов", 2020, 300, "Математика");
            FictionBook f1 = new FictionBook("Война и мир", "Толстой", 1869, 1200, "Роман");

            library.AddBook(t1);
            library.AddBook(f1);
            library.ListBooks();

            Reader reader = new Reader("Алексей", 1);

            library.IssueBook(t1, reader);
            reader.ShowTakedBooks();

            library.ListBooks();

            library.ReturnBook(t1);
            library.ListBooks();

            Publication pub = new BookPublication(f1);
            pub.GetInfo();
            
            library.ReserveBook(f1, reader, 26, 30);
            Reader reader2 = new Reader("Леха", 2);
            library.IssueBook(f1, reader2);
            library.IssueBook(f1, reader);
        }
    }
    
    public class PublishingHouse
    {
        public string Name { get; set; }

        public PublishingHouse(string name)
        {
            Name = name;
        }

        public void ShowInfo()
            => Console.WriteLine($"Издательство: {Name}");
    }
    public class Book
    {
        private string title;
        private string author;
        private int year;
        private int pages;

        public string Title
        {
            get => title;
            set
            {
                if (!string.IsNullOrEmpty(value)) title = value;
            }
        }
        public string Author
        {
            get => author;
            set
            {
                if (!string.IsNullOrEmpty(value)) author = value;
            }
        }
        public int Year
        {
            get => year;
            set
            {
                if (value > 0) year = value;
            }
        }
        public int Pages
        {
            get => pages;
            set
            {
                if (value > 0) pages = value;
            }
        }

        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public virtual void ShowInfo()
            => Console.WriteLine($"Книга: {Title}, Автор: {Author}, Год: {Year}, Страниц: {Pages}");
    }
    public class Textbook : Book
    {
        public string Subject { get; set; }

        public Textbook(string title, string author, int year, int pages, string subject)
            : base(title, author, year, pages)
        {
            Subject = subject;
        }

        public override void ShowInfo()
            => Console.WriteLine($"Учебник: {Title}, Предмет: {Subject}, Автор: {Author}, Год: {Year}, Страниц: {Pages}");
    }
    public class FictionBook : Book
    {
        public string Genre { get; set; }

        public FictionBook(string title, string author, int year, int pages, string genre)
            : base(title, author, year, pages)
        {
            Genre = genre;
        }

        public override void ShowInfo()
            => Console.WriteLine($"Художественная книга: {Title}, Жанр: {Genre}, Автор: {Author}, Год: {Year}, Страниц: {Pages}");
    }
    public class Reader
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private List<Book> takedBooks = new List<Book>();

        public Reader(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void TakeBook(Book book)
        {
            takedBooks.Add(book);
            Console.WriteLine($"{Name} взял книгу \"{book.Title}\"");
        }

        public void ShowTakedBooks()
        {
            Console.WriteLine($"Книги у {Name}:");
            foreach (var book in takedBooks)
                book.ShowInfo();
        }
    }
    public interface ILibraryManagement
    {
        void AddBook(Book book);
        bool RemoveBook(Book book);
        List<Book> SearchByAuthor(string author);
        void ListBooks();
    }
    public class Library : ILibraryManagement
    {
        private List<Book> books = new List<Book>();
        private List<Reservation> reservedBooks = new List<Reservation>();

        public void ReserveBook(Book book, Reader reader, int date, int term)
        {
            if (books.Contains(book))
            {
                reservedBooks.Add(new Reservation(book, reader, date, term));
                books.Remove(book);
                Console.WriteLine($"{reader.Name} зарезервировал книгу \"{book.Title}\"");
            }
        }
        public Reservation CheckReservedBooks(Book book)
        {
            foreach (Reservation reservation in reservedBooks)
            {
                if (reservation.ReservedBook == book)
                    return reservation;
            }
            return null;
        }
        public void EndReserve(Book book)
        {
            if (CheckReservedBooks(book) != null)
            {
                Console.WriteLine($"{CheckReservedBooks(book).Reserver.Name} закончил резерв книги \"{book.Title}\"");
                reservedBooks.Remove(CheckReservedBooks(book));
            }
        }
        
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Книга \"{book.Title}\" добавлена в библиотеку.");
        }
        public bool RemoveBook(Book book)
        {
            bool removed = books.Remove(book);
            if (removed)
                Console.WriteLine($"Книга \"{book.Title}\" удалена из библиотеки.");
            return removed;
        }

        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author == author).ToList();
        }
        public void ListBooks()
        {
            Console.WriteLine("Список книг в библиотеке:");
            foreach (var book in books)
                book.ShowInfo();
        }

        public void IssueBook(Book book, Reader reader)
        {
            if (books.Contains(book))
            {
                reader.TakeBook(book);
                books.Remove(book);
            }
            else if (CheckReservedBooks(book) != null && CheckReservedBooks(book).Reserver == reader)
            {
                reader.TakeBook(book);
                EndReserve(book);
            }
            else
            {
                if (CheckReservedBooks(book) != null)
                    Console.WriteLine($"Книга \"{book.Title}\" сейчас неходится в резерве.");
                else Console.WriteLine($"Книги \"{book.Title}\" сейчас нет в наличии.");
            }
        }
        public void ReturnBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Книга \"{book.Title}\" возвращена в библиотеку.");
        }
    }
    
    public abstract class Publication
    {
        public abstract void GetInfo();
    }

    public class BookPublication : Publication
    {
        private Book _book;

        public BookPublication(Book book)
            => _book = book;

        public override void GetInfo()
            => _book.ShowInfo();
    }

    public class Reservation
    {
        public Book ReservedBook { get; set; }
        public Reader Reserver { get; set; }
        public int Date { get; set; }
        public int ReserveTerm { get; set; }

        public Reservation(Book book, Reader reader, int date, int term)
        {
            ReservedBook = book;
            Reserver = reader;
            Date = date;
            ReserveTerm = term;
        }
    }
}