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
            postNum = Int32.Parse(num.Value);
            Empresa emp = new Empresa(0, 0, 0, 0, postCnpj, postRazaoSocial, postTel, postCel, postEnd, postNum, postComplemento, postCep,
                "000", "000", "cidade", DateTime.Now, "desc", 1, 1, 1, 1, 1, 1, 1, "centro", DateTime.Now, 0);

            new EmpresaDAO().insertEmpresa(emp);
        }
    }
}