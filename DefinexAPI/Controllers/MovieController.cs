using DefinexAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DefinexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieDbContext _context;
        //constructor injection
        public MovieController(MovieDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            //List<Movie> movieList;
            //movieList= await _context.Movies.ToListAsync();
            return await _context.Movies.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieDetails(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if(movie == null)
            {
                return NotFound();
            }
            return movie;
        }
    }
}
