using System.Collections.ObjectModel;
using Xamarin.Netflix.Models;

namespace Xamarin.Netflix.Services.TVShows
{
    public interface ITVShowsService
    {
        ObservableCollection<TVShow> GetTVShows();
    }
}