using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class gerenciarFinancas : System.Web.UI.Page
    {
        //mudar pra session
        //int SS_empresa = (int)Session["sIdEmp"];
        //int SS_empresa = 2;

        public List<Servico> servsDB = new List<Servico>();

        public EmpresaSaldo empSaldo = new EmpresaSaldo();

        protected void Page_Load(object sender, EventArgs e)
        {
            int SS_empresa = (int)Session["sIdEmp"];

            //puxa lista do banco de dados
            servsDB = new ServicoDAO().selectServsEmpExePendFechado(SS_empresa);
            //puxa saldo da empresa
            empSaldo = new EmpresaSaldoDAO().selectSaldoEmpresa(SS_empresa);
        }

        public void atualizarSaldo(object sender, EventArgs e)
        {
            int SS_empresa = (int)Session["sIdEmp"];

            double val = double.Parse(valor.Value);
            empSaldo = new EmpresaSaldoDAO().selectSaldoEmpresa(SS_empresa);
            empSaldo.SaldoLiberado = empSaldo.SaldoLiberado - val;

            new EmpresaSaldoDAO().updateEmpSaldo(empSaldo);
        } 
    }
}