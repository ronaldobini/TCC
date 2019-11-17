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
using TCC.Properties;

namespace TCC
{
    public partial class empresaColaboradores : System.Web.UI.Page
    {

        public List<Usuario> colaboradores = new List<Usuario>();
        private int id = 0;
        public string funcao = "";
        public int statusOperação = 0;
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }
            else
            {
                if (Request.QueryString["sit"] != null && Request.QueryString["msg"] != null)
                {
                    statusOperação = Int32.Parse(Request.QueryString["sit"]);
                    msg = Mensagens.ResourceManager.GetString(Request.QueryString["msg"]);
                }
                if (Request.QueryString["id"] != null && Request.QueryString["funcao"] != null)
                {
                    id = Int32.Parse(Request.QueryString["id"]);
                    funcao = Request.QueryString["funcao"];
                    switch (funcao)
                    {
                        case "Reativar":
                            Reativar(id);
                            break;
                        default:
                            CarregarDados();
                            break;
                    }
                }
                else
                {
                    CarregarDados();
                }

            }


        }

        public void CarregarDados()
        {
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
            new UsuarioEmpresaDAO().ReativarUsuario(id);

            Response.Redirect("empresaColaboradores.aspx?sit=1&msg=sucessoReativarEmp");
        }
    }

}