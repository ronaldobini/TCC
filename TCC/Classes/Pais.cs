using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Pais
    {
        private int id;
        private string nome;

        public Pais(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public Pais()
        {
        }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}