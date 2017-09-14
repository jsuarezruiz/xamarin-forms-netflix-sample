using System;
using Xamarin.Forms;

namespace Xamarin.Netflix.Models
{
    public enum MenuItemType
    {
        Home,
        List,
        MyDownloads,
        AvailableDownload,
        Netflix,
        TVShow,
        Action,
        Anime,
        ScienceFiction,
        Classic,
        Comedy,
        Documental,
        Drama,
        Independient,
        Family,
        Romantic,
        Terror,
        Settings,
        Account,
        About,
        Help,
        Close
    }

    public class MenuItem : BindableObject
    {
        private string _title;
        private string _icon;
        private bool _separator;
        private Type _viewModelType;
        private MenuItemType _menuItemType;
        private bool _isEnabled;

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Icon
        {
            get
            {
                return _icon;
            }

            set
            {
                _icon = value;
                OnPropertyChanged();
            }
        }

        public bool Separator
        {
            get
            {
                return _separator;
            }

            set
            {
                _separator = value;
                OnPropertyChanged();
            }
        }

        public MenuItemType MenuItemType
        {
            get
            {
                return _menuItemType;
            }

            set
            {
                _menuItemType = value;
                OnPropertyChanged();
            }
        }

        public Type ViewModelType
        {
            get
            {
                return _viewModelType;
            }

            set
            {
                _viewModelType = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }

            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }
    }
}
