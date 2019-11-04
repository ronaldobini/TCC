using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class userEmpCadastro : System.Web.UI.Page
    {
        private string postLogin;
        private string postSenha;
        private string postNome;
        private string postEmail;
        private string postCpf;
        private string postCep;
        private string postEnd;
        private string postComplemento;
        private string postNum;
        private string postTel;
        private string postCel;
        private string postCidade;
        private string postFunc;
        private string postFormacao;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void cadastrar(object sender, EventArgs e)
        {
            postLogin = login.Value;
            postSenha = senha.Value;
            postNome = nomCompleto.Value;
            postEmail = email.Value;
            postCpf = cpf.Value;
            postCep = cep.Value;
            postEnd = endereco.Value;
            postComplemento = complemento.Value;
            postNum = numero.Value;
            postTel = tel.Value;
            postCel = cel.Value;
            //postCidade = cidade.Value;
            //postFunc = funcao.Value;
            //postFormacao = formacao.Value;

            UsuarioEmpresa userEmp = new UsuarioEmpresa(0, 0, 5, postFunc, 10, 0, "", postFormacao, 0);

            new UsuarioEmpresaDAO().insertUserEmp(userEmp);


        }
    }
}