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
	public partial class Page6 : ContentPage
	{
		public Page6 (string email)
		{
			InitializeComponent ();
            lblCorreo.Text = email;

        }

        private async void ButtonMain(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());
        }
    }
}