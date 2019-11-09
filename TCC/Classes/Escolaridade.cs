using System.Collections.Generic;
using System.Linq;

namespace TCC.Classes
{
    public class Escolaridade
    {
        public int IdEscolaridade { get; set; }
        public string Descricao { get; set; }

        public List<Escolaridade> ListarEscolaridades()
        {
            var lista = new List<Escolaridade>();
            lista.Add(new Escolaridade() { Descricao = "Fundamental - Incompleto", IdEscolaridade = 1 });
            lista.Add(new Escolaridade() { Descricao = "Fundamental - Completo", IdEscolaridade = 2 });
            lista.Add(new Escolaridade() { Descricao = "Médio - Incompleto", IdEscolaridade = 3 });
            lista.Add(new Escolaridade() { Descricao = "Médio - Completo", IdEscolaridade = 4 });
            lista.Add(new Escolaridade() { Descricao = "Superior - Incompleto", IdEscolaridade = 5 });
            lista.Add(new Escolaridade() { Descricao = "Superior - Completo", IdEscolaridade = 6 });
            lista.Add(new Escolaridade() { Descricao = "Pós-graduação - Incompleto", IdEscolaridade = 7 });
            lista.Add(new Escolaridade() { Descricao = "Pós-graduação - Completo", IdEscolaridade = 8 });
            lista.Add(new Escolaridade() { Descricao = "Mestrado - Incompleto", IdEscolaridade = 9 });
            lista.Add(new Escolaridade() { Descricao = "Mestrado - Completo", IdEscolaridade = 10 });
            lista.Add(new Escolaridade() { Descricao = "Doutorado - Incompleto", IdEscolaridade = 11 });
            lista.Add(new Escolaridade() { Descricao = "Doutorado - Completo", IdEscolaridade = 12 });
            return lista;
        }

        public Escolaridade EscolherEscolaridade(int id)
        {
            var lista = ListarEscolaridades();
            return lista.FirstOrDefault(x => x.IdEscolaridade == id);
        }


    }
}