using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class cliente : System.Web.UI.Page
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