using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Netflix.Models;
using Xamarin.Netflix.Services.Navigation;
using Xamarin.Netflix.Services.Profile;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private ObservableCollection<Profile> _profiles;

        private IProfileService _profileService;
        private INavigationService _navigationService;

        public LoginViewModel(
            IProfileService profileService,
            INavigationService navigationService)
        {
            _profileService = profileService;
            _navigationService = navigationService;
        }

        public ObservableCollection<Profile> Profiles
        {
            get { return _profiles; }
            set
            {
                _profiles = value;
                OnPropertyChanged();
            }
        }

        public ICommand HomeCommand => new Command<Profile>(HomeAsync);

        public override Task InitializeAsync(object navigationData)
        {
            Profiles = _profileService.GetProfiles();

            return base.InitializeAsync(navigationData);
        }

        private async void HomeAsync(Profile profile)
        {
            if(profile != null && profile.ProfileType == ProfileType.Profile)
            {
                await _navigationService.NavigateToAsync<MainViewModel>(profile);
            }
        }
    }
}