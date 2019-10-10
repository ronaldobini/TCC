using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class UsuarioEmpresaDAO
    {
        public void insertEmpresa(UsuarioEmpresa userEmp)
        {
            string sql = "INSERT INTO usuario_empresa(id, id_empresa, login, senha, nome, email, telefone1, telefone2, endereco," +
                " numero, complemento, cep, cidade, funcao, nivel_empresa, qtd_servicos, nivel_escolar, formacao," +
                " reputacao_media, data_cadastro, ultimo_login, erros_senha, block, nivel_acesso)" +
                " VALUES (" +
                " NULL," +
                "'" + userEmp.IdEmpresa + "'," +
                "'" + userEmp.Login + "'," +
                "'" + userEmp.Senha + "'," +
                "'" + userEmp.Nome + "'," +
                "'" + userEmp.Email + "'," +
                "'" + userEmp.Tel1 + "'," +
                "'" + userEmp.Tel2 + "'," +
                "'" + userEmp.Endereco + "'," +
                "'" + userEmp.Numero + "'," +
                "'" + userEmp.Complemento + "'," +
                "'" + userEmp.Cep + "'," +
                "'" + userEmp.Cidade + "'," +
                "'" + userEmp.Funcao + "'," +
                "'" + userEmp.NivelEmp + "'," +
                "'" + userEmp.QtdServicos + "'," +
                "'" + userEmp.NivelEscolar + "'," +
                "'" + userEmp.Formacao + "'," +
                "'" + userEmp.RepMedia + "'," +
                "'" + userEmp.DataCadastro + "'," +
                "'" + userEmp.UltimoLogin + "'," +
                "'" + userEmp.ErrosSenha + "'," +
                "'" + userEmp.Block + "'," +
                "'" + userEmp.Nivel + "'," +
                ");";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();

        }
        public void updateUsuarioEmpresa(UsuarioEmpresa userEmp)
        {
            string sql = "UPDATE empresa " +
                " SET id_empresa = '" + userEmp.IdEmpresa + "'," +
                " login = '" + userEmp.Login + "'," +
                " senha = '" + userEmp.Senha + "'," +
                " nome = '" + userEmp.Nome + "'," +
                " email = '" + userEmp.Email + "'," +
                " cpf = '" + userEmp.Cpf + "'," +
                " telefone1 = '" + userEmp.Tel1 + "'," +
                " telefone2 = '" + userEmp.Tel2 + "'," +
                " endereco = '" + userEmp.Endereco + "'," +
                " numero = '" + userEmp.Numero + "'," +
                " complemento = '" + userEmp.Tel2 + "'," +
                " cep = '" + userEmp.Cep + "'," +
                " cidade = '" + userEmp.Cidade + "'," +
                " funcao = '" + userEmp.Funcao + "'," +
                " nivel_empresa= '" + userEmp.NivelEmp + "'," +
                " qtd_servicos = '" + userEmp.QtdServicos + "'," +
                " nivel_escolar = '" + userEmp.NivelEscolar + "'," +
                " formacao = '" + userEmp.Formacao + "'," +
                " reputacao_media = '" + userEmp.RepMedia + "'," +
                " data_cadastro = '" + userEmp.DataCadastro + "'," +
                " ultimo_login = '" + userEmp.UltimoLogin + "'," +
                " erros_senha = '" + userEmp.ErrosSenha + "'," +
                " block = '" + userEmp.Block + "'," +
                " nivel_acesso = '" + userEmp.Nivel + "'";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void deleteUsuarioEmpresa(UsuarioEmpresa userEmp)
        {
            string sql = "DELETE FROM usuario_empresa WHERE id = " + userEmp.id;

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public UsuarioEmpresa selectUsuarioEmpresaComUser(UsuarioEmpresa userEmp)
        {
            string sql = "SELECT * FROM usuario_empresa WHERE id = " + userEmp.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                userEmp = preencherUserEmp(reader);
            }
            conn.Close();
            return userEmp;
        }



        public UsuarioEmpresa selectUser(int id)
        {
            string sql = "SELECT * FROM usuario_empresa WHERE id = " + id;
            UsuarioEmpresa userEmp = new UsuarioEmpresa();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                userEmp = preencherUserEmp(reader);
            }
            conn.Close();
            return userEmp;
        }

        public UsuarioEmpresa selectUserLogin(string login)
        {
            string sql = "SELECT * FROM usuario_empresa WHERE login = '" + login + "'";
            UsuarioEmpresa userEmp = new UsuarioEmpresa();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            //Se nao for encontrado login
            if (reader != null)
            {
                while (reader.Read() && reader.HasRows)
                {
                    userEmp = preencherUserEmp(reader);
                }
            }
            else
            {
                //Se nao for encontrado login
                userEmp.Id = -1;
                userEmp.Senha = "!!xxxxxxx!!";
            }
            conn.Close();
            return userEmp;
        }


        public List<UsuarioEmpresa> selectAllUsers()
        {
            string sql = "SELECT * FROM usuario_empresa";
            List<UsuarioEmpresa> userEmps = new List<UsuarioEmpresa>();
            UsuarioEmpresa userEmp = new UsuarioEmpresa();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                userEmp = preencherUserEmp(reader);
                userEmps.Add(userEmp);
            }
            conn.Close();
            return userEmps;
        }
        public void updateErrosSenha(Usuario user, int erros)
        {

        }

        //So pra facilitar ja que vai precisar usar mais de uma vez
        private UsuarioEmpresa preencherUserEmp(MySqlDataReader reader)
        {
            UsuarioEmpresa userEmp = new UsuarioEmpresa();
            userEmp.Id = reader.GetInt32(0);
            userEmp.IdEmpresa = reader.GetInt32(1);
            userEmp.Login = reader.GetString(2);
            userEmp.Senha = reader.GetString(3);
            userEmp.Nome = reader.GetString(4);
            userEmp.Email = reader.GetString(5);
            userEmp.Tel1 = reader.GetString(6);
            userEmp.Tel2 = reader.GetString(7);
            userEmp.Endereco = reader.GetString(8);
            userEmp.Numero = reader.GetInt32(9);
            userEmp.Complemento = reader.GetString(10);
            userEmp.Cep = reader.GetString(11);
            userEmp.Cidade = reader.GetString(12);
            userEmp.Funcao = reader.GetString(13);
            userEmp.NivelEmp = reader.GetInt32(14);
            userEmp.QtdServicos = reader.GetInt32(15);
            userEmp.NivelEscolar = reader.GetInt32(16);
            userEmp.Formacao = reader.GetString(17);
            userEmp.RepMedia = reader.GetInt32(18);
            userEmp.DataCadastro = reader.GetDateTime(19);
            userEmp.UltimoLogin = reader.GetDateTime(20);
            userEmp.ErrosSenha = reader.GetInt32(21);
            userEmp.Block = reader.GetInt32(22);
            userEmp.Nivel = reader.GetInt32(23);
            return userEmp;
        }
    }
}