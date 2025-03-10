using Microsoft.AspNetCore.Mvc;
using WebServerHW1_MoviesProject.Models.Concrete;

namespace WebServerHW1_MoviesProject.Controllers
{
    public class MovieController : Controller
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie
            {
                Id = new Guid(),
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new string[] { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                ReleaseYear = 1994,
                ImageUrl = "https://www.imdb.com/title/tt0111161/mediaviewer/rm4263220224/"
            },
            new Movie
            {
                Id = new Guid(),
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new string[] { "Marlon Brando", "Al Pacino", "James Caan" },
                ReleaseYear = 1972,
                ImageUrl = "https://www.imdb.com/title/tt0068646/mediaviewer/rm4263220224/"
            },
            new Movie
            {
                Id = new Guid(),
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new string[] { "Christian Bale", "Heath Ledger", "Aaron Eckhart" },
                ReleaseYear = 2008,
                ImageUrl = "https://www.imdb.com/title/tt0468569/mediaviewer/rm4263220224/"
            },

            new Movie
            {
                Id = new Guid(),
                Title = "The Lord of the Rings: The Return of the King",
                Director = "Peter Jackson",
                Stars = new string[] { "Elijah Wood", "Viggo Mortensen", "Ian McKellen" },
                ReleaseYear = 2003,
                ImageUrl = "https://www.imdb.com/title/tt0167260/mediaviewer/rm4263220224/"
            },
            new Movie
            {
                Id = new Guid(),
                Title = "Pulp Fiction",
                Director = "Quentin Tarantino",
                Stars = new string[] { "John Travolta", "Uma Thurman", "Samuel L. Jackson" },
                ReleaseYear = 1994,
                ImageUrl = "https://www.imdb.com/title/tt0110912/mediaviewer/rm4263220224/"
            }
        };
            
        public IActionResult Index()
        {
            return View(_movies);
        }



        
    }
}
