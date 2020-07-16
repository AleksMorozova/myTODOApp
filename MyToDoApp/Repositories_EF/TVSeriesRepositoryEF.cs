using EF.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories_EF
{
    public class TVSeriesRepositoryEF: ITVSeriesRepository
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
