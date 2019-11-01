using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class loginCliente : System.Web.UI.Page
    {
        public string mensagem = " ";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void autenticar(object sender, EventArgs e)
        {
            string loginPOST = login.Value;
            string senhaPOST = senha.Value;

            Usuario logado = new UsuarioDAO().autenticaUser(loginPOST, senhaPOST);

            if (logado.Id > 0)
            {
                mensagem = "Login e senha OK";
                Session["sId"] = logado.Id;
                Session["sNome"] = logado.Nome;
                Session["sRep"] = logado.Reputacao;
                Session["sNivel"] = logado.Nivel;
                Response.Redirect("mapao.aspx");
            }
            else
            {
                mensagem = "<center><font color=red>Login ou senha incorretos</font></center>";
            }

            //mensagem = senhaPOST;
        }
    }
}