using System;
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
            }
        }
        protected void deleteUser(object sender, EventArgs e)
        {
            new UsuarioDAO().deleteUser(id);
            Response.Redirect("empresaColaboradores.aspx");
        }

    }
}