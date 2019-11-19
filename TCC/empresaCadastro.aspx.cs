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
    public partial class empresaCadastro : System.Web.UI.Page
    {
        private string postCnpj;
        private string postRazaoSocial;
        private string postTel;
        private string postCel;
        private string postCep;
        private string postEnd;
        private string postComplemento;
        private int postNum;
        private string postDesc;
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
            postNum = Int32.Parse(numero.Value);
            postDesc = descricao.Value;


            int idCidade = Int32.Parse(cidade.Text);
            Cidade cid = cidadeDAO.selectCidadePorId(idCidade);

            string busca = postEnd + ", " + postNum + " " + cid.Nome;
            double lat = new ApiCoordenadas().pegarLat(busca);
            double lng = new ApiCoordenadas().pegarLng(busca);

            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            Empresa emp = new Empresa(1, 1, 1, 1, postCnpj, postRazaoSocial, postTel, postCel, postEnd, postNum, postComplemento, postCep,
                lat, lng, cid.Id, mysqldt, postDesc , 1, 1, 1, 1, 1, 1, 1, "centro", mysqldt, 1);
            new EmpresaDAO().insertEmpresa(emp);
            emp = new EmpresaDAO().selectEmpPorCNPJ(postCnpj);
            Session["sIdEmp"] = emp.Id;
            EmpresaSaldo saldo = new EmpresaSaldo(0, emp.Id, 0, 0, 0);
            new EmpresaSaldoDAO().insertEmpSaldo(saldo);
            Response.Redirect("userEmpCadastro.aspx?acao=primCad");
        }
    }
}