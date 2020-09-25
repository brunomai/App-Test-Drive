using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using AppXamarin.Models;
using Xamarin.Forms;

namespace AppXamarin.ViewModels
{
    public class DetalheViewModel : INotifyPropertyChanged
    {
        public Veiculo Veiculo { get; set; }


        public bool TemFreioABS
        {
            get
            {
                return Veiculo.TemFreioABS;
            }
            set
            {
                Veiculo.TemFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemArCondicionado
        {
            get
            {
                return Veiculo.TemArCondicionado;
            }
            set
            {
                Veiculo.TemArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemMP3Player
        {
            get
            {
                return Veiculo.TemMP3PLAYER;
            }
            set
            {
                Veiculo.TemMP3PLAYER = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$: {0}", Veiculo.FREIO_ABS);
            }
        }
        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$: {0}", Veiculo.AR_CONDICIONADO);
            }
        }
        public string TextoMP3Player
        {
            get
            {
                return string.Format("MP3 Player ABS - R$: {0}", Veiculo.MP3_PLAYER);
            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;
            }
        }

        public DetalheViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            ProximoCommand = new Command(() =>
            {
                MessagingCenter.Send(veiculo, "Proximo");
            }
            );
        }

        public event PropertyChangedEventHandler PropertyChanged;
            
        public void OnPropertyChanged([CallerMemberName]string name  = "")
        {
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ICommand ProximoCommand { get; set; }

    }
}
