using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Categoria
    {
        private int id;
        private string descricao;
        private int ordem;

        public Categoria(int id, string descricao, int ordem)
        {
            this.id = id;
            this.descricao = descricao;
            this.ordem = ordem;
        }
        public Categoria()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Ordem { get => ordem; set => ordem = value; }
    }
}