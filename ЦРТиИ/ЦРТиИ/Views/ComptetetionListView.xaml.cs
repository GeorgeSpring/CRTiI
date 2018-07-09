using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ЦРТиИ.Models;

namespace ЦРТиИ.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ComptetetionListView : ContentPage
	{
		public ComptetetionListView (List<Competition> Source)
		{
			InitializeComponent ();
           CompetitionsListVie.ItemTapped += async (object sender, ItemTappedEventArgs e) =>
           {
               if (e == null) return;
               await Navigation.PushAsync(new CompetetionDetail(CompetitionsListVie.SelectedItem as Competition));// de-select the row
               ((ListView)sender).SelectedItem = null;
           };
#if __ANDROID__
            Icon = null;
#endif
            CompetitionsListVie.ItemsSource = Source;
        }
	}
}