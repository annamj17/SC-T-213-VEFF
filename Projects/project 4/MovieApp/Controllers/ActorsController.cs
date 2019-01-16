using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Models.EntityModels;
using MovieApp.Models.ViewModels;
namespace MovieApp.Controllers
{

    public class ActorsController : Controller
    {
        public IActionResult Index()
        {
            var actor = (from a in FakeDatabase.Actors
                        select new ActorViewModel
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Age = a.Age,
                        }).ToList();
            if (actor == null)
            {
                return View("NotFound");
            }
        return View(actor);
        }
        public IActionResult Details(int id)
        {
            var actor = (from a in FakeDatabase.Actors
                        where a.Id == id
                        select new ActorDetailsViewModel
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Age = a.Age,
                            Movies = (from m in FakeDatabase.Movies
                                      join ma in FakeDatabase.ActorsInMovies on m.Id equals ma.MovieId
                                      where m.Id == ma.MovieId && a.Id == ma.ActorId
                                      select m).ToList()
                        }).SingleOrDefault();
            return View(actor);
        }
      }
    }