using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Netflix.Models;
using Xamarin.Netflix.Services.Movies;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        private Movie _movie;
        private ObservableCollection<Movie> _similarMovies;

        private IMoviesService _moviesService;
        
        public DetailViewModel(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        } 

        public Movie Movie
        {
            get { return _movie; }
            set
            {
                _movie = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Movie> SimilarMovies
        {
            get { return _similarMovies; }
            set
            {
                _similarMovies = value;
                OnPropertyChanged();
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            if(navigationData is Movie)
            {
                Movie = (Movie)navigationData;
            }

            SimilarMovies = _moviesService.GetMovies();

            return base.InitializeAsync(navigationData);
        }
    }
}