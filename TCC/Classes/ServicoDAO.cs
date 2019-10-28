using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace TCC.Classes
{
    public class ServicoDAO
    {
        public void insertServico(Servico serv)
        {
            //Vou deixar bem separado o que é oq pra ficar mais claro
            string sql = "INSERT INTO servico (id, id_usuairo, id_empresa, id_repres_empresa, data_inicio, id_categoria, id_empresa_servico," +
                "descricao_usuario,prioridade, valor, data_fim_estimada,data_fim, situacao, aceite_usuario, aceite_empresa," +
                "reputacao_tempo, reputacao_qualidade,reputacao_atendimento, obs_finais_usuario	,obs_finais_empresa) " +
                " VALUES( " +
                " NULL, " +
                "" + serv.IdUser + "," +
                "" + serv.IdEmp + "," +
                "" + serv.IdRepresEmp + "," +
                "" + serv.DataIni.ToString("MM/dd/yyyy HH:mm:ss") + "'," +
                "" + serv.IdCat + "," +
                "" + serv.IdEmpSer + "," +
                "'" + serv.DescUser + "'," +
                "" + serv.Prioridade + "," +
                "" + serv.Valor + "," +
                "" + serv.DataFim.ToString("MM/dd/yyyy HH:mm:ss") + "," +
                "" + serv.Sit + "," +
                "" + serv.AceiteUser + "," +
                "" + serv.AceiteEmp + "," +
                "" + serv.RepTempo + "," +
                "" + serv.RepQualidade + "," +
                "" + serv.RepAtendimento + "," +
                "'" + serv.ObsFinUser + "'," +
                "'" + serv.ObsFinEmp + "'," +
                "); ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void updateServico(Servico serv)
        {
            string sql = "UPDATE servico " +
                "SET id_usuario = " + serv.IdUser + "," +
                "id_empresa = " + serv.IdEmp + "," +
                "id_repres_empresa = " + serv.IdRepresEmp + "," +
                "data_inicio = " + serv.DataIni + "," +
                "id_categoria = " + serv.IdCat + "," +
                "descricao_usuario = " + serv.DescUser + "," +
                "prioridade = " + serv.Prioridade + "," +
                "valor = " + serv.Valor + "," +
                "data_fim_estimada = " + serv.DataFimEst + "," +
                "data_fim = " + serv.DataFim + "," +
                "situacao = " + serv.Sit + "," +
                "aceite_usuario = " + serv.AceiteUser + "," +
                "aceite_empresa = " + serv.AceiteEmp + "," +
                "reputacao-tempo = " + serv.RepTempo + "," +
                "reputacao-qualidade = " + serv.RepQualidade + "," +
                "reputacao-atendimento = " + serv.RepAtendimento + "," +
                "obs_finais_usuario = " + serv.ObsFinUser + "," +
                "obs_finais_empresa = " + serv.ObsFinEmp + "," +
                " WHERE id  = " + serv.Id + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void deleteServico(Servico serv)
        {
            string sql = "DELETE FROM servico WHERE id = " + serv.Id;

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public Servico selectServicoComServico(Servico serv)
        {
            string sql = "SELECT * FROM servico WHERE id = " + serv.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                serv = preencherServ(reader);
            }
            conn.Close();
            return serv;
        }
        public Servico selectServico(int id)
        {
            string sql = "SELECT * FROM servico WHERE id = " + id;
            Servico serv = new Servico();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                serv = preencherServ(reader);
            }
            conn.Close();
            return serv;
        }


        public List<Servico> selectAllServs()
        {
            string sql = "SELECT * FROM empresa";
            List<Servico> servs = new List<Servico>();
            Servico serv = new Servico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                serv = preencherServ(reader);
                servs.Add(serv);
            }
            conn.Close();
            return servs;
        }
        public List<Servico> selectAllServsUser(int idUser)
        {
            string sql = "SELECT * FROM empresa WHERE id_usuario = " + idUser;
            List<Servico> servs = new List<Servico>();
            Servico serv = new Servico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                serv = preencherServ(reader);
                servs.Add(serv);
            }
            conn.Close();
            return servs;
        }
        public List<Servico> selectAllServsEmp(int idEmp)
        {
            string sql = "SELECT * FROM servico WHERE id_empresa = " + idEmp;
            List<Servico> servs = new List<Servico>();
            Servico serv = new Servico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                serv = preencherServ(reader);
                servs.Add(serv);
            }
            conn.Close();
            return servs;
        }
        public List<Servico> selectAllServsRepresEmp(int idRepEmp)
        {
            string sql = "SELECT * FROM empresa WHERE id_usuario = " + idRepEmp;
            List<Servico> servs = new List<Servico>();
            Servico serv = new Servico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);

            while (reader.Read() && reader.HasRows)
            {
                serv = preencherServ(reader);
                servs.Add(serv);
            }
            conn.Close();
            return servs;
        }
        //So pra facilitar ja que vai precisar usar mais de uma vez
        private Servico preencherServ(MySqlDataReader reader)
        {
            Servico serv = new Servico();
            serv.Id = reader.GetInt32(0);
            serv.IdUser = reader.GetInt32(1);
            serv.IdEmp = reader.GetInt32(2);
            serv.IdRepresEmp = reader.GetInt32(3);
            serv.DataIni = reader.GetDateTime(4);
            serv.IdCat = reader.GetInt32(5);
            serv.IdEmpSer = reader.GetInt32(6);
            serv.DescUser = reader.GetString(7);
            serv.Prioridade = reader.GetInt32(8);
            serv.Valor = reader.GetDouble(9);
            serv.DataFimEst = reader.GetDateTime(10);
            serv.DataFim = reader.GetDateTime(11);
            serv.Sit = reader.GetInt32(12);
            serv.AceiteUser = reader.GetInt32(13);
            serv.AceiteEmp = reader.GetInt32(14);
            serv.RepTempo = reader.GetDouble(15);
            serv.RepQualidade = reader.GetDouble(16);
            serv.RepAtendimento = reader.GetDouble(17);
            serv.ObsFinUser = reader.GetString(18);
            serv.ObsFinEmp = reader.GetString(19);

            return serv;
        }
    }
}