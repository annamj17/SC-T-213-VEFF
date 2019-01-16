using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models.InputModels
{
    public class MovieInputModel
    {
        [Required (ErrorMessage = "A movie title is required")]
        public string Title { get; set; }

        [Required (ErrorMessage = "Genre is required")]
        public string Genre { get; set; }

        [Required (ErrorMessage = "Please enter a release year from 0-2030!")]
        [Range (0, 2030)]
        public int? ReleaseYear { get; set; }

        [Required (ErrorMessage = "Runtime is required")]
        public int? Runtime { get; set; }
    }
}
