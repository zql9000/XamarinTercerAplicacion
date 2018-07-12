using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerAplicacion.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TercerAplicacion.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UsuarioPage : ContentPage
	{
        private UsuarioViewModel viewModel;

		public UsuarioPage()
		{
			InitializeComponent();

            BindingContext = viewModel = new UsuarioViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Usuarios.Count == 0)
                viewModel.CargarUsuariosCommand.Execute(null);
        }
    }
}