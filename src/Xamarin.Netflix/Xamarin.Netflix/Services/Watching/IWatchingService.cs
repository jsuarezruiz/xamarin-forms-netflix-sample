using System.Collections.ObjectModel;
using Xamarin.Netflix.Models;

namespace Xamarin.Netflix.Services.Watching
{
    public interface IWatchingService
    {
        ObservableCollection<TVShow> GetContinueWatching();
    }
}