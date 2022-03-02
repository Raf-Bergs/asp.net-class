﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovie.Data;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            var movies = _context.Movies.OrderBy(m => m.Title);

            return View(movies.ToList());
        }

        public IActionResult Details(int id)
        {
            var movie = _context.Movies
                            .Include(m => m.Rating)
                            .SingleOrDefault(m => m.MovieID == id);

            return View(movie);
        }
    }
}
