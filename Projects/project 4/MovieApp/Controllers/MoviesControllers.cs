using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.EntityModels;
using MovieApp.Models.ViewModels;
using MovieApp.Models.InputModels;
namespace MovieApp.Controllers

{
    public class MoviesController : Controller
    {
        public IActionResult Index(string Searchtext)
        {
          if(Searchtext == null)
          {
              var movies = (from m in FakeDatabase.Movies
                            select new MovieViewModel
                            {
                                Id = m.Id,
                                Title = m.Title,
                                Genre = m.Genre,
                                Rating = m.Rating
                            }).ToList();
              return View(movies);
        }
        else
        {
            var filteredMovies = (from m in FakeDatabase.Movies
                                  where m.Title.ToLower().Contains(Searchtext.ToLower())
                                  select new MovieViewModel
                                  {
                                      Id = m.Id,
                                      Title = m.Title,
                                      Genre = m.Genre,
                                      Rating = m.Rating
                                  }).ToList();

            return View(filteredMovies.ToList());
        }
      }
      public IActionResult Details(int? id)
      {
        if(id == null)
        {
          return View("Notfound");
        }
        var movie = (from m in FakeDatabase.Movies
                    where m.Id == id
                    select new MovieDetailsViewModel
                    {
                      Id = m.Id,
                      Title = m.Title,
                      ReleaseYear = m.ReleaseYear,
                      Runtime = m.Runtime,
                      Genre = m.Genre,
                      Image = m.Image,
                      Rating = m.Rating,
                      Actors = (from a in FakeDatabase.Actors
                                join am in FakeDatabase.ActorsInMovies on a.Id equals am.ActorId
                                where a.Id == am.ActorId && m.Id == am.MovieId
                                select a).ToList()
                      }).SingleOrDefault();
        if(movie == null)
        {
            return View("Notfound");
        }
        return View(movie);
      }

      [HttpGet]
      public IActionResult Create()
      {
          return View();
      }

      [HttpPost]
      public IActionResult Create(MovieInputModel movie)
      {
          if(ModelState.IsValid)
          {
              var newMovie = new Movie()
              {
                  Id = FakeDatabase.Movies.Count + 1,
                  Title = movie.Title,
                  Genre = movie.Genre,
                  ReleaseYear = (int)movie.ReleaseYear,
                  Runtime = (int)movie.Runtime
              };
              FakeDatabase.Movies.Add(newMovie);
              return RedirectToAction("Index");
          }
      return View();
      }

      public IActionResult TopMovies()
      {
          var movies = (from m in FakeDatabase.Movies
                        orderby m.Rating descending
                        select new MovieViewModel
                        {
                            Id = m.Id,
                            Title = m.Title,
                            Genre = m.Genre,
                            Rating = m.Rating
                        }).Take(5).ToList();

          return View(movies);
      }

    }

}
