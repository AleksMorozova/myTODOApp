using System.Collections.Generic;
using MyToDoApp.Model;
using MyToDoApp.Repositories;

namespace MyToDoApp.Service
{
    public interface ITVSeriesService {
        List<TVSeries> getAllSeries();
    }
    public class TVSeriesService: ITVSeriesService
    {
        private ITVSeriesRepository tvSeriesRepository;

        public TVSeriesService(ITVSeriesRepository tvSeriesRepository)
        {
            this.tvSeriesRepository = tvSeriesRepository;
        }

        public List<TVSeries> getAllSeries() {
            return this.tvSeriesRepository.getAllSeries();
        }
    }
}
