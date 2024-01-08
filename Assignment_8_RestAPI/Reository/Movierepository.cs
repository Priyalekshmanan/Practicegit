using Assignment_8_RestAPI.Model;
using System.IO;

namespace Assignment_8_RestAPI.Reository
{
    public class Movierepository : IMovierepository
    {
        public static List<Movie> movies = new List<Movie>();
        
     

        public void AddMovie(Movie movie)
        {
			try
			{
                movies.Add(movie);

            }
			catch (Exception)
			{

				throw;
			}
        }
       /* public void RemoveMovie(int Movie_id)
        {
			try
			{
                foreach (var movie in movies)
                {
                    if (movie.Movie_id == Movie_id)
                    {
                        movies.Remove(movie);
                    }
                }
            }
			catch (Exception)
			{

				throw;
			}
        }*/
        public List<Movie> GetAllMovies()
        {
            try
            {
                return movies;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Movie> GetMovieByName(string Movie_name) 
        {
            try
            {

                List<Movie> GetMovieByName = new List<Movie>();
                foreach (var item in movies)
                {
                    if (item.Movie_name ==Movie_name)
                        GetMovieByName.Add(item);
                }
                return GetMovieByName;
            }
            catch (Exception)
            {

                throw;
            }


        }
        public List<Movie> GetMovieByActor(string actor)
        {
            try
            {
                List<Movie> GetMovieByActor = new List<Movie>();
                foreach (var item in movies)
                {
                    if (item.Actor == actor)
                        GetMovieByActor.Add(item);
                }
                return GetMovieByActor;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Movie> GetMovieByYear(int year)
        {
            try
            {

                List<Movie> GetMovieByYear = new List<Movie>();
                foreach (var item in movies)
                {
                    if (item.ReleaseYear == year)

                        GetMovieByYear.Add(item);
                }
                return GetMovieByYear;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<Movie> GetMovieByDirector(string Director)
        {
            try
            {

                List<Movie> GetMovieByDirector = new List<Movie>();
                foreach (var item in movies)
                {
                    if (item.Language == Director)
                        GetMovieByDirector.Add(item);
                }
                return GetMovieByDirector;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
