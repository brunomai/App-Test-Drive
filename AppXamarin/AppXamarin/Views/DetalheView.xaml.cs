using AppXamarin.Models;
using AppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {

        public Veiculo Veiculo { get; private set; }
        public Usuario Usuario {get; private set;}
        public DetalheView(Veiculo veiculo, Usuario usuario)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            this.Usuario = usuario;
            this.BindingContext = new DetalheViewModel(veiculo);
        }      

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Veiculo>(this, "Proximo",
            (veiculo) =>
            {
                Navigation.PushAsync(new AgendamentoView(veiculo, Usuario));
            }
            );
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Veiculo>(this, "Proximo");
        }

    }
}