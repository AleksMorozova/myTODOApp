using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Service;

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMoviesService moviesService;
        public MoviesController(IMoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        [HttpGet("all")]
        public List<Movie> getToMoviesWatch()
        {
            return moviesService.getAllMovies();
        }

        [HttpPost("batchUpdate")]
        public void batchUpdate([FromBody] IEnumerable<Movie> movies)
        {
        }

        [HttpPost("update")]
        public void update([FromBody] Movie movie)
        {
            moviesService.watchMovie(movie);
        }

        [HttpPost("add")]
        public void add([FromBody] Movie movie)
        {
            moviesService.addMovie(movie);
        }
    }
}
