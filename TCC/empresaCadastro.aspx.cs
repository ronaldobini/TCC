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
    public partial class empresaCadastro : System.Web.UI.Page
    {
        public string mensagem = "";
        private string postCnpj = "";
        private string postRazaoSocial = "";
        private string postTel = "";
        private string postCel = "";
        private string postCep = "";
        private string postEnd = "";
        private string postComplemento = "";
        private int postNum;
        private string postDesc = "";
        private int postQtdFunc;
        private string postZonaAtend = "";
        public int id = -1;
        public Empresa emp;
        CidadeDAO cidadeDAO = new CidadeDAO();
        List<Cidade> lista = new List<Cidade>();

        protected void Page_Load(object sender, EventArgs e)
        {

            lista = cidadeDAO.selectAllCids();
            foreach (var item in lista)
            {
                cidadesDD.Items.Add(new ListItem() { Value = item.Id.ToString(), Text = item.Nome });
            }
            PreencherTela();

        }

        public void PreencherTela()
        {
            if (Request.QueryString["id"] != null)
            {
                id = Int32.Parse(Request.QueryString["id"]);
                emp = new EmpresaDAO().selectEmp(id);
                if (!IsPostBack)
                {
                    cnpj.Text = emp.Cnpj;
                    razaoSocial.Text = emp.RazaoSocial;
                    tel.Text = emp.Tel1;
                    cel.Text = emp.Tel2;
                    cep.Text = emp.Cep;
                    endereco.Text = emp.Endereco;
                    complemento.Text = emp.Complemento;
                    numero.Text = emp.Numero.ToString();

                    List<Cidade> cidades = new CidadeDAO().selectAllCids();
                    cidadesDD.DataTextField = "nome";
                    cidadesDD.DataValueField = "id";
                    cidadesDD.DataSource = cidades;
                    cidadesDD.DataBind();
                    cidadesDD.SelectedValue = emp.cidade.Id.ToString();
                    //cidade.Text = col.Cidade.Nome;
                    zonaAtendimento.Text = emp.ZonaAtendimento;
                    qtdFunc.Text = emp.QtdFuncionarios.ToString();
                    descricao.Value = emp.DescEmpresa;

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
                }

            }
        }
        public void cadastrar(object sender, EventArgs e)
        {
            postCnpj = cnpj.Text;
            postRazaoSocial = razaoSocial.Text;
            postTel = tel.Text;
            postCel = cel.Text;
            postEnd = endereco.Text;
            postComplemento = complemento.Text;
            postCep = cep.Text;
            postDesc = descricao.Value;

            postZonaAtend = zonaAtendimento.Text;

            int idCidade = Int32.Parse(cidadesDD.Text);
            Cidade cid = cidadeDAO.selectCidadePorId(idCidade);
            if (numero.Text != "")
            {
                postNum = Int32.Parse(numero.Text);

            }
            else
            {
                postNum = 0;
            }
            if (qtdFunc.Text != "")
            {
                postQtdFunc = Int32.Parse(qtdFunc.Text);

            }
            else
            {
                postQtdFunc = 0;
            }

            string busca = postEnd + ", " + postNum + " " + cid.Nome;
            double lat = new ApiCoordenadas().pegarLat(busca);
            double lng = new ApiCoordenadas().pegarLng(busca);

            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            Empresa emp = new Empresa(1, 1, 1, 1, postCnpj, postRazaoSocial, postTel, postCel, postEnd, postNum, postComplemento, postCep,
                lat, lng, cid, mysqldt, postDesc, postQtdFunc, 0, 0, 0, 0, 80, 0, postZonaAtend, mysqldt, 1);

            EmpresaCadastroValidator validator = new EmpresaCadastroValidator();
            ValidationResult result = validator.Validate(emp);
            if (result.IsValid)
            {
                new EmpresaDAO().insertEmpresa(emp);
                emp = new EmpresaDAO().selectEmpPorCNPJ(postCnpj);
                Session["sIdEmp"] = emp.Id;
                EmpresaSaldo saldo = new EmpresaSaldo(0, emp.Id, 0, 0, 0);
                new EmpresaSaldoDAO().insertEmpSaldo(saldo);
                Response.Redirect("userEmpCadastro.aspx?acao=primCad");

            }
            else
            {
                mensagem = result.ToString(" & ");
            }


        }
        public void editar(object sender, EventArgs e)
        {
            emp.Cnpj = cnpj.Text;
            emp.RazaoSocial = razaoSocial.Text;
            emp.Tel1 = tel.Text;
            emp.Tel2 = cel.Text;
            emp.Endereco = endereco.Text;
            emp.Complemento = complemento.Text;
            emp.Cep = cep.Text;
            emp.DescEmpresa = descricao.Value;

            emp.ZonaAtendimento = zonaAtendimento.Text;

            int idCidade = Int32.Parse(cidadesDD.Text);
            Cidade cid = cidadeDAO.selectCidadePorId(idCidade);
            if (numero.Text != "")
            {
                emp.Numero = Int32.Parse(numero.Text);

            }
            else
            {
                emp.Numero = 0;
            }
            if (qtdFunc.Text != "")
            {
                emp.QtdFuncionarios = Int32.Parse(qtdFunc.Text);

            }
            else
            {
                emp.QtdFuncionarios = 0;
            }

            string busca = emp.Endereco + ", " + emp.Numero + " " + cid.Nome;
            emp.Lat = new ApiCoordenadas().pegarLat(busca);
            emp.Lon = new ApiCoordenadas().pegarLng(busca);
            
            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));


            EmpresaCadastroValidator validator = new EmpresaCadastroValidator();
            ValidationResult result = validator.Validate(emp);
            if (result.IsValid)
            {
                new EmpresaDAO().updateEmpresa(emp);
                //emp = new EmpresaDAO().selectEmpPorCNPJ(postCnpj);
                //Session["sIdEmp"] = emp.Id;
                //EmpresaSaldo saldo = new EmpresaSaldo(0, emp.Id, 0, 0, 0);
                //new EmpresaSaldoDAO().insertEmpSaldo(saldo);
                Response.Redirect("indexPrestador.aspx");

            }
            else
            {
                mensagem = result.ToString(" & ");
            }
        }
    }
}