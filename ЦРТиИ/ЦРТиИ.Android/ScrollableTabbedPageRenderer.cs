using Xamarin.Forms.Platform.Android.AppCompat;
using Android.Support.Design.Widget;
using Xamarin.Forms;
using ЦРТиИ.Droid;

[assembly: ExportRenderer(typeof(ScrollableTabbedPage), typeof(ScrollableTabbedPageRenderer))]
namespace ЦРТиИ.Droid
{
    public class ScrollableTabbedPageRenderer : TabbedPageRenderer
    {
        public override void OnViewAdded(Android.Views.View child)
        {
            base.OnViewAdded(child);
            var tabLayout = child as TabLayout;
            if (tabLayout != null)
            {
                tabLayout.TabMode = TabLayout.ModeScrollable;
            }
        }

    }
    public class ScrollableTabbedPage : TabbedPage
    {
    }
}

