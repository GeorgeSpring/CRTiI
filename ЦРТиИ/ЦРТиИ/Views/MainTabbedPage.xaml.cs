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
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage ()
        {
            InitializeComponent();
            List<Competition> competitions = new List<Competition>();
            Competition com = new Competition()
            {
                Name = "Конкурс №1",
                DescriptionShort = "Конкурс интересный, объемный, поучавствуйте, не пожалеете!",
                StartDate = DateTime.Now,
                Category = "Взрослый"
            };
            competitions.Add(com);
            Children.Add(new CompetetionsTabbedPage(competitions));
        }
    }
}