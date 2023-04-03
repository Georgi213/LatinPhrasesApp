using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LatinPhrasesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void OnHomeButtonClicked(object sender, System.EventArgs e)
        {
            var mainPage = (FlyoutPage)Parent;
            mainPage.Detail = new NavigationPage(new HomePage());
            mainPage.IsPresented = false; // Close the navigation drawer
        }
    }
}