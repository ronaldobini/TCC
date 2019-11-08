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

        protected void Page_Load(object sender, EventArgs e)
        {

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
            Cidade cid = new Cidade();
            //cid = new CidadeDAO().selectCidadePorNome(postCid);
            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            Empresa emp = new Empresa(1, 1, 1, 1, postCnpj, postRazaoSocial, postTel, postCel, postEnd, postNum, postComplemento, postCep,
                "000", "000", 1, mysqldt, postDesc , 1, 1, 1, 1, 1, 1, 1, "centro", mysqldt, 0);
            new EmpresaDAO().insertEmpresa(emp);
            emp = new EmpresaDAO().selectEmpPorCNPJ(postCnpj);
            Session["empId"] = emp.Id;
            Response.Redirect("userEmpCadastro.aspx");
        }
    }
}