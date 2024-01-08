using Assignment_8_RestAPI.Model;
using Assignment_8_RestAPI.Reository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_8_RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        /*List<Movie> movies = new List<Movie>(){

            new Movie(){Movie_name="Hi Naana", Language="Tamil", ReleaseYear= 2023, Actor="Naani", Director="James" },

             new Movie(){Movie_name="Jailer", Language="Tamil", ReleaseYear=2022, Actor="Rajini", Director="Nelson" },
              new Movie(){Movie_name="leo", Language="Tamil", ReleaseYear=2022, Actor="Naani", Director="Loki" }

        };*/
        private readonly IMovierepository movierepository;

        public MovieController(IMovierepository movierepository)
        {
            this.movierepository = movierepository;
        }
        //public MovieController()
        //{
        //    movierepository = new Movierepository();
        //}
        //endpoints
        [HttpGet("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            try
            {
                List<Movie> movies = movierepository.GetAllMovies();
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        //
        [HttpGet("GetMovieByname/{Movie_name}")]
        public IActionResult GetMovieByName(string Movie_name)
        {
            try
            {
                return StatusCode(200, movierepository.GetMovieByName(Movie_name));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPost("AddMovie")]
        public IActionResult Add(Movie movies)
        {
            try
            {
                movierepository.AddMovie(movies);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetMovieByActor/{Actor}")]
        public IActionResult GetMovieByActor(string Actor)
        {
            try
            {
                return StatusCode(200, movierepository.GetMovieByActor(Actor));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetByMovieYear")]
        public IActionResult GetMovieByYear(int year)
        {
            try
            {
                return StatusCode(200, movierepository.GetMovieByYear(year));

            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet("GetMovieBydirector/{Director }")]
        public IActionResult GetMovieByname(string Director)
        {
            try
            {
                return StatusCode(200, movierepository.GetMovieByDirector(Director));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        /*[HttpDelete("RemoveMovie/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                movierepository.RemoveMovie(id);
                return StatusCode(200, "Movie deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }*/
    }
}
