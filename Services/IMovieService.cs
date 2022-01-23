using Jwt_Authentication.Models;

namespace Jwt_Authentication.Services
{
    public interface IMovieService
    {
        public Movie Create(Movie movie);
        public Movie Get(int id);
        public Movie Update(Movie movie);
        public List<Movie> List();
        public bool Delete(int id);
    }
}
