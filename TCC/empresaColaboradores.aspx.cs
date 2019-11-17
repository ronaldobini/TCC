using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Web.Services;

namespace TCC
{
    public partial class empresaColaboradores : System.Web.UI.Page
    {

        public List<Usuario> colaboradores = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }

            int idEmpresa = (int)Session["sIdEmp"];
            List<UsuarioEmpresa> colUserEmp = new UsuarioEmpresaDAO().selectUsersIdEmpresa(idEmpresa);
            
            foreach (var cue in colUserEmp)
            {
                colaboradores.Add(new UsuarioDAO().selectUser(cue.IdUsuario));
            }
        }
        [WebMethod]
        public void Reativar(int id)
        {
            var s = id;

            Response.Redirect("empresaColaboradores.aspx");
        }
    }
    
}