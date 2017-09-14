using System.Threading.Tasks;
using Xamarin.Netflix.Models;
using Xamarin.Netflix.Services.Navigation;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private MenuViewModel _menuViewModel;

        private INavigationService _navigationService;

        public MainViewModel(
         INavigationService navigationService,
         MenuViewModel menuViewModel)
        {
            _navigationService = navigationService;
            _menuViewModel = menuViewModel;
        }

        public MenuViewModel MenuViewModel
        {
            get
            {
                return _menuViewModel;
            }

            set
            {
                _menuViewModel = value;
                OnPropertyChanged();
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            return Task.WhenAll
                (
                    _menuViewModel.InitializeAsync(navigationData),
                    _navigationService.NavigateToAsync<HomeViewModel>()
                );
        }
    }
}