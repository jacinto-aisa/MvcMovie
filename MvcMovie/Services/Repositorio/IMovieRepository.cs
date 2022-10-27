using MvcMovie.Models;

namespace MvcMovie.Services.Repositorio
{
    public interface IMovieRepository
    {
        public Task<List<Movie>> GetAll();
        public Task<Movie?> GetById(int id);
        public Task Update(Movie movie);
        public Task DeleteById(int id);
        public Task Add(Movie movie);
    }
}
