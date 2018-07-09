using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ЦРТиИ.Models;

namespace ЦРТиИ.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CompetetionDetail : ContentPage
	{
        Competition comp;

        public CompetetionDetail (Competition comp)
		{
			InitializeComponent();
            this.comp = comp;
            BindingContext = comp;
            Description.Text = comp.DescriptionFull;
            AgeCategoriesListView.ItemsSource = comp.AgeСategories;
            AgeCategoriesListView.ItemTapped += App.TappedItem;
            AgeCategoriesListView.HeightRequest = comp.AgeСategories.Count * AgeCategoriesListView.RowHeight;
            NominationsListView.ItemsSource = comp.Nominations;
            NominationsListView.ItemTapped += App.TappedItem;
            NominationsListView.HeightRequest = comp.Nominations.Count * NominationsListView.RowHeight;
            Polozh.Text = comp.AttachedFiles.Name;
            Polozh.Clicked += Polozh_Clicked;
        }

        private void Polozh_Clicked(object sender, EventArgs e)
        {
           //WebClient wc = new WebClient();
           //wc.DownloadFileAsync(new Uri(comp.AttachedFiles.Uri), comp.Name);
        }
    }
}