using System.Collections.Generic;

namespace Xamarin.Netflix.Models
{
    public class Season
    {
        public int TVShowId { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}
