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

        public async Task Add(Movie movie)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            if (_context.Movie is not null)
            {
                var elemento = await GetById(id);
                if (elemento != null)
                {
                    _context.Movie.Remove(elemento);
                    _context.SaveChanges();
                }
            }
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

        public async Task Update(Movie movie)
        {
            _context.Update(movie);
            await _context.SaveChangesAsync();
        }
    }
}

