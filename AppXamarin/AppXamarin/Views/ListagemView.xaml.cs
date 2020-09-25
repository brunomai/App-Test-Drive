using AppXamarin.Models;
using AppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace AppXamarin.Views
{

    public partial class ListagemView : ContentPage
    {
        readonly public Usuario usuario;

        public ListagemView(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            //this.BindingContext = new ListagemViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<Veiculo>(this, "VeiculoSelecionado",
                (veiculo)=>
                {
                    Navigation.PushAsync(new DetalheView(veiculo, usuario));
                }
                );
            MessagingCenter.Subscribe<ListagemViewModel>(this, "MeusAgendamentos",
                (msg) =>
                {
                    Navigation.PushAsync(new MeusAgendamentosView());
                });
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Veiculo>(this, "VeiculoSelecionado");
            MessagingCenter.Unsubscribe<ListagemViewModel>(this, "MeusAgendamentos");
        }
    }       
}
