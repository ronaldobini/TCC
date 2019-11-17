using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class EmpresaDAO
    {
        public string insertEmpresa(Empresa emp)
        {
            string msg = "";
            //Vou deixar bem separado o que é oq pra ficar mais claro
            string sql = "INSERT INTO empresa (id, id_diretor, id_comercial, id_tecnico, cnpj, razao_social," +
                "telefone1, telefone2, endereco, numero, complemento, cep, lat, lon, id_cidade, inicio_empresa, descricao_empresa," +
                "qtd_funcionarios, reputacao_tempo, reputacao_qualidade, reputacao_atendimento, reputacao_fiscal, qtd_servicos," +
                "zona_atendimento, data_cadastro, block) " +
                " VALUES( " +
                " NULL, " +
                "'" + emp.IdDiretor + "'," +
                "'" + emp.IdComercial + "'," +
                "'" + emp.IdTecnico + "'," +
                "'" + emp.Cnpj + "'," +
                "'" + emp.RazaoSocial + "'," +
                "'" + emp.Tel1 + "'," +
                "'" + emp.Tel2 + "'," +
                "'" + emp.Endereco + "'," +
                "'" + emp.Numero + "'," +
                "'" + emp.Complemento + "'," +
                "'" + emp.Cep + "'," +
                "'" + emp.Lat + "'," +
                "'" + emp.Lon + "'," +
                "'" + emp.IdCidade + "'," +
                "'" + emp.InicioEmpresa.ToString() + "'," +
                "'" + emp.DescEmpresa + "'," +
                "'" + emp.QtdFuncionarios + "'," +
                "'" + emp.RepTempo + "'," +
                "'" + emp.RepQualidade + "'," +
                "'" + emp.RepAtendimento + "'," +
                "'" + emp.RepFiscal + "'," +
                "'" + emp.QtdServ + "'," +
                "'" + emp.ZonaAtendimento + "'," +
                "'" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "'," +
                "'" + emp.Block + "'" +
                "); ";

            MySqlConnection conn = new Conn().conectar();
            if (new Conn().executar(sql, conn))
            {
                 msg = "Sucesso ao cadastrar empresa";
            }
            else
            {
                 msg = "Erro ao cadastrar empresa";

            }
            conn.Close();
            return msg;
        }
        public void updateEmpresa(Empresa emp)
        {
            string sql = "UPDATE empresa " +
                "SET id_diretor = " + emp.IdDiretor + "," +
                "id_comercial = " + emp.IdComercial + "," +
                "id_tecnico = " + emp.IdTecnico + "," +
                "cnpj = '" + emp.Cnpj + "'," +
                "razao_social = '" + emp.RazaoSocial + "'," +
                "telefone1 = '" + emp.Tel1 + "'," +
                "telefone2 = '" + emp.Tel2 + "'," +
                "endereco = '" + emp.Endereco + "'," +
                "numero = '" + emp.Numero + "'," +
                "complemento = '" + emp.Complemento + "'," +
                "cep = '" + emp.Cep + "'," +
                "lat = '" + emp.Lat + "'," +
                "lon = '" + emp.Lon + "'," +
                "id_cidade = '" + emp.IdCidade + "', " +
                "inicio_empresa = '" + emp.InicioEmpresa.ToString() + "'," +
                "descricao_empresa = '" + emp.DescEmpresa + "'," +
                "qtd_funcionarios = '" + emp.QtdFuncionarios + "'," +
                "reputacao_tempo = '" + emp.RepTempo + "'," +
                "reputacao_qualidade = '" + emp.RepQualidade + "'," +
                "reputacao_atendimento = '" + emp.RepAtendimento + "'," +
                "reputacao_fiscal= '" + emp.RepFiscal + "'," +
                "qtd_servicos = '" + emp.QtdServ + "'," +
                "zona_atendimento = '" + emp.ZonaAtendimento + "'," +
                "data_cadastro = '" + emp.DataCadastro.ToString() + "'," +
                "block = " + emp.Block +
                " WHERE id  = " + emp.Id + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void deleteEmpresa(Empresa emp)
        {
            string sql = "DELETE FROM empresa WHERE id = " + emp.Id;

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public Empresa selectEmpComEmp(Empresa emp)
        {
            string sql = "SELECT * FROM empresa WHERE id = " + emp.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                emp = preencherEmp(reader);
            }
            conn.Close();
            return emp;
        }
        public Empresa selectEmp(int id)
        {
            string sql = "SELECT * FROM empresa WHERE id = " + id;
            Empresa emp = new Empresa();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                emp = preencherEmp(reader);
            }
            conn.Close();
            return emp;
        }
        public Empresa selectEmpPorRazaoSocial(String razaoSocial)
        {
            string sql = "SELECT * FROM empresa WHERE razao_social = " + razaoSocial;
            Empresa emp = new Empresa();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                emp = preencherEmp(reader);
            }
            conn.Close();
            return emp;
        }
        public Empresa selectEmpPorCNPJ(String cnpj)
        {
            string sql = "SELECT * FROM empresa WHERE cnpj = " + cnpj;
            Empresa emp = new Empresa();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                emp = preencherEmp(reader);
            }
            conn.Close();
            return emp;
        }

        public List<Empresa> selectAllEmps()
        {
            string sql = "SELECT * FROM empresa WHERE block = 0";
            List<Empresa> emps = new List<Empresa>();
            Empresa emp = new Empresa();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                emp = preencherEmp(reader);
                emps.Add(emp);
            }
            conn.Close();
            return emps;
        }

        public List<Empresa> selectAllEmpsFiltradas(int cat, string pesq)
        {
            string sql = String.Format("SELECT distinct a.id,a.id_diretor,a.id_comercial,a.id_tecnico,a.cnpj,a.razao_social,a.telefone1,a.telefone2,a.endereco,a.numero,a.complemento,a.cep,a.lat,a.lon,a.id_cidade,a.inicio_empresa,a.descricao_empresa,a.qtd_funcionarios,a.reputacao_tempo,a.reputacao_qualidade,a.reputacao_atendimento,a.reputacao_fiscal,a.qtd_servicos,a.zona_atendimento,a.data_cadastro,a.block FROM empresa a join empresa_servicos b on a.id = b.id_empresa WHERE (descricao_empresa like '%{0}%' or razao_social like '%{0}%' or b.tags like '%{0}%' or b.descricao like '%{0}%' or b.id_categoria={1} and b.fl_ativo=0 and a.block=0)", pesq,cat);
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


        //So pra facilitar ja que vai precisar usar mais de uma vez
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

            emp.InicioEmpresa = reader.GetMySqlDateTime(15);
            emp.DescEmpresa = reader.GetString(16);
            emp.QtdFuncionarios = reader.GetInt32(17);
            emp.RepTempo = reader.GetInt32(18);
            emp.RepQualidade = reader.GetInt32(19);
            emp.RepAtendimento = reader.GetInt32(20);
            emp.RepFiscal = reader.GetInt32(21);
            emp.QtdServ = reader.GetInt32(22);
            emp.ZonaAtendimento = reader.GetString(23);
            emp.DataCadastro = reader.GetMySqlDateTime(24);
            emp.Block = reader.GetInt32(25);

            return emp;
        }

    }
}