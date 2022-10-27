using MvcMovie.Models;

namespace MvcMovie.Services.Repositorio
{
    public class FakeRepository : IMovieRepository
    {
        private readonly List<Movie> movies;
        public FakeRepository()
        {
            movies = new List<Movie>();
            movies.Add(new Movie() { Id=1,Genre="Ficcion",ReleaseDate=DateTime.Now,Price=78,Title="Avatar1"});
            movies.Add(new Movie() { Id = 2, Genre = "Ficcion", ReleaseDate = DateTime.Now, Price = 88, Title = "Avatar2" });
            movies.Add(new Movie() { Id = 3, Genre = "Ficcion", ReleaseDate = DateTime.Now, Price = 98, Title = "Avatar3" });

        }
        public Task Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Movie>> GetAll()
        { 
            return await Task.Run(()=>movies);
        }

        public async Task<Movie?> GetById(int id)
        {
            return await Task.Run(()=>movies.Find(x => x.Id == id));    
        }

        public Task Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
