using System.Collections.Generic;

namespace Xamarin.Netflix.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Cover { get; set; }
        public string BackgroundImage { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }
        public List<Casting> Casting { get; set; }
    }
}