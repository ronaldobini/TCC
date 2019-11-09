using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class ChatMensagem
    {
        private int id;
        private int idChatC;
        private int idUser;
        private DateTime tempo;
        private string mensagem;
        private int situacao;
        public ChatMensagem()
        {

        }

        public ChatMensagem(int id, int idChatC, int idUser, DateTime tempo, string mensagem, int situacao)
        {
            this.id = id;
            this.idChatC = idChatC;
            this.idUser = idUser;
            this.tempo = tempo;
            this.mensagem = mensagem;
            this.situacao = situacao;
        }

        public int Id { get => id; set => id = value; }
        public int IdChatC { get => idChatC; set => idChatC = value; }
        public ChatContrato ChatContrato { get; set; }
        public int IdUser { get => idUser; set => idUser = value; }
        public Usuario Usuario { get; set; }
        public DateTime Tempo { get => tempo; set => tempo = value; }
        public string Mensagem { get => mensagem; set => mensagem = value; }
        public int Situacao { get => situacao; set => situacao = value; }
    }
}