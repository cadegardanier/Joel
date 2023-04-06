using Microsoft.AspNetCore.Mvc;
using JoelAPI.Models;

namespace JoelAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;
        public MovieController(MovieDbContext temp)
        {
            context = temp;
        }
        public IEnumerable<Movie> Get()
        {
            var x = context.Movies.ToArray();

            return context.Movies
                .Where(x => x.Edited == "Yes" ).OrderBy(x => x.Title).ToArray();
        }
    }
}
