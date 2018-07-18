using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TercerAplicacion.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var master = (MasterDetailPage)App.Current.MainPage;
            master.IsPresented = false;
            master.Detail = new NavigationPage(new UsuarioPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var master = (MasterDetailPage)App.Current.MainPage;
            master.IsPresented = false;
            master.Detail = new NavigationPage(new Opcion1Page());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var master = (MasterDetailPage)App.Current.MainPage;
            master.IsPresented = false;
            master.Detail = new NavigationPage(new Opcion2Page());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            var master = (MasterDetailPage)App.Current.MainPage;
            master.IsPresented = false;
            master.Detail = new NavigationPage(new Opcion3Page());
        }
    }
}