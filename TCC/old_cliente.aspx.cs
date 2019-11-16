using MySql.Data.Types;
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
        public void cadastrar(object sender, EventArgs e)
        {
            string nomePost = nomeC.Value;
            string emailPost = emailC.Value;
            string cpfPost = cpfC.Value;
            string endPost = endC.Value;
            int numPost = Int32.Parse(numC.Value);
            string loginPost = loginC.Value;
            string senhaPost = senhaC.Value;
            Usuario user = new Usuario(0,loginPost, senhaPost, nomePost, emailPost, cpfPost, "tel1","tel2",
                endPost,numPost,"complemento","cep",new Cidade(),0, new MySqlDateTime(), new MySqlDateTime(), 0, 0, 0,null);

            new UsuarioDAO().insertUser(user);
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