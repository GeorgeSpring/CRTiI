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
	public partial class CompetetionDetail : ContentPage
	{
		public CompetetionDetail (Competition comp)
		{
			InitializeComponent();
            Description.Text = comp.DescriptionFull;
        }
	}
}