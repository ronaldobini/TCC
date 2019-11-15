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
        public List<Servico> servsDB = new List<Servico>();

        public EmpresaSaldo empSaldo = new EmpresaSaldo();

        protected void Page_Load(object sender, EventArgs e)
        {
            //mudar pra session
            int SS_empresa = (int)Session["sIdEmp"];


            //puxa lista do banco de dados
            servsDB = new ServicoDAO().selectAllServsEmpExe(SS_empresa);

            //puxa saldo da empresa
            empSaldo = new EmpresaSaldoDAO().selectSaldoEmpresa(SS_empresa);
        }
    }
}