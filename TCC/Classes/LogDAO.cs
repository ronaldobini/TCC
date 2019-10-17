using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class LogDAO
    {
        public void insertLog(Log log)
        {
            string sql = "INSERT INTO log(id, acao, tempo, id_user) VALUES (NULL," +
                "'" + log.Acao + "'," +
                "'" + log.Tempo + "'," +
                "" + log.IdUser + "" +
                ") ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public Log selectLog(Log log)
        {
            string sql = "SELECT * FROM log WHERE id = " + log.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                log = preencherLog(reader);
            }
            conn.Close();
            return log;
        }
        public List<Log> selectAllLog()
        {
            string sql = "SELECT * FROM log";
            List<Log> logs = new List<Log>();
            Log log = new Log();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                log = preencherLog(reader);
                logs.Add(log);
            }
            conn.Close();
            return logs;
        }
        private Log preencherLog(MySqlDataReader reader)
        {
            Log log = new Log();
            log.Id = reader.GetInt32(0);
            log.Acao = reader.GetString(1);
            log.Tempo = reader.GetDateTime(2);
            log.IdUser = reader.GetInt32(3);
            return log;
        }
    }
}