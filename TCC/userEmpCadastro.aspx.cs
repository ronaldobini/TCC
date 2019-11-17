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
        private int postEscolar;
        private string postTel;
        private string postCel;
        private string postCidade = "Curitiba";
        private string postFunc = "ainda n";
        private string postFormacao = "ainda n";
        public int id = -1;
        public string tituloDaPag = "";
        public Usuario col;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }
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

                    List<Escolaridade> escolaridades = new Escolaridade().ListarEscolaridades();
                    Escolaridade.DataTextField = "descricao";
                    Escolaridade.DataValueField = "IdEscolaridade";
                    Escolaridade.DataSource = escolaridades;
                    Escolaridade.DataBind();

                    List<Cidade> cidades = new CidadeDAO().selectAllCids();
                    cidadesDD.DataTextField = "nome";
                    cidadesDD.DataValueField = "id";
                    cidadesDD.DataSource = cidades;
                    cidadesDD.DataBind();
                    Escolaridade.SelectedValue = col.UserEmp.IdEscolar.ToString();
                    cidadesDD.SelectedValue = col.Cidade.Id.ToString();

                    List<Cargo> cargos = new Cargo().ListarCargos();
                    Cargo.DataTextField = "Descricao";
                    Cargo.DataValueField = "id";
                    Cargo.DataSource = cargos;
                    Cargo.DataBind();
                    Cargo.SelectedValue = col.UserEmp.NivelEmp.ToString();



                }
            }
            else
            {
                if (!IsPostBack)
                {
                    List<Cidade> cidades = new CidadeDAO().selectAllCids();
                    cidadesDD.DataTextField = "nome";
                    cidadesDD.DataValueField = "id";
                    cidadesDD.DataSource = cidades;
                    cidadesDD.DataBind();
                    List<Escolaridade> escolaridades = new Escolaridade().ListarEscolaridades();
                    Escolaridade.DataTextField = "descricao";
                    Escolaridade.DataValueField = "IdEscolaridade";
                    Escolaridade.DataSource = escolaridades;
                    Escolaridade.DataBind();
                    List<Cargo> cargos = new Cargo().ListarCargos();
                    Cargo.DataTextField = "Descricao";
                    Cargo.DataValueField = "id";
                    Cargo.DataSource = cargos;
                    Cargo.DataBind();
                }

            }



        }
        public void cadastrar(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx");
            }
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
            postFunc = funcao.Text;
            postEscolar = Int32.Parse(Escolaridade.SelectedValue);
            int cargoSelecionado = Int32.Parse(Cargo.SelectedValue);
            string descEscolar = new Escolaridade().EscolherEscolaridade(postEscolar).Descricao;
            int idEmp = 0;
            if (Session["sIdEmp"] != null)
            {
                idEmp = (int)Session["sIdEmp"];
            }
            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            Cidade cidade = new CidadeDAO().selectCidadePorNome(postCidade);
            Usuario user = new Usuario(0, postLogin, postSenha, postNome, postEmail, postCpf, postTel, postCel, postEnd, postNum, postComplemento,
                postCep, cidade, 0, mysqldt, new MySqlDateTime(), 0, 0, 0, null);
            var msg = new UsuarioDAO().insertUser(user);
            user = new UsuarioDAO().selectUserLogin(postLogin);
            UsuarioEmpresa userEmp = new UsuarioEmpresa(0, user.Id, idEmp, postFunc, cargoSelecionado, 0, descEscolar, formacao.Text, 0, postEscolar);

            new UsuarioEmpresaDAO().insertUserEmp(userEmp);

            Response.Redirect("empresaColaboradores.aspx");

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
            postEscolar = Int32.Parse(Escolaridade.SelectedValue);
            postFunc = funcao.Text;
            string descEscolar = new Escolaridade().EscolherEscolaridade(postEscolar).Descricao;
            int cargoSelecionado = Int32.Parse(Cargo.SelectedValue);
            int idEmp = -1;
            if (Session["sIdEmp"] != null)
            {
                idEmp = (int)Session["sIdEmp"];
            }
            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));

            new UsuarioDAO().updateUser(col);

            UsuarioEmpresa userEmp = new UsuarioEmpresa(0, col.Id, idEmp, postFunc, cargoSelecionado, 0, descEscolar, formacao.Text, 0, postEscolar);

            new UsuarioEmpresaDAO().updateUsuarioEmpresa(userEmp);

            Response.Redirect("empresaColaboradores.aspx");

        }
        public void Voltar(object sender, EventArgs e) {

            Response.Redirect("empresaColaboradores.aspx");
        }
    }
}