using System;
using System.Linq;

namespace Task_6
{
    internal class Book
    {
        public int NumOfPages { get; }
        public int SectionNumber { get; set; }

        public Book(int numOfPages)
        {
            NumOfPages = numOfPages;
        }

        public override string ToString()
        {
            return $"Number of pages: {NumOfPages}; Section number: {SectionNumber}";
        }
    }
    internal class Library
    {
        private static readonly Random Random = new Random();

        public Book[] Books = new Book[0];
        public int NumOfBooks => Books.Length;
        public Book this[int index] => Books[index];

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            book.SectionNumber = Random.Next(5, 11);
            Books[^1] = book;
        }

        public Book[] GetBooksWithTheLessAmountOfPages(int n)
        {
            return Books.Where(book => book.NumOfPages < n).ToArray();
        }

        public override string ToString()
        {
            return $"Number of books: {NumOfBooks}; " +
                   $"Amount books' pages: {Books.Sum(book=>book.NumOfPages)} ";
        }
    }
    internal static class Program
    {
        private static readonly Random Random = new Random();
        private static void Main()
        {
            var library = new Library();
            var books = GenerateBooks();
            foreach (var book in books)
            {
                library.AddBook(book);
            }

            Console.WriteLine(library);
            foreach (var book in library.Books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();
            Console.WriteLine("Books which number of pages less than 200.");

            foreach (var book in library.GetBooksWithTheLessAmountOfPages(200))
            {
                Console.WriteLine(book);
            }
        }

        private static Book[] GenerateBooks()
        {
            var books = new Book[Random.Next(10,21)];
            for (var i = 0; i < books.Length; i++)
            {
                books[i] = new Book(Random.Next(1,501));
            }

            return books;
        }
    }
}
