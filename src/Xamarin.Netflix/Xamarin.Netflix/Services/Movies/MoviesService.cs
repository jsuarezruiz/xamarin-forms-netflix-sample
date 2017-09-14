using System.Collections.ObjectModel;
using Xamarin.Netflix.Models;

namespace Xamarin.Netflix.Services.Movies
{
    public class MoviesService : IMoviesService
    {
        public ObservableCollection<Movie> GetMovies()
        {
            return new ObservableCollection<Movie>
            {
                new Movie { Title = "The pianist", Cover = "pianista.jpg", BackgroundImage = "pianistbackground.jpg", Year = 2002, Duration = "2h 30m", Description = "A brilliant pianist, a Polish Jew, witnesses the restrictions Germans place on Jews in the Polish capital, from restricted access to the building of the Warsaw ghetto. As his family is rounded up to be shipped off to the German Nazi labor camps, he escapes deportation and eludes capture by living in the ruins of Warsaw.", Rating = 8.0d },
                new Movie { Title = "Conan the Barbarian", Cover = "conan.jpg" },
                new Movie { Title = "Life is beautifull", Cover = "vidabella.jpg" },
                new Movie { Title = "Good Will Hunting", Cover = "indomable.jpg" },
                new Movie { Title = "Braveheart", Cover = "braveheart.jpg" },
                new Movie { Title = "Rocky", Cover = "rocky.jpg" }
            };
        }
    }
}