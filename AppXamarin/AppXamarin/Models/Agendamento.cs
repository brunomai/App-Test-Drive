using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AppXamarin.Models
{
    public class Agendamento
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }

        public string DataFormatada
        {
            get
            { 
               return DataAgendamento.Add(horaAgendamento).ToString("dd/MM/yyyy HH:mm");
            }
        }


        public Agendamento()
        {

        }
        public Agendamento(string nome, string fone, string email, string modelo, decimal preco, DateTime dataAgendamento, TimeSpan horaAgendamento)
            : this(nome,fone,email,modelo,preco)
        {
            
            this.dataAgendamento = dataAgendamento;
            this.horaAgendamento = horaAgendamento;
        }
        public Agendamento(string nome, string fone, string email, string modelo, decimal preco)
        {
            this.Nome = nome;
            this.Fone = fone;
            this.Email = email;
            this.Modelo = modelo;
            this.Preco = preco;           
        }

        public DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento
        {
            get
            {
                return dataAgendamento;
            }

            set
            {
                dataAgendamento = value;
            }
        }

        public TimeSpan horaAgendamento;
        public TimeSpan HoraAgendamento { get; set; }



    }
}
