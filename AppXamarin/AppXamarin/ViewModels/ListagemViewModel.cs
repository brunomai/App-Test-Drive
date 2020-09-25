using AppXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppXamarin.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public Veiculo veiculoSelecionado;
        public Veiculo VeiculoSelecionado
        {
            get
            {
                return veiculoSelecionado;
            }
            set
            {
                veiculoSelecionado = value;
                if(veiculoSelecionado!= null)
                    MessagingCenter.Send(veiculoSelecionado,"VeiculoSelecionado");
            }
        }
        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }

    }
}
