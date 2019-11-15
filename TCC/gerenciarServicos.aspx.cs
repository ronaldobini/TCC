using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class gerenciarServicos : System.Web.UI.Page
    {
        public List<EmpresaServico> listaDeServicos = new List<EmpresaServico>();
        public EmpresaServicoDAO banco = new EmpresaServicoDAO();
        public EmpresaServico servico = new EmpresaServico();
        public EmpresaDAO empresaDAO = new EmpresaDAO();
        public int statusOperação=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx");

            }
            if(Request.QueryString["sucesso"] != null)
            statusOperação = Int32.Parse(Request.QueryString["sucesso"]);

            int idEmpresa = (int)Session["sIdEmp"];
            listaDeServicos = banco.selectEmpServPorIDEmp(idEmpresa);
        }
        
    }
}