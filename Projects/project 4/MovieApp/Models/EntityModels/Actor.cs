using System.ComponentModel.DataAnnotations;
namespace MovieApp.Models.EntityModels
{

    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}