using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class ServicoTecnicoDAO
    {
        public void insertServTec(ServicoTecnico servTec)
        {
            //Vou deixar bem separado o que é oq pra ficar mais claro
            string sql = "INSERT INTO servico_tecnicos (id, id_servico, id_tecnico, reputacao_servico, obs_usuario) " +
                " VALUES( " +
                " NULL, " +
                " " + servTec.IdServ + ", " +
                " " + servTec.IdTec + ", " +
                " " + servTec.RepServ + ", " +
                " '" + servTec.ObsUser + "' " +
                "); ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void updateServTec(ServicoTecnico servTec)
        {
            string sql = "UPDATE servico_tecnicos " +
                " SET id_servico = " + servTec.IdServ + ", " +
                "id_tecnico = " + servTec.IdTec + ", " +
                "reputacao_servico = " + servTec.RepServ + ", " +
                "obs_usuario = '" + servTec.ObsUser + "' " +
                " WHERE id  = " + servTec.Id + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void deleteServTec(ServicoTecnico servTec)
        {
            string sql = "DELETE FROM servico_tecnicos WHERE id = " + servTec.Id;

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public ServicoTecnico selectServTec(ServicoTecnico servTec)
        {
            string sql = "SELECT * FROM servico_tecnicos WHERE id = " + servTec.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                servTec = preencherServTec(reader);
            }
            conn.Close();
            return servTec;
        }
        public ServicoTecnico selectServTec(int id)
        {
            string sql = "SELECT * FROM servico_tecnicos WHERE id = " + id;
            ServicoTecnico servTec = new ServicoTecnico();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                servTec = preencherServTec(reader);
            }
            conn.Close();
            return servTec;
        }
        public List<ServicoTecnico> selectServTecsServ(int id)
        {
            string sql = "SELECT * FROM servico_tecnicos WHERE id_servico = " + id;
            List<ServicoTecnico> servTecs = new List<ServicoTecnico>();
            ServicoTecnico servTec = new ServicoTecnico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                servTec = preencherServTec(reader);
                servTecs.Add(servTec);
            }
            conn.Close();
            return servTecs;
        }
        public List<ServicoTecnico> selectServTecsTec(int id)
        {
            string sql = "SELECT * FROM servico_tecnicos WHERE id_tecnico = " + id;
            List<ServicoTecnico> servTecs = new List<ServicoTecnico>();
            ServicoTecnico servTec = new ServicoTecnico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                servTec = preencherServTec(reader);
                servTecs.Add(servTec);
            }
            conn.Close();
            return servTecs;
        }

        public List<ServicoTecnico> selectAllServTecs()
        {
            string sql = "SELECT * FROM servico_tecnicos";
            List<ServicoTecnico> servTecs = new List<ServicoTecnico>();
            ServicoTecnico servTec = new ServicoTecnico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                servTec = preencherServTec(reader);
                servTecs.Add(servTec);
            }
            conn.Close();
            return servTecs;
        }

        private ServicoTecnico preencherServTec(MySqlDataReader reader)
        {
            ServicoTecnico servTec = new ServicoTecnico();
            servTec.Id = reader.GetInt32(0);
            servTec.IdServ = reader.GetInt32(1);
            servTec.IdTec = reader.GetInt32(2);
            servTec.RepServ = reader.GetInt32(3);
            servTec.ObsUser = reader.GetString(4);
            return servTec;
        }

    }
}