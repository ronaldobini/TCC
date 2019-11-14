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
        private int postNum;
        private string postTel;
        private string postCel;
        private string postCidade = "Curitiba";
        private string postFunc = "ainda n";
        private string postFormacao = "ainda n";
        public int id = -1;
        public Usuario col;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                id = Int32.Parse(Request.QueryString["id"]);
                col = new UsuarioDAO().selectUser(id);
                if (!IsPostBack)
                {
                    login.Text = col.Login;
                    senha.Text = col.Senha;
                    nomCompleto.Text = col.Nome;
                    email.Text = col.Email;
                    cpf.Text = col.Cpf;
                    cep.Text = col.Cep;
                    endereco.Text = col.Endereco;
                    complemento.Text = col.Complemento;
                    numero.Text = col.Numero.ToString();
                    tel.Text = col.Tel1;
                    cel.Text = col.Tel2;
                    //cidade.Text = col.Cidade.Nome;
                    funcao.Text = col.UserEmp.Funcao;
                    formacao.Text = col.UserEmp.Formacao;
                }
            }
            List<Cidade> cidades = new CidadeDAO().selectAllCids();
            cidadesDD.DataTextField = "nome";
            cidadesDD.DataValueField = "id";
            cidadesDD.DataSource = cidades;
            cidadesDD.DataBind();

        }
        public void cadastrar(object sender, EventArgs e)
        {
            postLogin = login.Text;
            postSenha = senha.Text;
            postNome = nomCompleto.Text;
            postEmail = email.Text;
            postCpf = cpf.Text;
            postCep = cep.Text;
            postEnd = endereco.Text;
            postComplemento = complemento.Text;
            postNum = Int32.Parse(numero.Text);
            postTel = tel.Text;
            postCel = cel.Text;
            //postCidade = cidade.Value;
            //postFunc = funcao.Value;
            //postFormacao = formacao.Value;
            int idEmp = 2;
            if (Session["empId"] != null)
            {
                idEmp = (int)Session["empId"];
            }
            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            
            Usuario user = new Usuario(0,postLogin,postSenha, postNome,postEmail,postCpf,postTel,postCel,postEnd,postNum,postComplemento,
                postCep, new CidadeDAO().selectCidadePorNome(postCidade),"0", mysqldt, new MySqlDateTime(),0,0,0,null);
            new UsuarioDAO().insertUser(user);
            user = new UsuarioDAO().selectUserLogin(postLogin);
            UsuarioEmpresa userEmp = new UsuarioEmpresa(0, user.Id, idEmp, postFunc, 10, 0, "", postFormacao, 0);

            new UsuarioEmpresaDAO().insertUserEmp(userEmp);

            Response.Redirect("loginEmpresa.aspx");

        }
        public void editar(object sender, EventArgs e)
        {
            col.Login = login.Text;
            col.Senha = senha.Text;
            col.Nome = nomCompleto.Text;
            col.Email = email.Text;
            col.Cpf = cpf.Text;
            col.Cep = cep.Text;
            col.Endereco = endereco.Text;
            col.Complemento = complemento.Text;
            col.Numero = Int32.Parse(numero.Text);
            col.Tel1 = tel.Text;
            col.Tel2 = cel.Text;
            //postCidade = cidade.Value;
            //postFunc = funcao.Value;
            //postFormacao = formacao.Value;
            int idEmp = -1;
            if (Session["empId"] != null)
            {
                idEmp = (int)Session["empId"];
            }
            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            
            new UsuarioDAO().updateUser(col);

            UsuarioEmpresa userEmp = new UsuarioEmpresa(0, col.Id, idEmp, postFunc, 10, 0, "", postFormacao, 0);

            new UsuarioEmpresaDAO().updateUsuarioEmpresa(userEmp);

            Response.Redirect("empresaColaboradores.aspx");

        }
    }
}