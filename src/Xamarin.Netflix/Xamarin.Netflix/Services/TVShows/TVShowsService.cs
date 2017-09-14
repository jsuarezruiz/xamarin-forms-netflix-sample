using System.Collections.ObjectModel;
using Xamarin.Netflix.Models;

namespace Xamarin.Netflix.Services.TVShows
{
    public class TVShowsService : ITVShowsService
    {
        public ObservableCollection<TVShow> GetTVShows()
        {
            return new ObservableCollection<TVShow>
            {
                new TVShow { Title = "Ozark", Cover = "ozark.jpg" },
                new TVShow { Title = "Orphan Black", Cover = "orphan.jpg" },
                new TVShow { Title = "BoJack", Cover = "bojack.jpg" },
                new TVShow { Title = "Family Guy", Cover = "familyguy.jpg" }
            };
        }
    }
}