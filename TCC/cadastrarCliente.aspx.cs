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
        public Usuario col=new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                if (!IsPostBack)
                {

                    idGet = Int32.Parse(Request.QueryString["id"]);
                    col = new UsuarioDAO().selectUser(idGet);
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
                    IdField.Value = idGet.ToString();
                    List<Cidade> cidades = new CidadeDAO().selectAllCids();
                    cidadesDD.DataTextField = "nome";
                    cidadesDD.DataValueField = "id";
                    cidadesDD.DataSource = cidades;
                    cidadesDD.DataBind();
                    cidadesDD.SelectedValue = col.Cidade.Id.ToString();
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
            var idcidade = Int32.Parse(cidadesDD.SelectedValue);

            Usuario user = new Usuario(idvalue, postLogin, postSenha, postNome, postEmail, postCpf, postTel, postCel, postEnd, postNum, postComplemento,
                postCep, new CidadeDAO().selectCidadePorId(idcidade), 0, col.DataCadastro, new MySqlDateTime(), 0, 0, 0, null);
            new UsuarioDAO().updateUser(user);


            Response.Redirect("mapao.aspx");

        }

    }
}