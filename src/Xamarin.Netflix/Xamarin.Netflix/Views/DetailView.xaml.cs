using FormsToolkit;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix.Views
{
    public partial class DetailView : ContentPage
    {
        private const int ParallaxSpeed = 5;

        private double _lastScroll;

        public DetailView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var navigationPage = Parent as Forms.NavigationPage;

            if (navigationPage != null)
                navigationPage.On<iOS>().EnableTranslucentNavigationBar();

            MessagingService.Current.SendMessage(MessageKeys.ChangeToolbar, false);
            MessagingService.Current.SendMessage(MessageKeys.ToolbarColor, Color.Transparent);

            ParallaxScroll.Scrolled += OnParallaxScrollScrolled;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            var navigationPage = Parent as Forms.NavigationPage;

            if (navigationPage != null)
                navigationPage.On<iOS>().DisableTranslucentNavigationBar();

            MessagingService.Current.SendMessage(MessageKeys.ChangeToolbar, true);
            MessagingService.Current.SendMessage(MessageKeys.ToolbarColor, Color.Black);

            ParallaxScroll.Scrolled -= OnParallaxScrollScrolled;
        }

        private void OnParallaxScrollScrolled(object sender, ScrolledEventArgs e)
        {
            double translation = 0;

            if (_lastScroll < e.ScrollY)
            {
                translation = 0 - ((e.ScrollY / 2));

                if (translation > 0) translation = 0;
            }
            else
            {
                translation = 0 + ((e.ScrollY / 2));

                if (translation > 0) translation = 0;
            }

            HeaderPanel.TranslateTo(HeaderPanel.TranslationX, translation);
            _lastScroll = e.ScrollY;
        }
    }
}