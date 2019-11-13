using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class empresaDetalhes : System.Web.UI.Page
    {

        public int getEmpresaMapa = 2;

        public string cnpj = "-";
        public string razaoSocial = "-";
        public string telefone1 = "-";
        public string telefone2 = "-";
        public string endereco = "-";
        public string numero = "-";
        public string complemento = "-";
        public string cep = "-";
        public string qtdFunc = "-";
        public string repQ = "-";
        public string repA = "-";
        public string repT = "-";
        public string cadastro = "-";
        public string descricao = "-";
        public string diretor = "-";
        public string comercial = "-";
        public string tecnico = "-";

        public List<EmpresaServico> servs;




        protected void Page_Load(object sender, EventArgs e)
        {


            Empresa emp = new EmpresaDAO().selectEmp(getEmpresaMapa);

            cnpj = emp.Cnpj;
            razaoSocial = emp.RazaoSocial;
            telefone1 = emp.Tel1;
            telefone2 = emp.Tel2;
            endereco = emp.Endereco;
            numero = emp.Numero.ToString();
            complemento = emp.Complemento;
            cep = emp.Cep;
            qtdFunc = emp.QtdFuncionarios.ToString();
            repQ = emp.RepQualidade.ToString();
            repA = emp.RepAtendimento.ToString();
            repT = emp.RepTempo.ToString();
            cadastro = emp.DataCadastro.ToString();
            descricao = emp.DescEmpresa;



            Usuario ueDiretor = new UsuarioDAO().selectUser(emp.IdDiretor);
            Usuario ueComercial = new UsuarioDAO().selectUser(emp.IdComercial);
            Usuario ueTecnico = new UsuarioDAO().selectUser(emp.IdTecnico);


            diretor = ueDiretor.Nome;
            comercial = ueComercial.Nome;
            tecnico = ueTecnico.Nome;

            servs = new EmpresaServicoDAO().selectAllServicoPorEmpresa(emp.Id);




        }


        //contratar


    }
}