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
        private string tags;
        private short flAtivo;

        public EmpresaServico()
        {
        }

        public EmpresaServico(int id, int idEmp, int idCat, string desc, double valorAprox, string tempoAprox,string tags)
        {
            this.id = id;
            this.idEmp = idEmp;
            this.idCat = idCat;
            this.desc = desc;
            this.valorAprox = valorAprox;
            this.tempoAprox = tempoAprox;
            this.tags = tags;
        }

        public int Id { get => id; set => id = value; }
        public short FlAtivo { get => flAtivo; set => flAtivo = value; }
        public int IdEmp { get => idEmp; set => idEmp = value; }
        public Empresa Empresa { get; set; }
        public int IdCat { get => idCat; set => idCat = value; }
        public Categoria Categoria { get; set; }
        public string Desc { get => desc; set => desc = value; }
        public double ValorAprox { get => valorAprox; set => valorAprox = value; }
        public string TempoAprox { get => tempoAprox; set => tempoAprox = value; }
        public string Tags { get; set; }
    }
}