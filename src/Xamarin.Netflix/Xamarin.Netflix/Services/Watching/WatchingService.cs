using System.Collections.ObjectModel;
using Xamarin.Netflix.Models;

namespace Xamarin.Netflix.Services.Watching
{
    public class WatchingService : IWatchingService
    {
        public ObservableCollection<TVShow> GetContinueWatching()
        {
            return new ObservableCollection<TVShow>
            {
                new TVShow { Title = "Narcos: T1:E1", Cover = "narcos.jpg" },
                new TVShow { Title = "The Defenders: T1:E1", Cover = "defenders.jpg" }
            };
        }
    }
}