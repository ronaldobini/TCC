using MySql.Data.Types;
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
                Response.Redirect("loginCliente.aspx");
            }


        }



        public void cadastrarServ(object sender, EventArgs e)
        {
            string descUser = descuserForm.Value;
            Categoria cat = new Categoria();
            cat.Id = serv.IdCat;
            Servico novoServ = new Servico(0,(int)Session["sId"],getEmpresaEscolhida,emp.IdComercial,DateTime.Now, cat,serv.Id,descUser,0,serv.ValorAprox, "A definir", new DateTime(), 0,0,0,0,0,0,"-","-");
            new ServicoDAO().insertServico(novoServ);

            int idNovoServ = new ServicoDAO().selectUltimoId();

            ChatContrato chatNovo = new ChatContrato(0, idNovoServ, (int)Session["sId"], emp.IdComercial);
            new ChatContratoDAO().insertChatContrato(chatNovo);

            int idNovoCont = new ChatContratoDAO().selectUltimoId();

            
            ChatMensagem chatMens = new ChatMensagem(0, idNovoCont, emp.IdComercial, new DateTime(), "Obrigado pela solicitação, qualquer dúvida não hesite em perguntar!", 0);
            new ChatMensagemDAO().insertChatM(chatMens);

           

            Response.Redirect("solicitacoesCliente.aspx");
        }



    }
}