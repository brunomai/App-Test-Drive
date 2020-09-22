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
    public partial class AgentamentoView : ContentPage
    {
        public Veiculo Veiculo { get; set; }
        public AgentamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            Veiculo = veiculo;
            this.BindingContext = this;
        }
    }
}