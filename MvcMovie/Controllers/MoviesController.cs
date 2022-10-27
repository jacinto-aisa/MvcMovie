using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using MvcMovie.Services.Repositorio;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _context;

        public MoviesController(IMovieRepository context)
        {
            _context = context;
        }



        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetAll());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var movie = await _context.GetById(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

    }
}

