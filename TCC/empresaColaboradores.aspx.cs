using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class empresaColaboradores : System.Web.UI.Page
    {

        public List<Usuario> colaboradores = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx");
            }
            Session["editando"] = 0;
            int idEmpresa = (int)Session["sIdEmp"];
            List<UsuarioEmpresa> colUserEmp = new UsuarioEmpresaDAO().selectUsersIdEmpresa(idEmpresa);
            foreach (var cue in colUserEmp)
            {
                colaboradores.Add(new UsuarioDAO().selectUser(cue.IdUsuario));
            }
            string massa = "testando";
        }
        protected void ImageButton_Click(object sender, EventArgs e)
        {
            sender.ToString();
            e.ToString();
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx");
            }
            int idEmpresa = (int)Session["sIdEmp"];
        }
    }
}