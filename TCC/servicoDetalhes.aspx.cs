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

        public int servicoget = 0;
        public string nomeEmpresa = " - ";
        public string nomeCliente = " - ";
        public double valor = 0.0;
        public DateTime dataEstimada;
        public List<ServicoTecnico> listaEmpServ;
        public List<ChatMensagem> listaChat;
        public string descUsu = " - ";
        public string sitS = " - ";
        public string disabled = "disabled";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["idSerDet"] != null)
            {
                servicoget = Int32.Parse(Request.QueryString["idSerDet"]);

                Servico serv = new ServicoDAO().selectServico(servicoget);
                Empresa emp = new EmpresaDAO().selectEmp(serv.IdEmp);
                Usuario usu = new UsuarioDAO().selectUser(serv.IdUser);
                listaEmpServ = new ServicoTecnicoDAO().selectServTecsServ(serv.Id);
                ChatContrato chatContrato = new ChatContratoDAO().selectChatCIdServ(serv.Id);

                listaChat = new ChatMensagemDAO().selectChatMIdChatC(chatContrato.Id);


                nomeEmpresa = emp.RazaoSocial;
                nomeCliente = usu.Nome;
                txValor.Text = serv.Valor.ToString();
                txDataEstimada.Text = serv.DataFimEst.ToString();
                descUsu = serv.DescUser;
                int sit = serv.Sit;

                if (sit == 0)
                {
                    sitS = "Em solicitação / negociação para aceite da empresa";
                    disabled = " ";
                    txValor.Enabled = true;
                    txDataEstimada.Enabled = true;
                }
                else if (sit == 1)
                {
                    sitS = "Pendente aceite do Cliente";
                    disabled = "disabled";
                    txValor.Enabled = false;
                    txDataEstimada.Enabled = false;
                }
                else if (sit == 2)
                {
                    sitS = "Em execução";
                    disabled = "disabled";
                    txValor.Enabled = false;
                    txDataEstimada.Enabled = false;
                }
                else if (sit == 3)
                {
                    sitS = "Finalizado";
                    disabled = "disabled";
                    txValor.Enabled = false;
                    txDataEstimada.Enabled = false;
                }
                else if (sit == -1)
                {
                    sitS = "Recusado pela Empresa";
                    disabled = "disabled";
                    txValor.Enabled = false;
                    txDataEstimada.Enabled = false;
                }
                else if (sit == -2)
                {
                    sitS = "Contestado / Em discussão";
                    disabled = "disabled";
                    txValor.Enabled = false;
                    txDataEstimada.Enabled = false;
                }
            }
            else
            {

                nomeEmpresa = "Erro: Serviço Não Encontrado";

            }






        }
    }
}