using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Netflix.Models;
using Xamarin.Netflix.Services.Movies;
using Xamarin.Netflix.Services.Navigation;
using Xamarin.Netflix.Services.TVShows;
using Xamarin.Netflix.Services.Watching;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ObservableCollection<Movie> _movies;
        private ObservableCollection<TVShow> _tvShows;
        private ObservableCollection<TVShow> _watching;
 
        private IMoviesService _moviesService;
        private ITVShowsService _tvShowsService;
        private IWatchingService _watchingService;
        private INavigationService _navigationService;

        public HomeViewModel(
            IMoviesService moviesService,
            ITVShowsService tvShowsService,
            IWatchingService watchingService,
            INavigationService navigationService)
        {
            _moviesService = moviesService;
            _tvShowsService = tvShowsService;
            _watchingService = watchingService;
            _navigationService = navigationService;
        }

        public ObservableCollection<Movie> Movies
        {
            get { return _movies; }
            set
            {
                _movies = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TVShow> TvShows
        {
            get { return _tvShows; }
            set
            {
                _tvShows = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TVShow> Watching
        {
            get { return _watching; }
            set
            {
                _watching = value;
                OnPropertyChanged();
            }
        }

        public ICommand DetailCommand => new Command<Movie>(DetailAsync);

        public override Task InitializeAsync(object navigationData)
        {
            Movies = _moviesService.GetMovies();
            TvShows = _tvShowsService.GetTVShows();
            Watching = _watchingService.GetContinueWatching();

            return base.InitializeAsync(navigationData);
        }

        private async void DetailAsync(Movie movie)
        {
            if (movie != null)
            {
                await _navigationService.NavigateToAsync<DetailViewModel>(movie);
            }
        }
    }
}