using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Netflix.Models;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        private ObservableCollection<MenuItem> _menuItems;
        private Profile _profile;

        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>();
        }

        public ObservableCollection<MenuItem> MenuItems
        {
            get
            {
                return _menuItems;
            }
            set
            {
                _menuItems = value;
                OnPropertyChanged();
            }
        }

        public Profile Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged();
            }
        }

        public override Task InitializeAsync(object navigationData)
        {
            if(navigationData is Profile)
            {
                Profile = (Profile)navigationData;
            }

            InitMenuItems();

            return base.InitializeAsync(navigationData);
        }
        private void InitMenuItems()
        {
            MenuItems.Add(new MenuItem
            {
                Title = "My downloads",
                Icon = "download",
                MenuItemType = MenuItemType.MyDownloads,
                IsEnabled = false,
                Separator = true
            });

            MenuItems.Add(new MenuItem
            {
                Title = "My list",
                Icon = "check",
                MenuItemType = MenuItemType.List,
                IsEnabled = false,
                Separator = true
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Home",
                MenuItemType = MenuItemType.Home,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Available for download",
                MenuItemType = MenuItemType.AvailableDownload,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Netflix",
                MenuItemType = MenuItemType.Netflix,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "TV Shows",
                MenuItemType = MenuItemType.TVShow,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Action",
                MenuItemType = MenuItemType.Action,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Anime",
                MenuItemType = MenuItemType.Anime,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Science Fiction",
                MenuItemType = MenuItemType.ScienceFiction,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Classics",
                MenuItemType = MenuItemType.Classic,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Comedy",
                MenuItemType = MenuItemType.Comedy,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Documentals",
                MenuItemType = MenuItemType.Documental,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Dramas",
                MenuItemType = MenuItemType.Drama,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Independients",
                MenuItemType = MenuItemType.Independient,
                IsEnabled = false,
                Separator = true
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Settings",
                MenuItemType = MenuItemType.Settings,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Account",
                MenuItemType = MenuItemType.Account,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "About",
                MenuItemType = MenuItemType.About,
                IsEnabled = false
            });

            MenuItems.Add(new MenuItem
            {
                Title = "Close session",
                MenuItemType = MenuItemType.Close,
                IsEnabled = false
            });
        }
    }
}