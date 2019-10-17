using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class EstadoDAO
    {
        public Estado selectEstado(Estado est)
        {
            string sql = "SELECT * FROM estado WHERE id = " + est.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                est = preencherEst(reader);
            }
            conn.Close();
            return est;
        }
        public Estado selectEstadoPorNome(string nome)
        {
            string sql = "SELECT * FROM estado WHERE nome = " + nome;
            Estado est = new Estado();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                est = preencherEst(reader);
            }
            conn.Close();
            return est;
        }
        public List<Estado> selectAllEsts()
        {
            string sql = "SELECT * FROM estado";
            List<Estado> ests = new List<Estado>();
            Estado est = new Estado();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                est = preencherEst(reader);
                ests.Add(est);
            }
            conn.Close();
            return ests;
        }
        private Estado preencherEst(MySqlDataReader reader)
        {
            Estado est = new Estado();
            est.Id = reader.GetInt32(0);
            est.Nome = reader.GetString(1);
            est.IdPais = reader.GetInt32(2);
            return est;
        }
    }
}