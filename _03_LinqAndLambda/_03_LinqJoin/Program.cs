using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LinqJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var authorList = new List<Author>();
            authorList.Add(new Author() { Id = 1, Name = "Tiago Barbosa" });
            authorList.Add(new Author() { Id = 2, Name = "Rakel Moreira" });
            authorList.Add(new Author() { Id = 3, Name = "Beatriz Lopez" });

            var bookList = new List<Book>();
            bookList.Add(new Book() { Id = 1, AuthorId = 2, Title = "Love in the air" });
            bookList.Add(new Book() { Id = 2, AuthorId = 2, Title = "I loved him" });
            bookList.Add(new Book() { Id = 3, AuthorId = 1, Title = "Life in Earth" });
            bookList.Add(new Book() { Id = 4, AuthorId = 3, Title = "Travel in New York" });
            bookList.Add(new Book() { Id = 5, AuthorId = 1, Title = "Exploring Mart" });
            bookList.Add(new Book() { Id = 6, AuthorId = 2, Title = "How to live in Italy" });

            var joinList = from books in bookList
                           join author in authorList on books.AuthorId equals author.Id
                           orderby author.Name, books.Title
                           select new { books, author };

            foreach (var item in joinList)
            {
                Console.WriteLine($"Book Title: {item.books.Title} - Author: {item.author.Name}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
