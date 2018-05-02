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
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

        private async void ButtonReset(object sender, EventArgs e)
        {
            //await DisplayAlert("Mensaje", "Registro Exitoso", "Aceptar");
            String email = emailForgot.Text;

            await Navigation.PushAsync(new Page6(email));
        }
    }
}