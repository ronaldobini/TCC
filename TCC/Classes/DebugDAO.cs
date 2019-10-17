using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class DebugDAO
    {
        public void insertDebug(Debug deb)
        {
            string sql = "INSERT INTO debug(id, processo, tempo, resultados, info) VALUES (NULL," +
                "'" + deb.Processo + "'," +
                "" + deb.Tempo + "," +
                "'" + deb.Resultados + "'," +
                "'" + deb.Info + "'," +
                ") ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public Debug selectDebug(Debug deb)
        {
            string sql = "SELECT * FROM debug WHERE id = " + deb.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                deb = preencherDebug(reader);
            }
            conn.Close();
            return deb;
        }
        public List<Debug> selectAllDebug()
        {
            string sql = "SELECT * FROM debug";
            List<Debug> paises = new List<Debug>();
            Debug deb = new Debug();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                deb = preencherDebug(reader);
                paises.Add(deb);
            }
            conn.Close();
            return paises;
        }
        private Debug preencherDebug(MySqlDataReader reader)
        {
            Debug deb = new Debug();
            deb.Id = reader.GetInt32(0);
            deb.Processo = reader.GetString(1);
            deb.Tempo = reader.GetDateTime(2);
            deb.Resultados = reader.GetString(3);
            deb.Info = reader.GetString(4);
            return deb;
        }
    }
}
}