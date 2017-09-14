using FormsToolkit;
using Xamarin.Forms;
using Xamarin.Netflix.ViewModels.Base;

namespace Xamarin.Netflix.Views
{
    public partial class TranspatentNavigationPage : Forms.NavigationPage
    {
        public TranspatentNavigationPage() : base()
        {
            InitializeComponent();
        }

        public TranspatentNavigationPage(Forms.Page root) : base(root)
        {
            InitializeComponent();

            MessagingService.Current.Subscribe<Color>(MessageKeys.ToolbarColor, (page, color) =>
            {
                BarBackgroundColor = color;
            });
        }
    }
}