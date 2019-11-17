﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class excluir : System.Web.UI.Page
    {
        private int id = -1;
        public string funcao = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null && Request.QueryString["funcao"] != null)
            {
                id = Int32.Parse(Request.QueryString["id"]);
                funcao = Request.QueryString["funcao"];
                switch (funcao)
                {
                    case "deleteUser":
                        deleteUser(id);
                        break;
                    case "deleteServicoEmpresa":
                        deleteServicoEmpresa(id);
                        break;
                    default:
                        break;
                }
            }

        }
        protected void deleteUser(int id)
        {
            new UsuarioEmpresaDAO().DesativarUsuario(id);

            Response.Redirect("empresaColaboradores.aspx?sit=1&msg=sucessoDesativarColaborador");
        }
        protected void deleteServicoEmpresa(int idServico)
        {
            var bancoServico = new EmpresaServicoDAO();
            var servico = bancoServico.selectEmpServ(idServico);
            if (bancoServico.deleteEmpServ(servico))
            {
                Response.Redirect("gerenciarServicos.aspx?sit=1&msg=desativarServicoSucesso");
            }
            else
            {
                Response.Redirect("gerenciarServicos.aspx?sit=2&msg=desativarServicoErro");
            }

            
        }
        protected void deleteSolicUser(object sender, EventArgs e)
        {
            new ServicoDAO().deleteServico(id);
            Response.Redirect("solicitacoesCliente.aspx");
        }

    }
}