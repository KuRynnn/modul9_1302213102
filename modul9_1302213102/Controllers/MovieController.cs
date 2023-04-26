using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302213102.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : ControllerBase
    {
        private static List<string> pemain1 = new List<string>
        {
           new string("Tim Robbins"),
           new string("Morgan Freeman"),
           new string("Bob Gunton"),
           new string("William Sadler")
        };
        private static List<string> pemain2 = new List<string>
        {
           new string("Marlon Brando"),
           new string("Al Pacino"),
           new string("James Caan"),
           new string("Diane Keaton")
        };
        private static List<string> pemain3 = new List<string>
        {
           new string("Christian Bale"),
           new string("Heath Ledger"),
           new string("Aaron Eckhart"),
           new string("Michael Caine")
        };
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", pemain1, "Over the course " +
                "of several years, two convicts form a friendship, seeking consolation and, eventually" +
                ", redemption through basic compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", pemain2, "The aging patriarch of " +
                "an organized crime dynasty in postwar New York City transfers control of his" +
                " clandestine empire to his reluctant youngest son."),
            new Movie("The Dark Knight", "Christopher Nolan", pemain3, "When the menace known" +
                " as the Joker wreaks havoc and chaos on the people of Gotham, Batman must " +
                "accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };

        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return Movies;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return Movies[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            Movies.Add(value);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Movies.RemoveAt(id);
        }
    }
}
