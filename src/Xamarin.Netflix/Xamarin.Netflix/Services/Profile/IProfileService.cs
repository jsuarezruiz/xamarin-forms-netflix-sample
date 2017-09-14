using System.Collections.ObjectModel;

namespace Xamarin.Netflix.Services.Profile
{
    public interface IProfileService
    {
        ObservableCollection<Models.Profile> GetProfiles();
    }
}
