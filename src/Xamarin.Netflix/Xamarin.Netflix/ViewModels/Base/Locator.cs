using Microsoft.Practices.Unity;
using System;
using Xamarin.Netflix.Services.Movies;
using Xamarin.Netflix.Services.Navigation;
using Xamarin.Netflix.Services.Profile;
using Xamarin.Netflix.Services.TVShows;
using Xamarin.Netflix.Services.Watching;

namespace Xamarin.Netflix.ViewModels.Base
{
    public class Locator
    {
        private readonly IUnityContainer _container;

        private static readonly Locator _instance = new Locator();

        public static Locator Instance
        {
            get
            {
                return _instance;
            }
        }

        protected Locator()
        {
            _container = new UnityContainer();

            _container.RegisterType<IMoviesService, MoviesService>();
            _container.RegisterType<INavigationService, NavigationService>();
            _container.RegisterType<IProfileService, ProfileService>();
            _container.RegisterType<ITVShowsService, TVShowsService>();
            _container.RegisterType<IWatchingService, WatchingService>();

            _container.RegisterType<DetailViewModel>();
            _container.RegisterType<LoginViewModel>();
            _container.RegisterType<MenuViewModel>();
            _container.RegisterType<MainViewModel>();
            _container.RegisterType<HomeViewModel>();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}