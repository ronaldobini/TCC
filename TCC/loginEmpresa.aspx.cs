using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class loginEmpresa : System.Web.UI.Page
    {
        public string mensagem = " ";
        private int contaErros = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void autenticar(object sender, EventArgs e)
        {


            string senhaPost = (senha.Value);
            string loginPost = (login.Value);

            //ANTI INJECTION
            int lenS = senhaPost.Length; if (lenS >= 10) lenS = 10;
            int lenL = loginPost.Length; if (lenL >= 12) lenS = 12;

            senhaPost = senhaPost.Substring(0, lenS);
            loginPost = loginPost.Substring(0, lenL);

            senhaPost = senhaPost.Replace("'", "0");
            loginPost = loginPost.Replace("'", "0");
            senhaPost = senhaPost.Replace('"', '0');
            loginPost = loginPost.Replace('"', '0');
            senhaPost = senhaPost.Replace("/", "0");
            loginPost = loginPost.Replace("/", "0");
            senhaPost = senhaPost.Replace("=", "0");
            loginPost = loginPost.Replace("=", "0");
            loginPost = loginPost.Replace(" OR ", "0");

            Usuario logando = new Usuario();
            logando = new UsuarioDAO().selectUserLogin(loginPost);

            UsuarioEmpresa empresa = new UsuarioEmpresa();
            empresa = new UsuarioEmpresaDAO().selectUserIdUser(logando.Id);

            if (logando.Block != 1)
            {
                String senha = logando.Senha;
                if (senha.Equals(senhaPost))
                {
                    mensagem = "Login e senha OK";
                    Session["sId"] = logando.Id;
                    Session["sNome"] = logando.Nome;
                    Session["sNivelEmp"] = empresa.NivelEmp;
                    Session["sFuncao"] = empresa.Funcao;
                    Session["sIdEmp"] = empresa.IdEmpresa;
                    Response.Redirect("indexPrestador.aspx");
                }
                else
                {
                    ++contaErros;
                    logando = null;
                    if (contaErros >= 5)
                    {

                    }
                }
            }
            else
            {
                mensagem = "Usuario Bloqueado";
            }
        }
    }
}