using System.Collections.ObjectModel;

namespace Xamarin.Netflix.Services.Profile
{
    public class ProfileService : IProfileService
    {
        public ObservableCollection<Models.Profile> GetProfiles()
        {
            return new ObservableCollection<Models.Profile>
            {
                new Models.Profile { Name = "jsuarezruiz", Picture = "profile1.png", ProfileType = Models.ProfileType.Profile },
                new Models.Profile { Name = "mon & dad", Picture = "profile2.png", ProfileType = Models.ProfileType.Profile },
                new Models.Profile { Name = "office", Picture = "profile3.png", ProfileType = Models.ProfileType.Profile },
                new Models.Profile { Name = "other", Picture = "profile4.png", ProfileType = Models.ProfileType.Profile },
                new Models.Profile { Name = "Add profile", Picture = "add.png", ProfileType = Models.ProfileType.NewProfile },
                new Models.Profile { ProfileType = Models.ProfileType.None }
            };
        }
    }
}