using AppXamarin.Models;
using AppXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin
{
    public partial class App : Application
    {
        Usuario user;
        
        public App()
        {
            InitializeComponent();
            user = new Usuario();
            user.nome = "Bruno";
            user.id = 1;
            user.email = "bruno@gmail.com";
            user.dataNascimento = "04/02/1998";

            MainPage = new NavigationPage(new ListagemView(user));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
