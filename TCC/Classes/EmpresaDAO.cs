using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class EmpresaDAO
    {
        public void insertEmpresa(Empresa emp)
        {
            //Vou deixar bem separado o que é oq pra ficar mais claro
            string sql = "INSERT INTO empresa (id, id_diretor, id_comercial, id_tecnico, cnpj, razao_social," +
                "telefone1, telefone2, endereco, numero, complemento, cep, cidade, inicio_empresa, descricao_empresa," +
                "qtd_funcionarios, reputacao_tempo, reputacao_qualidade, reputacao_atendimento, reputacao_quantidade," +
                "reputacao_fiscal, zona_atendimento, data_cadastro, block) " +
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
                "'" + emp.Cidade + "'," +
                "'" + emp.InicioEmpresa + "'," +
                "'" + emp.DescEmpresa + "'," +
                "'" + emp.QtdFuncionarios + "'," +
                "'" + emp.RepTempo + "'," +
                "'" + emp.RepQualidade + "'," +
                "'" + emp.RepAtendimento + "'," +
                "'" + emp.RepQuantidade + "'," +
                "'" + emp.RepFiscal + "'," +
                "'" + emp.ZonaAtendimento + "'," +
                "'" + emp.DataCadastro.ToString("MM/dd/yyyy HH:mm:ss") + "'," +
                "'" + emp.Block + "'," +
                "); ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
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
                "cidade = '" + emp.Cidade + "', " +
                "inicio_empresa = '" + emp.InicioEmpresa.ToString("MM/dd/yyyy HH:mm:ss") + "'," +
                "descricao_empresa = '" + emp.DescEmpresa + "'," +
                "qtd_funcionarios = '" + emp.QtdFuncionarios + "'," +
                "reputacao_tempo = '" + emp.RepTempo + "'," +
                "reputacao_qualidade = '" + emp.RepQualidade + "'," +
                "reputacao_atendimento = '" + emp.RepAtendimento + "'," +
                "reputacao_quantidade = '" + emp.RepQuantidade + "'," +
                "reputacao_fiscal= '" + emp.RepFiscal + "'," +
                "zona_atendimento = '" + emp.ZonaAtendimento + "'," +
                "data_cadastro = '" + emp.DataCadastro.ToString("MM/dd/yyyy HH:mm:ss") + "'," +
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


        public List<Empresa> selectAllEmps()
        {
            string sql = "SELECT * FROM empresa";
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

        public List<Empresa> selectAllEmpsFiltradas(string cat, string pesq)
        {
            string sql = "SELECT * FROM empresa WHERE (descricao_empresa like '%" + pesq+ "%' or razao_social like '%" + pesq + "%') ";
            List<Empresa> emps = new List<Empresa>();
            Empresa emp = new Empresa();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            if (reader.HasRows)
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
            emp.Cidade = reader.GetString(14);
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