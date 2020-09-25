using System;
using System.Collections.Generic;
using System.Text;

namespace AppXamarin.Models
{
    public class ListagemVeiculos
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemVeiculos()
        {

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome = "Fiesta", Preco = 25000},
                new Veiculo { Nome = "Gol", Preco = 16000},
                new Veiculo { Nome = "Santana", Preco = 12000}
            };

        }

    }
}
