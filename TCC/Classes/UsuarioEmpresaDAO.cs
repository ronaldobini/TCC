using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class UsuarioEmpresaDAO
    {
        public string DesativarUsuario(int id)
        {
            string msg = "";
            string sql = String.Format("update usuario_empresa set fl_ativo=1 where id_usuario={0}", id);
            MySqlConnection conn = new Conn().conectar();
            if (new Conn().executar(sql, conn))
            {
                msg = "Sucesso ao cadastrar usuario";
            }
            else
            {
                msg = "Erro ao cadastrar usuario";

            }
            conn.Close();
            return msg;
        }

        public string ReativarUsuario(int id)
        {
            string msg = "";
            string sql = String.Format("update usuario_empresa set fl_ativo=0 where id_usuario={0}", id);
            MySqlConnection conn = new Conn().conectar();
            if (new Conn().executar(sql, conn))
            {
                msg = "Sucesso ao cadastrar usuario";
            }
            else
            {
                msg = "Erro ao cadastrar usuario";

            }
            conn.Close();
            return msg;
        }
        public string insertUserEmp(UsuarioEmpresa userEmp)
        {
            string msg = "";
            string sql = "INSERT INTO usuario_empresa(id, id_usuario,id_empresa, funcao, nivel_empresa, qtd_servicos, nivel_escolar," +
                " formacao, reputacao_media,id_escolaridade,fl_ativo)" +
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
                ","+userEmp.IdEscolar+",0);";

            MySqlConnection conn = new Conn().conectar();
            if (new Conn().executar(sql, conn))
            {
                 msg = "Sucesso ao cadastrar usuario";
            }
            else
            {
                msg = "Erro ao cadastrar usuario";

            }
            conn.Close();
            return msg;
        }
        public void updateUsuarioEmpresa(UsuarioEmpresa userEmp)
        {
            string sql = "UPDATE usuario_empresa " +
                " SET  funcao = '" + userEmp.Funcao + "'," +
                " nivel_empresa = " + userEmp.NivelEmp + "," +
                " qtd_servicos = " + userEmp.QtdServicos + "," +
                " nivel_escolar = '" + userEmp.NivelEscolar + "'," +
                " formacao = '" + userEmp.Formacao + "'," +
                " reputacao_media = " + userEmp.RepMedia + 
                ",id_escolaridade=" + userEmp.IdEscolar+ " WHERE id_usuario = " + userEmp.IdUsuario + " ";

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
        public List<UsuarioEmpresa> selectUsersIdEmpresa(int idEmpresa)
        {
            string sql = "SELECT * FROM usuario_empresa WHERE id_empresa = '" + idEmpresa + "' order by nivel_empresa ";
            List<UsuarioEmpresa> usersEmp = new List<UsuarioEmpresa>();
            UsuarioEmpresa userEmp = new UsuarioEmpresa();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            //Se nao for encontrado login
            if (reader != null)
            {
                while (reader.Read() && reader.HasRows)
                {
                    userEmp = preencherUserEmp(reader);
                    usersEmp.Add(userEmp);
                }
            }
            else
            {
                //Se nao for encontrado login
                //userEmp.Id = -1;
                //userEmp.Senha = "!!xxxxxxx!!";
            }
            conn.Close();
            return usersEmp;
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
            userEmp.IdEscolar = reader.GetInt32(9);
            userEmp.FlAtivo = reader.GetInt16(10);

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