using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using TercerAplicacion.Models;
using TercerAplicacion.Services;
using Xamarin.Forms;

namespace TercerAplicacion.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        public ObservableCollection<Usuario> Usuarios { get; set; }
        public Command CargarUsuariosCommand { get; set; }

        public UsuarioViewModel()
        {
            Title = "Usuarios";
            Usuarios = new ObservableCollection<Usuario>();
            CargarUsuariosCommand = new Command(async () => await ExecuteCargarUsuariosCommand());
        }

        async Task ExecuteCargarUsuariosCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Usuarios.Clear();
                var service = new UsuarioService();
                Usuarios = new ObservableCollection<Usuario>(await service.GetUsuariosAsync());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
