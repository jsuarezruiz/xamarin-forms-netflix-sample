using System.Collections.ObjectModel;
using Xamarin.Netflix.Models;

namespace Xamarin.Netflix.Services.Movies
{
    public interface IMoviesService
    {
        ObservableCollection<Movie> GetMovies();
    }
}