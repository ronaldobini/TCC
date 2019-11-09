using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class servicoDetalhes : System.Web.UI.Page
    {

        public int servicoget = 1;
        public string nomeEmpresa = " - ";
        public string nomeCliente = " - ";
        public double valor = 0.0;
        public DateTime dataEstimada;
        protected void Page_Load(object sender, EventArgs e)
        {

            Servico serv = new ServicoDAO().selectServico(servicoget);
            Empresa emp = new EmpresaDAO().selectEmp(serv.IdEmp);
            Usuario usu = new UsuarioDAO().selectUser(serv.IdUser);
            List<ServicoTecnico> empServ = new ServicoTecnicoDAO().selectServTecsServ(serv.Id);


            nomeEmpresa = emp.RazaoSocial;
            nomeCliente = usu.Nome;
            valor = serv.Valor;
            dataEstimada = serv.DataFimEst;




        }
    }
}