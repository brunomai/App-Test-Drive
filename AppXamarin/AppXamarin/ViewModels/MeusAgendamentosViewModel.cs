using AppXamarin.Data;
using AppXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AppXamarin.ViewModels
{
    public class MeusAgendamentosViewModel : INotifyPropertyChanged
    {

        ObservableCollection<Agendamento> listaAgendamentos = new ObservableCollection<Agendamento>();
        public ObservableCollection<Agendamento> ListaAgendamentos
        {
            get
            {
                return listaAgendamentos;
            }
            set
            {
                listaAgendamentos = value;
                OnPropertyChanged();
            }

        }

        public MeusAgendamentosViewModel()
        {
            using (var conexao = DependencyService.Get<ISQLite>().PegarConnection())
            {
                AgendamentoDAO dao = new AgendamentoDAO(conexao);
                var listadb = dao.Lista;
                this.listaAgendamentos.Clear();
                foreach(var itemDB in listadb)
                {
                    this.listaAgendamentos.Add(itemDB);
                }

            }

        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
