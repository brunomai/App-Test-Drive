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
        private const decimal FREIO_ABS = 800, AR_CONDICIONADO = 1000, MP3_PLAYER = 500;
        bool onFreioABS;
        public bool OnFreioABS
        {
            get
            {
                return onFreioABS;
            }
            set
            {
                onFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool onArCondicionado;
        public bool OnArCondicionado
        {
            get
            {
                return onArCondicionado;
            }
            set
            {
                onArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        bool onMP3Player;
        public bool OnMP3Player
        {
            get
            {
                return onMP3Player;
            }
            set
            {
                onMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$: {0}", FREIO_ABS);
            }
        }
        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$: {0}", AR_CONDICIONADO);
            }
        }
        public string TextoMP3Player
        {
            get
            {
                return string.Format("MP3 Player ABS - R$: {0}", MP3_PLAYER);
            }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: {0}", Veiculo.Preco
                    + (onFreioABS ? FREIO_ABS : 0) + (onArCondicionado ? AR_CONDICIONADO : 0)
                    + (onMP3Player ? MP3_PLAYER : 0));
            }
        }



        public Veiculo Veiculo { get; set; }
        public DetalheView(Veiculo _veiculo)
        {
            InitializeComponent();

            this.Veiculo = _veiculo;
            this.BindingContext = this;
        }

        private void ButtonProximo_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new AgentamentoView(this.Veiculo));
        }
    }
}