using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Services.Repositorio
{
    public class EFRepository : IMovieRepository
    {
        private readonly MvcMovieContext _context;

        public EFRepository()
        {
            string[] args = { "" };
            _context = new ContextoFactory().CreateDbContext(args);
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
            return await _context.Movie.ToListAsync();
        }

        public async Task<Movie?> GetById(int id)
        {
            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            return movie;
        }

        public Task Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}

