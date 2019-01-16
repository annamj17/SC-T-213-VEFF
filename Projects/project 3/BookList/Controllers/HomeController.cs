using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BookList.Models;
using BookList;
using System.Linq;

namespace BookList.Controllers
{

  public class HomeController : Controller
  {
   [HttpGet]
    public IActionResult Index(string genre) 
    {
      if (genre != null)
      {
        var filteredBooks = FakeDatabase.Books.Where(b => b.Genre.ToLower() == genre.ToLower());
        ViewBag.Title = genre;
        return View(filteredBooks.ToList());
      }
      ViewBag.Title = "Book List";
      return View(FakeDatabase.Books);
    }

    public IActionResult Details(int id)
    {
      Book book;
      for (int i = 0; i < FakeDatabase.Books.Count; i++)
      {
        if(FakeDatabase.Books[i].Id == id)
        {
          book = FakeDatabase.Books[i];
          return View(book);
        }
      }
      return View("NotFound");
    }

    [HttpGet]
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Book book)
    {
      var newBook = new Book() 
      {
        Id = FakeDatabase.Books.Count + 1,
        Title = book.Title,
        Author = book.Author,
        Genre = book.Genre
      };
      FakeDatabase.Books.Add(newBook);
      return RedirectToAction("Index");
    }
  }
}