using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Cargo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        public List<Cargo> ListarCargos()
        {
            var lista = new List<Cargo>();
            lista.Add(new Cargo() { Id = 1, Descricao = "Tecnico" });
            lista.Add(new Cargo() { Id = 2, Descricao = "Representante" });
            lista.Add(new Cargo() { Id = 3, Descricao = "Diretor" });
            return lista;
        }

        public Cargo BuscarCargo(int id)
        {
            var lista = ListarCargos();
            return lista.FirstOrDefault(x => x.Id == id);
        }
    }
}