using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Debug
    {
        private int id;
        private string processo;
        private DateTime tempo;
        private string resultados;
        private string info;

        public Debug(int id, string processo, DateTime tempo, string resultados, string info)
        {
            this.id = id;
            this.processo = processo;
            this.tempo = tempo;
            this.resultados = resultados;
            this.info = info;
        }
        public Debug()
        {

        }
        public int Id { get => id; set => id = value; }
        public string Processo { get => processo; set => processo = value; }
        public DateTime Tempo { get => tempo; set => tempo = value; }
        public string Resultados { get => resultados; set => resultados = value; }
        public string Info { get => info; set => info = value; }
    }
}