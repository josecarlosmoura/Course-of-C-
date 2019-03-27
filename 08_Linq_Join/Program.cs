using _08_Linq_Join.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Linq_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> listOfBooks = new List<Book>();
            listOfBooks.Add(new Book() { Id = 1, IdAuthor = 2, Title = "Amor amado" });
            listOfBooks.Add(new Book() { Id = 2, IdAuthor = 2, Title = "Bem amado" });
            listOfBooks.Add(new Book() { Id = 3, IdAuthor = 3, Title = "Um espiao em Uberlândia" });
            listOfBooks.Add(new Book() { Id = 4, IdAuthor = 4, Title = "A vida na terra" });

            List<Author> listOfAuthor = new List<Author>();
            listOfAuthor.Add(new Author() { Id = 1, Name = "Leonardo" });
            listOfAuthor.Add(new Author() { Id = 2, Name = "Maria Maria" });
            listOfAuthor.Add(new Author() { Id = 3, Name = "José Carlos" });

            var ListOfJoin = from books in listOfBooks join author in listOfAuthor
                             on books.IdAuthor equals author.Id
                             select new { books, author };

            foreach (var item in ListOfJoin)
            {
                Console.WriteLine($"Book: {item.books.Title} - " +
                    $"Author: {item.author.Name}");
            }

            Console.ReadKey();
        }
    }
}
