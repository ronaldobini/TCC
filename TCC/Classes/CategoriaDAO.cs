using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class CategoriaDAO
    {
        public Categoria selectCat(int id)
        {
            string sql = "SELECT * FROM categoria WHERE id = " + id;
            Categoria cat = new Categoria();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                cat = preencherCat(reader);
            }
            conn.Close();
            return cat;
        }
        public Categoria selectCatPorDesc(string desc)
        {
            string sql = "SELECT * FROM categoria WHERE descricao = " + desc;
            Categoria cat = new Categoria();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                cat = preencherCat(reader);
            }
            conn.Close();
            return cat;
        }
        public List<Categoria> selectAllCategorias()
        {
            string sql = "SELECT * FROM categoria";
            List<Categoria> cats = new List<Categoria>();
            Categoria cat = new Categoria();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                cat = preencherCat(reader);
                cats.Add(cat);
            }
            conn.Close();
            return cats;
        }
        private Categoria preencherCat(MySqlDataReader reader)
        {
            Categoria cat = new Categoria();
            cat.Id = reader.GetInt32(0);
            cat.Descricao = reader.GetString(1);
            cat.Ordem = reader.GetInt32(2);
            return cat;
        }
    }
}