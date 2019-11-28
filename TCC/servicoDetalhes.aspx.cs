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
        public string descServ = "-";
        public string nomeEmpresa = " - ";
        public string nomeCliente = " - ";
        public string repCliente = " - ";
        public string endCliente = " - ";
        public double valor = 0.0;
        public int sit = -3;
        public DateTime dataEstimada;
        public List<ServicoTecnico> listaServTec;
        public List<UsuarioEmpresa> listaUE;
        public List<ChatMensagem> listaChat;
        public string descUsu = " - ";
        public string sitS = " - ";
        public string disabled = "disabled";
        public int contratoID = 0;

        public Servico serv;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sId"] == null)
            {
                Response.Redirect("index.aspx?msg=sessaoInvalida");
            }


            if (Request.QueryString["idSerDet"] != null)
            {
                servicoget = Int32.Parse(Request.QueryString["idSerDet"]);

                serv = new ServicoDAO().selectServico(servicoget);
                Empresa emp = new EmpresaDAO().selectEmp(serv.IdEmp);
                Usuario usu = new UsuarioDAO().selectUser(serv.IdUser);
                descServ = new EmpresaServicoDAO().selectDescPorId(serv.IdEmpSer);
                listaServTec = new ServicoTecnicoDAO().selectServTecsServ(serv.Id);
                listaUE = new UsuarioEmpresaDAO().selectUsersIdEmpresa(serv.IdEmp);
                ChatContrato chatContrato = new ChatContratoDAO().selectChatCIdServ(serv.Id);

                listaChat = new ChatMensagemDAO().selectChatMIdChatC(chatContrato.Id);
                contratoID = chatContrato.Id;

                nomeEmpresa = emp.RazaoSocial;
                nomeCliente = usu.Nome;
                repCliente = usu.Reputacao.ToString(); if (repCliente == "0") repCliente = "Primeiro Serviço";
                endCliente = usu.Endereco + " - " + usu.Tel1;
                int c = 0;
                foreach(UsuarioEmpresa ue in listaUE)
                {
                    
                    Usuario uu = new UsuarioDAO().selectUser(ue.IdUsuario);
                    string nome = uu.Nome + " (" + ue.Funcao + ")";
                    string iduu = "" + uu.Id;
                   
                    servTecsEmp.Items.Insert(c, new ListItem(nome, iduu));
                    c++;
                }
                


                if (!IsPostBack)
                {
                    txValor.Text = serv.Valor.ToString();
                    string dataEstimada = serv.DataFimEst.ToString();
                    if (dataEstimada  == "01/01/2001 00:00:00") { dataEstimada = "A definir"; }
                    txDataEstimada.Text = dataEstimada;
                }
                descUsu = serv.DescUser;
                sit = serv.Sit;


                //ACEITAR OU RECUSAR DIRETO PELA TELA INDEX PRESTADOR OU LISTA DE SOLIC
                if (Request.QueryString["modo"] != null)
                {
                    if(Request.QueryString["modo"] == "aceitar")
                    {
                        empresaAprove(null,null);
                    }

                    if (Request.QueryString["modo"] == "recusar")
                    {
                        empresaReprove(null, null);
                    }

                }

                    verificarSit();
            }
            else
            {
                nomeEmpresa = "Erro: Serviço Não Encontrado";
            }
        }

        public string corrigiData(string sss)
        {
            sss = sss.Substring(0, 2);

            return sss;
        }

        public void empresaUpdate(object sender, EventArgs e)
        {
        if (Session["sIdEmp"] == null)
        {
            Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
        }
            double valor = double.Parse(txValor.Text);

            //string dataCorrigida = corrigiData(txDataEstimada.Text);

            string prev = txDataEstimada.Text;

            new ServicoDAO().updateServicoValor(valor,prev, servicoget);
            mensagem.Text="Dados atualizados com sucesso!";
        }


        public void empresaAprove(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }
            new ServicoDAO().updateSit(1,servicoget);
            mensagem.Text = "Aprovado com sucesso! Pendente aprovação do usuário.";
            sit = 1;
            verificarSit();
        }

        public void empresaReprove(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }
            new ServicoDAO().updateSit(-1, servicoget);
            mensagem.Text = "Serviço reprovado!";
            sit = -1;
            verificarSit();
        }

        public void empresaEnd(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }
           

            string obsFinais = obsFinaisEmpresa.Value;
            int repuCli = Int32.Parse(repCli.Value);
            int idCli = serv.IdUser;

            new ServicoDAO().updateFinalEmp(3, servicoget, idCli, repuCli, obsFinais);
            mensagem.Text = "Serviço enviado para aprovação final do usuário!";
            sit = 3;
            verificarSit();
        }


        public void clientePay(object sender, EventArgs e)
        {
            new ServicoDAO().updateSit(2, servicoget);
            mensagem.Text = "Aprovado com sucesso! Pagamento aprovado!";
            new EmpresaSaldoDAO().updateEmpSaldoPendente(serv.IdEmp, serv.Valor);
            sit = 2;
            verificarSit();
        }

        public void clienteEnd(object sender, EventArgs e)
        {
            string obsFinais = obsFinaisCli.Value;
            int formRepQ = Int32.Parse(repQ.Value);
            int formRepA = Int32.Parse(repA.Value);
            int formRepT = Int32.Parse(repT.Value);
            int idCli = serv.IdUser;

            new ServicoDAO().updateFinalCli(4, servicoget,idCli,serv.IdEmp,formRepQ,formRepA,formRepT,obsFinais);
            new EmpresaSaldoDAO().updateEmpSaldoLiberado(serv.IdEmp,serv.Valor);
            mensagem.Text = "Aprovado com sucesso! Serviço está finalizado.";
            sit = 4;
            verificarSit();
        }

        public void anyProblem(object sender, EventArgs e)
        {
            new ServicoDAO().updateSit(-2, servicoget);
            mensagem.Text = "Você contestou esse serviço. A discussão será pelo chat com intervenção da Servitiba.";
            sit = -2;
            verificarSit();
        }


        public void enviarMsg(object sender, EventArgs e)
        {
            string msgForm = msgUser.Value;
            ChatMensagem cm = new ChatMensagem(0,contratoID,(int)Session["sId"],DateTime.Now,msgForm,0);
            new ChatMensagemDAO().insertChatM(cm);
            listaChat = new ChatMensagemDAO().selectChatMIdChatC(contratoID);
        }
        
        public void addTecServ(object sender, EventArgs e)
        {
            int ueAdd = Int32.Parse(servTecsEmp.SelectedValue);

            ServicoTecnico servTec = new ServicoTecnico(0,servicoget,ueAdd, 0, "-");
            new ServicoTecnicoDAO().insertServTec(servTec);
            Response.Redirect("servicoDetalhes.aspx?idSerDet="+servicoget);
        }
        


        public void verificarSit()
        {
            if (sit == 0)
            {
                sitS = "Em solicitação, pendente aceite da empresa e acordo de preço e previsão";
                disabled = " ";
                if (Session["sIdEmp"] != null)
                {
                    txValor.Enabled = true;
                    txDataEstimada.Enabled = true;
                    servTecsEmp.Enabled = true;
                    btAdd.Visible = true;
                }
                else
                {
                    txValor.Enabled = false;
                    txDataEstimada.Enabled = false;
                    servTecsEmp.Enabled = false;
                    btAdd.Visible = false;
                }
                    
                
            }
            else if (sit == 1)
            {
                sitS = "Aceito pela empresa, pendente aceite do Cliente";
                disabled = "disabled";
                txValor.Enabled = false;
                txDataEstimada.Enabled = false;
                servTecsEmp.Enabled = false;
                btAdd.Visible = false;
            }
            else if (sit == 2)
            {
                sitS = "Em execução pela empresa!";
                disabled = "disabled";
                txValor.Enabled = false;
                txDataEstimada.Enabled = false;
                servTecsEmp.Enabled = false;
                btAdd.Visible = false;
            }
            else if (sit == 3)
            {
                sitS = "Serviço Executado pela empresa, aguardando aceite do Cliente";
                disabled = "disabled";
                txValor.Enabled = false;
                txDataEstimada.Enabled = false;
                servTecsEmp.Enabled = false;
                btAdd.Visible = false;
            }
            else if (sit == 4)
            {
                sitS = "Serviço finalizado";
                disabled = "disabled";
                txValor.Enabled = false;
                txDataEstimada.Enabled = false;
                servTecsEmp.Enabled = false;
                btAdd.Visible = false;
            }
            else if (sit == -1)
            {
                sitS = "Recusado pela Empresa";
                disabled = "disabled";
                txValor.Enabled = false;
                txDataEstimada.Enabled = false;
                servTecsEmp.Enabled = false;
                btAdd.Visible = false;
            }
            else if (sit == -2)
            {
                sitS = "Contestado / Em discussão";
                disabled = "disabled";
                txValor.Enabled = false;
                txDataEstimada.Enabled = false;
                servTecsEmp.Enabled = false;
                btAdd.Visible = false;
            }
        }
    }
}
