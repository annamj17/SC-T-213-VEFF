namespace MovieApp.Models.EntityModels
{

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public int Runtime { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
        public double Rating { get; set; }

    }
}