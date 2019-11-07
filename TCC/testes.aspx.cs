using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;
using MySql.Data.MySqlClient;

namespace TCC
{
    public partial class testes : System.Web.UI.Page
    {

        public List<Empresa> lista = new List<Empresa>();

        protected void Page_Load(object sender, EventArgs e)
        {

            lista = selectAllEmpsFiltradas(1,"");
           
        }








        public List<Empresa> selectAllEmpsFiltradas(int cat, string pesq)
        {
            string sql = "SELECT e.razao_social, e.desc_empresa FROM empresa e, empresa_servicos es WHERE (e.descricao_empresa like '%" + pesq + "%' or e.razao_social like '%" + pesq + "%')";


            List<Empresa> emps = new List<Empresa>();
            Empresa emp = new Empresa();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            if (reader != null)
            {
                while (reader.Read() && reader.HasRows)
                {
                    emp = preencherEmp(reader);
                    emps.Add(emp);
                }
            }
            else
            {
                emps = null;
            }


            conn.Close();
            return emps;
        }



        private Empresa preencherEmp(MySqlDataReader reader)
        {
            Empresa emp = new Empresa();
            emp.Id = reader.GetInt32(0);
            emp.IdDiretor = reader.GetInt32(1);
            emp.IdComercial = reader.GetInt32(2);
            emp.IdTecnico = reader.GetInt32(3);
            emp.Cnpj = reader.GetString(4);
            emp.RazaoSocial = reader.GetString(5);
            emp.Tel1 = reader.GetString(6);
            emp.Tel2 = reader.GetString(7);
            emp.Endereco = reader.GetString(8);
            emp.Numero = reader.GetInt32(9);
            emp.Complemento = reader.GetString(10);
            emp.Cep = reader.GetString(11);
            emp.Lat = reader.GetString(12);
            emp.Lon = reader.GetString(13);
            emp.IdCidade = reader.GetInt32(14);
            emp.InicioEmpresa = reader.GetDateTime(15);
            emp.DescEmpresa = reader.GetString(16);
            emp.QtdFuncionarios = reader.GetInt32(17);
            emp.RepTempo = reader.GetInt32(18);
            emp.RepQualidade = reader.GetInt32(19);
            emp.RepAtendimento = reader.GetInt32(20);
            emp.RepQuantidade = reader.GetInt32(21);
            emp.RepFiscal = reader.GetInt32(22);
            emp.ZonaAtendimento = reader.GetString(23);
            emp.DataCadastro = reader.GetDateTime(24);
            emp.Block = reader.GetInt32(25);

            return emp;
        }






    }
}