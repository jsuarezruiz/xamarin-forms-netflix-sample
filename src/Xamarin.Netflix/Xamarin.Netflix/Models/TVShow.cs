using System.Collections.Generic;

namespace Xamarin.Netflix.Models
{
    public class TVShow
    {
        public int TVShowId { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int SeasonsCount { get; set; }
        public List<Season> Seasons { get; set; }
        public int Year { get; set; }
        public List<Casting> Casting { get; set; }
    }
}