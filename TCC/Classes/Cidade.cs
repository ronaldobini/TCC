using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Cidade
    {
        private int id;
        private string nome;
        private int idEstado;
        private int idPais;

        public Cidade(int id, string nome, int idEstado, int idPais)
        {
            this.id = id;
            this.nome = nome;
            this.idEstado = idEstado;
            this.idPais = idPais;
        }
        public Cidade()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public int IdPais { get => idPais; set => idPais = value; }
    }
}