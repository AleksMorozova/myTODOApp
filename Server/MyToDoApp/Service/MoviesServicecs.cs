using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public interface IMoviesService
    {
        List<Movie> getAllMovies();
        void watchMovie(Movie movie);
        void addMovie(Movie movie);
    }

    public class MoviesService: IMoviesService
    {

        private IMoviesRepository moviesRepository;
        public MoviesService(IMoviesRepository moviesRepository)
        {
            this.moviesRepository = moviesRepository;
        }

        public void addMovie(Movie movie)
        {
            this.moviesRepository.add(movie);
        }

        public List<Movie> getAllMovies()
        {
            return this.moviesRepository.getAllMovies();
        }

        public void watchMovie(Movie movie) {
            this.moviesRepository.update(movie);
        }
    }
}
