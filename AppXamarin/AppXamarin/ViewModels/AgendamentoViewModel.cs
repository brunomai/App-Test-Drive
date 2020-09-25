using AppXamarin.Data;
using AppXamarin.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppXamarin.ViewModels
{
    public class AgendamentoViewModel
    {
        public Agendamento Agendamento { get; set; }
        public string Modelo
        {
            get
            {
                return Agendamento.Modelo;
            }
            set
            {
                Agendamento.Modelo = value;
            }
        }

        public decimal Preco
        {
            get
            {
                return Agendamento.Preco;
            }
            set
            {
                Agendamento.Preco = value;
            }
        }
        public string Nome
        {
            get
            {
                return Agendamento.Nome;
            }
            set
            {
                Agendamento.Nome = value;
            }
        }
        public string Fone
        {
            get
            {
                return Agendamento.Fone;
            }
            set
            {
                Agendamento.Fone = value;
            }
        }
        public string Email
        {
            get
            {
                return Agendamento.Email;
            }
            set
            {
                Agendamento.Email = value;
            }
        }
        public DateTime DataAgendamento
        {
            get
            {
                return Agendamento.DataAgendamento;
            }

            set
            {
                Agendamento.DataAgendamento = value;
            }
        }
        public TimeSpan HoraAgendamento
        {
            get
            {
                return Agendamento.HoraAgendamento;
            }
            set
            {
                Agendamento.HoraAgendamento = value;
            }
        }
        public AgendamentoViewModel(Veiculo veiculo, Usuario usuario)
        {
            this.Agendamento = new Agendamento(usuario.nome,usuario.telefone,usuario.email,veiculo.Nome,veiculo.Preco);
            
            

            AgendarCommand = new Command(() =>
            {
                MessagingCenter.Send<Agendamento>(this.Agendamento, "Agendamento");
            });

        }

        public async void SalvarAgendamento()
        {
            /*HttpClient cliente = new HttpClient();

            var dataHoraAgendamento = new DateTime(
                DataAgendamento.Year, DataAgendamento.Month, DataAgendamento.Day,
                HoraAgendamento.Hours, HoraAgendamento.Minutes, HoraAgendamento.Seconds);

            var json = JsonConvert.SerializeObject(new
            {
                nome = Nome,
                fone = Fone,
                email = Email,
                carro = Veiculo.Nome,
                preco = Veiculo.Preco,
                dataAgendamento = dataHoraAgendamento
            });

            var conteudo = new StringContent(json, Encoding.UTF8, "application/json");

            var resposta = await cliente.PostAsync(URL_POST_AGENDAMENTO, conteudo);
            if (resposta.IsSuccessStatusCode)
                MessagingCenter.Send<Agendamento>(this.Agendamento, "SucessoAgendamento");
            else
                MessagingCenter.Send<ArgumentException>(new ArgumentException(), "FalhaAgendamento");*/

            SalvarAgendamentoDB();

            MessagingCenter.Send<Agendamento>(this.Agendamento, "VoltarTelaInicial");

        }

        private void SalvarAgendamentoDB()
        {
            using (var conexao = DependencyService.Get<ISQLite>().PegarConnection())
            {
                AgendamentoDAO dao = new AgendamentoDAO(conexao);
                dao.Salvar(new Agendamento(Nome, Fone, Email, Modelo, Preco));
            }

        }

        public ICommand AgendarCommand { get; set; }
    }
}
