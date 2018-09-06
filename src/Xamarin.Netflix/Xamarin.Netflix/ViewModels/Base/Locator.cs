using Autofac;
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
        private readonly IContainer _container;
        private ContainerBuilder _builder;

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
            _builder = new ContainerBuilder();

            _builder.RegisterType<MoviesService>().As<IMoviesService>();
            _builder.RegisterType<NavigationService>().As<INavigationService>();
            _builder.RegisterType<ProfileService>().As<IProfileService>();
            _builder.RegisterType<TVShowsService>().As<ITVShowsService>();
            _builder.RegisterType<WatchingService>().As<IWatchingService>();

            _builder.RegisterType<DetailViewModel>();
            _builder.RegisterType<LoginViewModel>();
            _builder.RegisterType<MenuViewModel>();
            _builder.RegisterType<MainViewModel>();
            _builder.RegisterType<HomeViewModel>();

            _container = _builder.Build();
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