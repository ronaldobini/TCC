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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx");
            }
            int idEmpresa = (int)Session["sIdEmp"];
            listaDeServicos = banco.selectEmpServPorIDEmp(idEmpresa);
        }

        public void Editar(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx");
            }

            string nameOfControl = (sender as HtmlAnchor).Name.ToString();
            
            int idEmpresa = (int)Session["sIdEmp"];
            listaDeServicos = banco.selectEmpServPorIDEmp(idEmpresa);
        }

        protected void Remover(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx");
            }
            int idEmpresa = (int)Session["sIdEmp"];
            listaDeServicos = banco.selectEmpServPorIDEmp(idEmpresa);
        }
    }
}