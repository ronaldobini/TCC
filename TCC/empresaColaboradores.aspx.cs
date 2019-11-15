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
            
            int idEmpresa = (int)Session["sIdEmp"];
            List<UsuarioEmpresa> colUserEmp = new UsuarioEmpresaDAO().selectUsersIdEmpresa(idEmpresa);
            
            foreach (var cue in colUserEmp)
            {
                colaboradores.Add(new UsuarioDAO().selectUser(cue.IdUsuario));
            }
        }
    }
}