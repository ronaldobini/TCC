using FluentValidation.Results;
using MySql.Data.Types;
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
    public partial class cadastrarCliente : System.Web.UI.Page
    {

        public string mensagem = "";
        private string postLogin="";
        private string postSenha = "";
        private string postNome = "";
        private string postEmail = "";
        private string postCpf = "";
        private string postCep = "";
        private string postEnd = "";
        private string postComplemento = "";
        private int postNum ;
        private string postTel = "";
        private string postCel = "";
        private string postCidade = "Curitiba";
        private string postFunc = "ainda n";
        private string postFormacao = "ainda n";
        public int idGet = 0;
        public string tituloDaPag = "";
        public Usuario user = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["id"] != null)
            {
                idGet = Int32.Parse(Request.QueryString["id"]);
                if (!IsPostBack)
                {

                    idGet = Int32.Parse(Request.QueryString["id"]);
                    user = new UsuarioDAO().selectUser(idGet);
                    login.Text = user.Login;
                    senha.Text = user.Senha;
                    nomCompleto.Text = user.Nome;
                    email.Text = user.Email;
                    cpf.Text = user.Cpf;
                    cep.Text = user.Cep;
                    endereco.Text = user.Endereco;
                    complemento.Text = user.Complemento;
                    numero.Text = user.Numero.ToString();
                    tel.Text = user.Tel1;
                    cel.Text = user.Tel2;
                    IdField.Value = idGet.ToString();
                    List<Cidade> cidades = new CidadeDAO().selectAllCids();
                    cidadesDD.DataTextField = "nome";
                    cidadesDD.DataValueField = "id";
                    cidadesDD.DataSource = cidades;
                    cidadesDD.DataBind();
                    cidadesDD.SelectedValue = user.Cidade.Id.ToString();
                }
            }
            else
            if (!IsPostBack)
            {
                List<Cidade> cidades = new CidadeDAO().selectAllCids();
                cidadesDD.DataTextField = "nome";
                cidadesDD.DataValueField = "id";
                cidadesDD.DataSource = cidades;
                cidadesDD.DataBind();
            }

        }
        public void Cadastrar(object sender, EventArgs e)
        {
            postLogin = login.Text;
            postSenha = senha.Text;
            postNome = nomCompleto.Text;
            postEmail = email.Text;
            postCpf = cpf.Text;
            postCep = cep.Text;
            postEnd = endereco.Text;
            postComplemento = complemento.Text;
            postTel = tel.Text;
            postCel = cel.Text;
            var idcidade = Int32.Parse(cidadesDD.SelectedValue);

            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            if (numero.Text != "")
            {
                postNum = Int32.Parse(numero.Text);

            }
            else
            {
                postNum = 0;
            }


            Usuario user = new Usuario(0, postLogin, postSenha, postNome, postEmail, postCpf, postTel, postCel, postEnd, postNum, postComplemento,
                postCep, new CidadeDAO().selectCidadePorId(idcidade), 0, mysqldt, new MySqlDateTime(), 0, 0, 0, null);
            CadastroClienteValidator validator = new CadastroClienteValidator();

            ValidationResult result = validator.Validate(user);
            if (result.IsValid)
            {
                new UsuarioDAO().insertUser(user);
                Response.Redirect("index.aspx");

            }
            else
            {
                mensagem = result.ToString(" & ");
            }

        }

        public void Editar(object sender, EventArgs e)
        {
            int idvalue = Int32.Parse(IdField.Value);
            user.Id = idvalue;
            user.Login = login.Text;
            user.Senha = senha.Text;
            user.Nome = nomCompleto.Text;
            user.Email = email.Text;
            user.Cpf = cpf.Text;
            user.Cep = cep.Text;
            user.Endereco = endereco.Text;
            user.Complemento = complemento.Text;
            user.Numero = Int32.Parse(numero.Text);
            user.Tel1 = tel.Text;
            user.Tel2 = cel.Text;
            user.Cidade = new CidadeDAO().selectCidadePorNome(cidadesDD.SelectedValue);

           new UsuarioDAO().updateUser(user);


            Response.Redirect("mapao.aspx");

        }

    }
}