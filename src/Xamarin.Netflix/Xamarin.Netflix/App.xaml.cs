using DLToolkit.Forms.Controls;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Netflix.Services.Navigation;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitPlugins();
            InitNavigation();
        }

        private void InitPlugins()
        {
            FlowListView.Init();
        }

        private Task InitNavigation()
        {
            var navigationService = Locator.Instance.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}