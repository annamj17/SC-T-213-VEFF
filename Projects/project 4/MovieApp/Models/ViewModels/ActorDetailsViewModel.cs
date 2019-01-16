using System.Collections.Generic;
using MovieApp.Models.EntityModels;
namespace MovieApp.Models.ViewModels
{
    public class ActorDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Movie> Movies { get; set; }
    }
}