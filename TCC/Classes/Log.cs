using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Log
    {
        
        private int id;
        private string acao;
        private DateTime tempo;
        private int idUser;

        public Log(int id, string acao, DateTime tempo, int idUser)
        {
            this.id = id;
            this.acao = acao;
            this.tempo = tempo;
            this.idUser = idUser;
        }

        public Log()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Acao { get => acao; set => acao = value; }
        public DateTime Tempo { get => tempo; set => tempo = value; }
        public int IdUser { get => idUser; set => idUser = value; }
    }
}