using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Estado
    {
        private int id;
        private string nome;
        private int idPais;

        public Estado()
        {

        }

        public Estado(int id, string nome, int idPais)
        {
            this.id = id;
            this.nome = nome;
            this.idPais = idPais;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int IdPais { get => idPais; set => idPais = value; }
    }
}