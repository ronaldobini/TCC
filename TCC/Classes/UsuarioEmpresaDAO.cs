using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class UsuarioEmpresaDAO
    {
        public void insertUserEmp(UsuarioEmpresa userEmp)
        {
            string sql = "INSERT INTO usuario_empresa(id, id_usuario,id_empresa, funcao, nivel_empresa, qtd_servicos, nivel_escolar," +
                " formacao, reputacao_media)" +
                " VALUES (" +
                " NULL," +
                "'" + userEmp.IdUsuario + "'," +
                "'" + userEmp.IdEmpresa + "'," +
                "'" + userEmp.Funcao + "'," +
                "'" + userEmp.NivelEmp + "'," +
                "'" + userEmp.QtdServicos + "'," +
                "'" + userEmp.NivelEscolar + "'," +
                "'" + userEmp.Formacao + "'," +
                "'" + userEmp.RepMedia + "'" +
                ");";

            MySqlConnection conn = new Conn().conectar();
            string msg = new Conn().executar(sql, conn);
            conn.Close();

        }
        public void updateUsuarioEmpresa(UsuarioEmpresa userEmp)
        {
            string sql = "UPDATE empresa " +
                " SET id_usuario = " + userEmp.IdUsuario + "," +
                " id_empresa = '" + userEmp.IdEmpresa + "'," +
                " funcao = '" + userEmp.Funcao + "'," +
                " nivel_empresa = '" + userEmp.NivelEmp + "'," +
                " qtd_servicos = '" + userEmp.QtdServicos + "'," +
                " nivel_escolar = '" + userEmp.NivelEscolar + "'," +
                " formacao = '" + userEmp.Formacao + "'," +
                " reputacao_media = '" + userEmp.RepMedia + "'" +
                " WHERE id = " + userEmp.Id + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void deleteUsuarioEmpresa(UsuarioEmpresa userEmp)
        {
            string sql = "DELETE FROM usuario_empresa WHERE id = " + userEmp.Id;

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

        public UsuarioEmpresa selectUserIdUser(int idUser)
        {
            string sql = "SELECT * FROM usuario_empresa WHERE id_usuario = '" + idUser + "'";
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
            }
            conn.Close();
            return userEmp;
        }
        public UsuarioEmpresa selectUserIdEmpresa(int idEmpresa)
        {
            string sql = "SELECT * FROM usuario_empresa WHERE id_empresa = '" + idEmpresa + "'";
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
                //userEmp.Id = -1;
                //userEmp.Senha = "!!xxxxxxx!!";
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
            userEmp.IdUsuario = reader.GetInt32(1);
            userEmp.IdEmpresa = reader.GetInt32(2);
            userEmp.Funcao = reader.GetString(3);
            userEmp.NivelEmp = reader.GetInt32(4);
            userEmp.QtdServicos = reader.GetInt32(5);
            userEmp.NivelEscolar = reader.GetString(6);
            userEmp.Formacao = reader.GetString(7);
            userEmp.RepMedia = reader.GetInt32(8);
            return userEmp;
        }

        //public UsuarioEmpresa autenticaUser(string login, string senha)
        //{
        //    UsuarioEmpresa logando = new UsuarioEmpresa();

        //    logando = selectUserLogin(login);

        //    //Algum outro erro
        //    if (logando != null)
        //    {
        //        //Se nao for encontrado login
        //        if (logando.Id == -1)
        //        {
        //            return logando;
        //        }

        //        if (logando.Senha == senha)
        //        {
        //            //login e senha ok
        //        }
        //        else
        //        {
        //            //senha incorreta
        //            logando.Id = 0;
        //        }
        //    }
        //    else
        //    {
        //        //Se nao for encontrado login
        //        logando.Id = -1;
        //    }

        //    return logando;
        //}

    }


}