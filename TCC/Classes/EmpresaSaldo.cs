using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class EmpresaSaldo
    {
        private int id;
        private int idEmp;
        private double saldoLiberado;
        private double saldoPendente;
        private double saldoTotalHistorico;

        public EmpresaSaldo(int id, int idEmp, double saldoLiberado, double saldoPendente, double saldoTotalHistorico)
        {
            this.id = id;
            this.idEmp = idEmp;
            this.saldoLiberado = saldoLiberado;
            this.saldoPendente = saldoPendente;
            this.saldoTotalHistorico = saldoTotalHistorico;
        }
        public EmpresaSaldo()
        {

        }
        public int Id { get => id; set => id = value; }
        public int IdEmp { get => idEmp; set => idEmp = value; }
        public double SaldoLiberado { get => saldoLiberado; set => saldoLiberado = value; }
        public double SaldoPendente { get => saldoPendente; set => saldoPendente = value; }
        public double SaldoTotalHistorico { get => saldoTotalHistorico; set => saldoTotalHistorico = value; }
    }
}