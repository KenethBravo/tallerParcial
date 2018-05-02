using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tallerParcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void ButtonIndex(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void ButtonForgot(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void ButtonSingUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
