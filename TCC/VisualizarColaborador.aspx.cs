using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class VisualizarColaborador : System.Web.UI.Page
    {
        public string tituloDaPag = "Visualizar colaborador";
        public int id = 0;
        public Usuario col;
        public int statusOperação = 0;
        public string msg = "";
        public string acao = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }
            PreencherTela();
        }
        public void Voltar(object sender, EventArgs e)
        {

            Response.Redirect("empresaColaboradores.aspx");
        }
        public void PreencherTela()
        {
            if (Request.QueryString["id"] != null)
            {
                id = Int32.Parse(Request.QueryString["id"]);
                col = new UsuarioDAO().selectUser(id);
                if (!IsPostBack)
                {
                    login.Text = col.Login;
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
        }
    }
}