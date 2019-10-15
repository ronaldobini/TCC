using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class PaisDAO
    {
        public void insertPais(Pais pais)
        {
            string sql = "INSERT INTO pais(id, nome) VALUES (NULL,"+ pais.Nome +") ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void updatePais(Pais pais)
        {
            string sql = "UPDATE pais SET nome = " + pais.Nome + " WHERE id = " + pais.Id + " ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void deletePais(Pais pais)
        {
            string sql = "DELETE FROM pais WHERE id = " + pais.Id;
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public Pais selectPais(Pais pais)
        {
            string sql = "SELECT * FROM pais WHERE id = " + pais.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                pais = preencherPais(reader);
            }
            conn.Close();
            return pais;
        }
        public List<Pais> selectAllPaises()
        {
            string sql = "SELECT * FROM pais";
            List<Pais> paises = new List<Pais>();
            Pais pais = new Pais();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                pais = preencherPais(reader);
                paises.Add(pais);
            }
            conn.Close();
            return paises;
        }
        private Pais preencherPais(MySqlDataReader reader)
        {
            Pais pais = new Pais();
            pais.Id = reader.GetInt32(0);
            pais.Nome = reader.GetString(1);
            return pais;
        }
    }
}