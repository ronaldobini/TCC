using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class servicoContratar : System.Web.UI.Page
    {

        public int getEmpresaEscolhida = 0;
        public int getServicoEscolhido = 0;

        //string nomeEmpresa = "-";
        public string servicoEscolhido = "-";
        public string tempoPrecoEstimado = "-";

        public EmpresaServico serv;
        public Empresa emp;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["sId"] != null)
            {

                if (Request.QueryString["idEmpEsc"] != null && Request.QueryString["idSerEsc"] != null)
                {
                    getEmpresaEscolhida = Int32.Parse(Request.QueryString["idEmpEsc"]);
                    getServicoEscolhido = Int32.Parse(Request.QueryString["idSerEsc"]);

                    serv = new EmpresaServicoDAO().selectEmpServ(getServicoEscolhido);
                    emp = new EmpresaDAO().selectEmp(getEmpresaEscolhida);

                    servicoEscolhido = serv.Desc;
                    tempoPrecoEstimado = serv.ValorAprox + " / " + serv.TempoAprox;

                }
                else
                {


                }
            }
            else
            {
                Session["sTempIdEmpEsc"] = getEmpresaEscolhida;
                Session["sTempIdSerEsc"] = getServicoEscolhido;
                Response.Redirect("cadstroCliente.aspx");
            }


        }



        public void cadastrarServ(object sender, EventArgs e)
        {
            string descUser = descuser.Text;
            int i = 0;
            Servico novoServ = new Servico(0,(int)Session["sId"],getEmpresaEscolhida,emp.IdComercial,new DateTime(),serv.IdCat,serv.Id,descUser,0,serv.ValorAprox, new DateTime(), new DateTime(), 0,0,0,0,0,0,"-","-");
            new ServicoDAO().insertServico(novoServ);
            //insertservico
        }



    }
}