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

        

        public int getEmpresaMapa = 0;

        public string cnpj = "-";
        public string razaoSocial = "-";
        public string telefone1 = "-";
        public string telefone2 = "-";
        public string endereco = "-";
        public string numero = "-";
        public string complemento = "-";
        public string cep = "-";
        public string qtdFunc = "-";
        public string qtdServ = "-";
        public string repQ = "-";
        public string repA = "-";
        public string repT = "-";
        public string cadastro = "-";
        public string descricao = "-";
        public string diretor = "-";
        public string comercial = "-";
        public string tecnico = "-";
        public string zona = "-";



        public List<EmpresaServico> servs;




        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["idEmpDet"] != null)
            {
                getEmpresaMapa = Int32.Parse(Request.QueryString["idEmpDet"]);

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
                qtdServ = emp.QtdServ.ToString();
                zona = emp.ZonaAtendimento;

                repQ = "Atendimento (" + repQ + "%)<div class=\"progress\" style=\"width:85px; height: 7px;\">" +
                                  "<div class=\"progress-bar progress-bar-striped progress-bar-animated role=\"progressbar\" style=\"width: " + repQ + "%\"; aria-valuenow=\"" + repQ + "\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>" +
                                "</div>";
                repA = "Qualidade (" + repA + "%)<div class=\"progress\" style=\"width:85px; height: 7px;\">" +
                                  "<div class=\"progress-bar progress-bar-striped progress-bar-animated role=\"progressbar\" style=\"width: " + repA + "%\"; aria-valuenow=\"" + repA + "\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>" +
                                "</div>";
                repT = "Tempo (" + repT + "%)<div class=\"progress\" style=\"width:85px; height: 7px;\">" +
                                  "<div class=\"progress-bar progress-bar-striped progress-bar-animated role=\"progressbar\" style=\"width: " + repT + "%\"; aria-valuenow=\"" + repT + "\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>" +
                                "</div>";

                Usuario ueDiretor = new UsuarioDAO().selectUser(emp.IdDiretor);
                Usuario ueComercial = new UsuarioDAO().selectUser(emp.IdComercial);
                Usuario ueTecnico = new UsuarioDAO().selectUser(emp.IdTecnico);


                diretor = ueDiretor.Nome;
                comercial = ueComercial.Nome;
                tecnico = ueTecnico.Nome;

                servs = new EmpresaServicoDAO().selectAllServicoPorEmpresa(emp.Id);


            }
            else
            {
                razaoSocial = "ERRO AO OBTER A EMPRESA A PARTIR DO MAPA";
                descricao = "ERRO AO OBTER A EMPRESA A PARTIR DO MAPA";
            }


            




        }


        //contratar


    }
}