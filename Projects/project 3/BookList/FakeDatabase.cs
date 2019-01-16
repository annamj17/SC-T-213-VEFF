using System.Collections.Generic;
using BookList.Models;

namespace BookList
{
    public static class FakeDatabase
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book { Id = 1, Title = "Harry Potter and the chamber of secrets", Author = "J.K Rowling", Genre = "Fantasy" }, 
            new Book { Id = 2, Title = "Harry Potter and the golet of fire", Author = "J.K Rowling", Genre = "Fantasy" },
            new Book { Id = 3, Title = "Head first C#", Author = "Andrew Stellman", Genre = "Computer Science" },
            new Book { Id = 4, Title = "The Lord of the Rings: The Fellowship of the Ring", Author = "J.R.R Tolkien", Genre = "Fantasy" },
            new Book { Id = 5, Title = "Brave New World", Author = "Aldous Huxley", Genre = "Science Fiction" },
            new Book { Id = 6, Title = "Nineteen Eighty-Four", Author = "George Orwell", Genre = "Science Fiction" },
            new Book { Id = 7, Title = "Animal Farm", Author = "George Orwell", Genre = "Fiction" },
            new Book { Id = 8, Title = "Lord of the Flies", Author = "William Golding", Genre = "Fiction" },
            new Book { Id = 9, Title = "The Catcher in the Rye", Author = " J.D. Salinger", Genre = "Fiction" }
        };
    }
}