using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class CidadeDAO    {
        public Cidade selectCidade(Cidade cid)
        {
            string sql = "SELECT * FROM cidade WHERE id = " + cid.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                cid = preencherCid(reader);
            }
            conn.Close();
            return cid;
        }
        public Cidade selectCidadePorId(int id)
        {
            string sql = "SELECT * FROM cidade WHERE id = " + id;
            Cidade cid = new Cidade();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                cid = preencherCid(reader);
            }
            conn.Close();
            return cid;
        }
        public Cidade selectCidadePorNome(string nome)
        {
            string sql = "SELECT * FROM cidade WHERE nome = '" + nome + "'";
            Cidade cid = new Cidade();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader != null && reader.HasRows && reader.Read() )
            {
                cid = preencherCid(reader);
            }
            conn.Close();
            return cid;
        }
        public List<Cidade> selectAllCids()
        {
            string sql = "SELECT * FROM cidade";
            List<Cidade> cids = new List<Cidade>();
            Cidade cid = new Cidade();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                cid = preencherCid(reader);
                cids.Add(cid);
            }
            conn.Close();
            return cids;
        }
        private Cidade preencherCid(MySqlDataReader reader)
        {
            Cidade cid = new Cidade();
            cid.Id = reader.GetInt32(0);
            cid.Nome = reader.GetString(1);
            cid.IdEstado = reader.GetInt32(2);
            cid.IdPais = reader.GetInt32(3);
            return cid;
        }
    }
}
