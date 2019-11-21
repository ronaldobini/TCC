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
        private string postCnpj="";
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
        CidadeDAO cidadeDAO = new CidadeDAO();
        List<Cidade> lista = new List<Cidade>();

        protected void Page_Load(object sender, EventArgs e)
        {

            lista = cidadeDAO.selectAllCids();
            foreach (var item in lista)
            {
                cidade.Items.Add(new ListItem() { Value = item.Id.ToString(), Text = item.Nome });
            }

        }


        public void cadastrar(object sender, EventArgs e)
        {
            postCnpj = cnpj.Value;
            postRazaoSocial = razaoSocial.Value;
            postTel = tel.Value;
            postCel = cel.Value;
            postEnd = endereco.Value;
            postComplemento = complemento.Value;
            
            postDesc = descricao.Value;
            
            postZonaAtend = zonaAtendimento.Value;

            int idCidade = Int32.Parse(cidade.Text);
            Cidade cid = cidadeDAO.selectCidadePorId(idCidade);
            if (numero.Value != "")
            {
                postNum = Int32.Parse(numero.Value);

            }
            else
            {
                postNum = 0;
            }
            if (qtdFunc.Value != "")
            {
                postQtdFunc = Int32.Parse(qtdFunc.Value);

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
                lat, lng, cid.Id, mysqldt, postDesc , postQtdFunc, 0, 0, 0, 0, 80, 0, postZonaAtend, mysqldt, 1);

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
    }
}