using System;
using Xamarin.Forms;
using TercerAplicacion.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TercerAplicacion
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();


			MainPage = new UsuarioPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
