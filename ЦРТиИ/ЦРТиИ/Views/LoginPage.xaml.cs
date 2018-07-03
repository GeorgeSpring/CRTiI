using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ЦРТиИ.Views
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}
        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainTabbedPage());
        }
    }
}
