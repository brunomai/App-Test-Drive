using AppXamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppXamarin.Data
{
    public class AgendamentoDAO
    {
        readonly SQLiteConnection conexao;

        private List<Agendamento> lista;

        public List<Agendamento> Lista
        {
            get
            {
                return conexao.Table<Agendamento>().ToList();
             
            }
            private set { lista = value; }
        }

        public AgendamentoDAO(SQLiteConnection conexao)
        {
            this.conexao = conexao;
            this.conexao.CreateTable<Agendamento>();
        }

        public void Salvar(Agendamento agendamento)
        {
            conexao.Insert(agendamento);
        }



    }
}
