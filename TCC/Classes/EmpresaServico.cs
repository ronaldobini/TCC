using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class EmpresaServico
    {
        private int id;
        private int idEmp;
        private int idCat;
        private string desc;
        private double valorAprox;
        private string tempoAprox;

        public EmpresaServico()
        {
        }

        public EmpresaServico(int id, int idEmp, int idCat, string desc, double valorAprox, string tempoAprox)
        {
            this.id = id;
            this.idEmp = idEmp;
            this.idCat = idCat;
            this.desc = desc;
            this.valorAprox = valorAprox;
            this.tempoAprox = tempoAprox;
        }

        public int Id { get => id; set => id = value; }
        public int IdEmp { get => idEmp; set => idEmp = value; }
        public Empresa Empresa { get; set; }
        public int IdCat { get => idCat; set => idCat = value; }
        public Categoria Categoria { get; set; }
        public string Desc { get => desc; set => desc = value; }
        public double ValorAprox { get => valorAprox; set => valorAprox = value; }
        public string TempoAprox { get => tempoAprox; set => tempoAprox = value; }
    }
}