using MyToDoApp.Model;
using System.Collections.Generic;

namespace MyToDoApp.Repositories
{
    public interface ITVSeriesRepository
    {
        public List<TVSeries> getAllSeries()
        {
            TVSeries s = new TVSeries();
            s.Title = "Two broken girls";
            s.Description = "";
            s.Season = "3";
            s.Series = "7";
            s.Link = "link";
            return new List<TVSeries>() { s };
        }
    }
}
