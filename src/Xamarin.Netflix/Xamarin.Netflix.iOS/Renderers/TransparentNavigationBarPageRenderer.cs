using Xamarin.Netflix.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Xamarin.Netflix.Views;

[assembly: ExportRenderer(typeof(DetailView), typeof(TransparentNavigationBarPageRenderer))]
namespace Xamarin.Netflix.iOS.Renderers
{
    public class TransparentNavigationBarPageRenderer : PageRenderer
    {
        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            if (NavigationController != null)
            {
                NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
                NavigationController.NavigationBar.ShadowImage = new UIImage();
                NavigationController.NavigationBar.BarTintColor = UIColor.Clear;
                NavigationController.NavigationBar.TintColor = UIColor.White;
            }
        }
    }
}