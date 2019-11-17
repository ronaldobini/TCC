using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TCC.Classes;
using TCC.Properties;

namespace TCC
{
    public partial class gerenciarServicos : System.Web.UI.Page
    {
        public List<EmpresaServico> listaDeServicos = new List<EmpresaServico>();
        public EmpresaServicoDAO banco = new EmpresaServicoDAO();
        public EmpresaServico servico = new EmpresaServico();
        public EmpresaDAO empresaDAO = new EmpresaDAO();
        public int statusOperação = 0;
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }



            int idEmpresa = (int)Session["sIdEmp"];
            listaDeServicos = banco.selectEmpServPorIDEmp(idEmpresa);

            if (Request.QueryString["sit"] != null && Request.QueryString["msg"] != null)
            {
                statusOperação = Int32.Parse(Request.QueryString["sit"]);
                msg = Mensagens.ResourceManager.GetString(Request.QueryString["msg"]);
            }
        }

        [WebMethod]
        public void Reativar(int id)
        {
            if (banco.ReabrirServico(id))
            {
                Response.Redirect("empresaColaboradores.aspx?sit=1&msg=ativarServicoSucesso");
            }
            else
            {
                Response.Redirect("empresaColaboradores.aspx?sit=1&msg=erroDesativarServico");
            }
        }

    }
}