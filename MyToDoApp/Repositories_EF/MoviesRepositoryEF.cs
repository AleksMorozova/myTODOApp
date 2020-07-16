using EF;
using MyToDoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyToDoApp.Converters;
namespace MyToDoApp.Repositories
{
    public class MoviesRepositoryEF: IMoviesRepository
    {
        ApplicationContext context;

        public MoviesRepositoryEF(ApplicationContext context)
        {
            this.context = context;
        }
        public List<Movie> getAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            foreach (EF.Model.Movie movie in context.Movies)
            {
                movies.Add(MovieConverter.convertFromDTO(movie));
            }

            return movies;
        }
        public void update(Movie movie)
        {
            var m = context.Movies.Where(m => movie.ID == m.ID).First();
            m.isWatched = movie.IsWatched;
            m.Link = movie.Link;
            m.Title = movie.Title;
            m.Description = movie.Description;
            context.SaveChanges();
        }
        public void add(Movie movie)
        {
            using (var c = context)
            {
                c.Movies.Add(Converters.MovieConverter.convertToDTO(movie));
                c.SaveChanges();
            }
        }
    }
}
