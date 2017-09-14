using FormsToolkit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingService.Current.SendMessage(MessageKeys.ChangeToolbar, true);
        }
    }
}