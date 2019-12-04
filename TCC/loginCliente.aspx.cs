using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;
using TCC.Validators;

namespace TCC
{
    public partial class loginCliente : System.Web.UI.Page
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
            logando.Login = loginPost;
            logando.Senha = senhaPost;
            LoginClienteValidator validator = new LoginClienteValidator();
            ValidationResult result = validator.Validate(logando);
            if (result.IsValid)
            {
                logando = new UsuarioDAO().selectUserLogin(loginPost);

                if (logando.Block != 1)
                {
                    String senha = logando.Senha;
                    if (senha.Equals(senhaPost))
                    {
                        mensagem = "Login e senha OK";
                        Session["sId"] = logando.Id;
                        Session["sNome"] = logando.Nome;
                        Session["sRep"] = logando.Reputacao;
                        Session["sQtdServicos"] = logando.QtdServicos;
                        Session["sCliente"] = 1;
                        Session["sFuncao"] = Session["sRep"];
                        string endereco = logando.Endereco + " " + logando.Numero + " " + logando.Cidade.Nome;

                        string lt = new ApiCoordenadas().pegarLat(endereco).ToString();
                        string lg = new ApiCoordenadas().pegarLng(endereco).ToString();

                        string latS = lt.Replace(",", ".");
                        string lonS = lg.Replace(",", ".");


                        Session["latCentro"] = latS;
                        Session["lngCentro"] = lonS;

                        new LogDAO().logit("Login Cliente", (int)logando.Id);

                        Response.Redirect("mapao.aspx");
                    }
                    else
                    {
                        mensagem = "Dados Incorretos";
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
            else
            {
                mensagem = result.ToString(" & ");
            }
        }

    }
}