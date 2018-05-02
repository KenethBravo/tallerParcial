using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using tallerParcial.Clases;

namespace tallerParcial
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
		public Page5 ()
		{
			InitializeComponent ();
            listar();
        }

        public async void listar()
        {
            try
            {
                UserManager manager = new UserManager();
                var res = await manager.getUsuarios();
                System.Diagnostics.Debug.WriteLine(res);
                if (res != null)
                {
                    lstUsuarios.ItemsSource = res;
                }
            }
            catch (Exception e1) { }
        }
    }
}