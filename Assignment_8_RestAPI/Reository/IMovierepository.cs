using Assignment_8_RestAPI.Model;

namespace Assignment_8_RestAPI.Reository
{
    public interface IMovierepository
    {
        void AddMovie(Movie movie);
        List<Movie> GetAllMovies();

        List<Movie> GetMovieByName(string Movie_name);
        List<Movie> GetMovieByActor(string Actor);

        List<Movie> GetMovieByYear(int ReleaseYear);

        List<Movie> GetMovieByDirector(string Director);
        //void RemoveMovie (int Movie_id);


    }
}
