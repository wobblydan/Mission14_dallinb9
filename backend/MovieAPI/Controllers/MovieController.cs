﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieDbContext _context;

        public MovieController(MovieDbContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Movie> Get()
        {
            return _context.Movies
                .Where(x => x.Edited == "Yes")
                .OrderBy(x => x.Title)
                .ToArray();
        }
    }
}
