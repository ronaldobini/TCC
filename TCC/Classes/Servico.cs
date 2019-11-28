using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Servico
    {
        private int id;
        private int idUser;
        private int idEmp;
        private int idRepresEmp;
        private DateTime dataIni;
        private Categoria categoria;
        private int idEmpSer;
        private string descUser;
        private int prioridade;
        private double valor;
        private string dataFimEst;
        private DateTime dataFim;
        private int sit;
        private int aceiteUser;
        private int aceiteEmp;
        private double repTempo;
        private double repQualidade;
        private double repAtendimento;
        private string obsFinUser;
        private string obsFinEmp;

        public Servico()
        {

        }

        public Servico(int id, int idUser, int idEmp, int idRepresEmp, DateTime dataIni, Categoria categoria, int idEmpSer, string descUser,
            int prioridade, double valor, string dataFimEst, DateTime dataFim, int sit, int aceiteUser, int aceiteEmp,
            double repTempo, double repQualidade, double repAtendimento, string obsFinUser, string obsFinEmp)
        {
            this.id = id;
            this.idUser = idUser;
            this.idEmp = idEmp;
            this.idRepresEmp = idRepresEmp;
            this.dataIni = dataIni;
            this.categoria = categoria;
            this.idEmpSer = idEmpSer;            
            this.descUser = descUser;
            this.prioridade = prioridade;
            this.valor = valor;
            this.dataFimEst = dataFimEst;
            this.dataFim = dataFim;
            this.sit = sit;
            this.aceiteUser = aceiteUser;
            this.aceiteEmp = aceiteEmp;
            this.repTempo = repTempo;
            this.repQualidade = repQualidade;
            this.repAtendimento = repAtendimento;
            this.obsFinUser = obsFinUser;
            this.obsFinEmp = obsFinEmp;
        }

        public int Id { get => id; set => id = value; }
        public Usuario Usuario { get; set; }
        public int IdUser { get => idUser; set => idUser = value; }
        public Empresa Empresa { get; set; }
        public int IdEmp { get => idEmp; set => idEmp = value; }
        public UsuarioEmpresa Representante { get; set; }
        public int IdRepresEmp { get => idRepresEmp; set => idRepresEmp = value; }
        public DateTime DataIni { get => dataIni; set => dataIni = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public EmpresaServico EmpresaServico { get; set; }
        public int IdEmpSer { get => idEmpSer; set => idEmpSer = value; }
        public string DescUser { get => descUser; set => descUser = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public double Valor { get => valor; set => valor = value; }
        public string DataFimEst { get => dataFimEst; set => dataFimEst = value; }
        public DateTime DataFim { get => dataFim; set => dataFim = value; }
        public int Sit { get => sit; set => sit = value; }
        public int AceiteUser { get => aceiteUser; set => aceiteUser = value; }
        public int AceiteEmp { get => aceiteEmp; set => aceiteEmp = value; }
        public double RepTempo { get => repTempo; set => repTempo = value; }
        public double RepQualidade { get => repQualidade; set => repQualidade = value; }
        public double RepAtendimento { get => repAtendimento; set => repAtendimento = value; }
        public string ObsFinUser { get => obsFinUser; set => obsFinUser = value; }
        public string ObsFinEmp { get => obsFinEmp; set => obsFinEmp = value; }
    }
}