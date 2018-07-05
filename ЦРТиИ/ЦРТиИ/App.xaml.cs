using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ЦРТиИ.Views;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ЦРТиИ
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var nav = new NavigationPage(new LoginPage());
            MainPage = nav;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        public static void TappedItem(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            ((Xamarin.Forms.ListView)sender).SelectedItem = null;
        }
    }
}
