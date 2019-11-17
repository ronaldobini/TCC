using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class UsuarioDAO
    {
        public string insertUser(Usuario user)
        {
            //Vou deixar bem separado o que é oq pra ficar mais claro
            string sql = "INSERT INTO usuario (id, login, senha, nome, email, " +
                " cpf, telefone1, telefone2, endereco, numero, complemento, " +
                " cep, id_cidade, reputacao, data_cadastro, ultimo_login, erros_senha, " +
                " block, qtd_servicos) " +
                " VALUES( " + 
                " NULL, " + // ID
                " '" + user.Login + "', " + // Login
                " '" + user.Senha + "', " + // Senha
                " '" + user.Nome + "', " + // Nome
                " '" + user.Email + "', " + // E-mail
                " '" + user.Cpf + "', " + // CPF
                " '" + user.Tel1 + "', " + // Tel1
                " '" + user.Tel2 + "', " + // Tel2
                " '" + user.Endereco + "', " + // Endereco
                " " + user.Numero + ", " + // Numero
                " '" + user.Complemento + "', " + // Complemento
                " '" + user.Cep + "', " + // Cep
                " " + user.Cidade.Id + ", " + // Cidade
                " " + user.Reputacao + ", " + // Reputacao
                " '" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "', " + // Data Cadastro
                " '" + user.UltimoLogin.ToString() + "', " + // Data Ultimo Login
                " " + user.ErrosSenha + ", " + // Erros Senha
                " " + user.Block + ", " + // Block
                " " + user.QtdServicos + " " + // QTD SERVICOS
                "); ";
            string msg = "";
            MySqlConnection conn = new Conn().conectar();
            if (new Conn().executar(sql, conn))
            {
                msg = "Sucesso ao cadastrar usuario";
            }
            else
            {
                msg = "Sucesso ao cadastrar usuario";

            }
            conn.Close();
            return msg;
        }
        public void updateUser(Usuario user)
        {
            string sql = "UPDATE usuario" +
                " SET senha = '" + user.Senha + "'," +
                "  nome = '" + user.Nome + "', " +
                " email = '" + user.Email + "',  " +
                " cpf = '" + user.Cpf + "', " +
                " telefone1= '" + user.Tel1 + "', " +
                " telefone2 = '" + user.Tel2 + "', " +
                " endereco = '" + user.Endereco + "', " +
                " numero = " + user.Numero +
                " ,complemento = '" + user.Complemento + "', " +
                " cep = '" + user.Cep + "', " +
                " id_cidade = " + user.Cidade.Id +
                " ,reputacao = " + user.Reputacao + 
                " ,data_cadastro = '" + user.DataCadastro.ToString() + "', " +
                " ultimo_login = '" + user.UltimoLogin.ToString() + "', " +
                " erros_senha = " + user.ErrosSenha+
                " ,block = " + user.Block +
                " ,qtd_servicos = " + user.QtdServicos + 
                " WHERE id  = " + user.Id ;

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void deleteUser(int id)
        {
            //string sql = "DELETE FROM usuario WHERE id = " + id;
            string sql = "UPDATE usuario SET block = 1 WHERE id = " + id;
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public Usuario selectUserComUser(Usuario user)
        {
            string sql = "SELECT * FROM usuario WHERE id = " + user.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                user = preencherUser(reader);
            }
            conn.Close();
            return user;
        }
        public Usuario selectUser(int id)
        {
            string sql = "SELECT * FROM usuario WHERE block = 0 AND id = " + id;
            Usuario user = new Usuario();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                user = preencherUser(reader);
            }
            conn.Close();
            return user;
        }

        public Usuario selectUserLogin(string login)
        {
            string sql = "SELECT * FROM usuario WHERE login = '" + login+"'";
            Usuario user = new Usuario();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            //Se nao for encontrado login
            if (reader != null)
            {
                while (reader.Read() && reader.HasRows)
                {
                    user = preencherUser(reader);
                }
            }
            else
            {
                //Se nao for encontrado login
                user.Id = -1;
                user.Senha = "!!xxxxxxx!!";
            }
            conn.Close();
            return user;
        }


        public List<Usuario> selectAllUsers()
        {
            string sql = "SELECT * FROM usuario WHERE block = 0";
            List<Usuario> users = new List<Usuario>();
            Usuario user = new Usuario();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                user = preencherUser(reader);
                users.Add(user);
            }
            conn.Close();
            return users;
        }
        public void updateErrosSenha(Usuario user, int erros)
        {

        }

        //So pra facilitar ja que vai precisar usar mais de uma vez
        private Usuario preencherUser(MySqlDataReader reader)
        {
            Usuario user = new Usuario();
            user.Id = reader.GetInt32(0);
            user.Login = reader.GetString(1);
            user.Senha = reader.GetString(2);
            user.Nome = reader.GetString(3);
            user.Email = reader.GetString(4);
            user.Cpf = reader.GetString(5);
            user.Tel1 = reader.GetString(6);
            user.Tel2 = reader.GetString(7);
            user.Endereco = reader.GetString(8);
            user.Numero = reader.GetInt32(9);
            user.Complemento = reader.GetString(10);
            user.Cep = reader.GetString(11);
            user.Cidade = new CidadeDAO().selectCidadePorId(reader.GetInt32(12));
            user.Reputacao = reader.GetInt32(13);
            user.DataCadastro = reader.GetMySqlDateTime(14);
            user.UltimoLogin = reader.GetMySqlDateTime(15);
            user.ErrosSenha = reader.GetInt32(16);
            user.Block = reader.GetInt32(17);
            user.QtdServicos = reader.GetInt32(18);
            user.UserEmp = new UsuarioEmpresaDAO().selectUserIdUser(user.Id);
            return user;
        }


        public Usuario autenticaUser(string login, string senha)
        {
            Usuario logando = new Usuario();

            logando = selectUserLogin(login);
            
            //Algum outro erro
            if (logando != null)
            {
                //Se nao for encontrado login
                if (logando.Id == -1)
                {
                    return logando;
                }

                if (logando.Senha == senha)
                {
                    //login e senha ok
                }
                else
                {
                    //senha incorreta
                    logando.Id = 0;
                }
            }
            else
            {
                //Se nao for encontrado login
                logando.Id = -1;
            }

            return logando;
        }


     

    }
}