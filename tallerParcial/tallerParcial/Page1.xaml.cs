using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tallerParcial
{
    //public partial class Page1 : ContentPage
    public partial class Page1 : MasterDetailPage
    {
		public Page1 ()
		{
			InitializeComponent ();
            this.Master = new Master(); //trae informacion y carge la vista master
            this.Detail = new NavigationPage(new Detail()); //carga detalles 

            App.MasterD = this; //crear objeto para q permita navegar
        }
	}
}