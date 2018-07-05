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
    public partial class CompetetionsTabbedPage : TabbedPage
    {
        public CompetetionsTabbedPage (List<Competition> Source)
        {
            InitializeComponent();
            CompetitionsListView.ItemTapped += async (object sender, ItemTappedEventArgs e) =>
            {
                if (e == null) return;
                await Navigation.PushAsync(new CompetetionDetail(CompetitionsListView.SelectedItem as Competition));// de-select the row
                ((ListView)sender).SelectedItem = null;
            };
#if __ANDROID__
            contentPageCompet.Icon = null;
#endif
            CompetitionsListView.ItemsSource = Source;
        }
    }
}