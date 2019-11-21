using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace TCC.Classes
{
    public class ServicoDAO
    {

        //Situacao Servico
        // 0 = em solicitacao/negociacao para aceite da empresa
        // 1 = pendente cliente / aceito pela empresa 
        // 2 = em execucao / aceito e pago pelo usuario
        // 3 = aceite final do usuario / executado pela empresa
        // 4 = finalizado
        // -1 =  recusado pela empresa
        // -2 =  em discussao / problemas juridicos

        public void insertServico(Servico serv)
        {
            //Vou deixar bem separado o que é oq pra ficar mais claro
            string sql = "INSERT INTO servico (id, id_usuario, id_empresa, id_repres_empresa, data_inicio, id_categoria, id_empresa_servico," +
                "descricao_usuario,prioridade, valor, data_fim_estimada,data_fim, situacao, aceite_usuario, aceite_empresa," +
                "reputacao_tempo, reputacao_qualidade,reputacao_atendimento, obs_finais_usuario, obs_finais_empresa) " +
                " VALUES( " +
                " NULL, " +
                "" + serv.IdUser + "," +
                "" + serv.IdEmp + "," +
                "" + serv.IdRepresEmp + "," +
                "'" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "'," +
                "" + serv.Categoria.Id + "," +
                "" + serv.IdEmpSer + "," +
                "'" + serv.DescUser + "'," +
                "" + serv.Prioridade + "," +
                "" + serv.Valor + "," +
                "'" + serv.DataFimEst + "'," +
                "'" + serv.DataFim + "'," +
                "" + serv.Sit + "," +
                "" + serv.AceiteUser + "," +
                "" + serv.AceiteEmp + "," +
                "" + serv.RepTempo + "," +
                "" + serv.RepQualidade + "," +
                "" + serv.RepAtendimento + "," +
                "'" + serv.ObsFinUser + "'," +
                "'" + serv.ObsFinEmp + "'" +
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
                "id_categoria = " + serv.Categoria.Id + "," +
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
                "obs_finais_empresa = " + serv.ObsFinEmp + "" +
                " WHERE id  = " + serv.Id + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void updateServicoValor(double valor, DateTime dataPrev, int idServ)
        {
            string sql = "UPDATE servico " +
                "SET valor = " + valor + ", " +
                "data_fim_estimada = '" + dataPrev.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                "WHERE id  = " + idServ + " ";
            string tst = dataPrev.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void updateFinalEmp(int sit, int idServ, int idCli, int repuCli, string obsFinais)
        {
            string sql = "UPDATE servico " +
                "SET situacao = " + sit + ", " +
                "aceite_empresa = 1, " +
                "obs_finais_empresa = '" + obsFinais + "' " +
                "WHERE id  = " + idServ + " ";

            atualizaRepuCli(idCli, repuCli);

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public void updateFinalCli(int sit, int idServ, int idUsu, int idEmp, int repuQ, int repuA, int repuT, string obsFinais)
        {
            string sql = "UPDATE servico " +
                "SET situacao = " + sit + ", " +
                "reputacao_qualidade = " + repuQ + ", " +
                "reputacao_atendimento = " + repuA + ", " +
                "reputacao_tempo = " + repuT + ", " +
                "data_fim = NOW(), " +
                "aceite_usuario = 1, " +
                "obs_finais_usuario = '" + obsFinais + "' " +
                "WHERE id  = " + idServ + " ";

            string sql2 = "UPDATE usuario " +
                "SET qtd_servicos = qtd_servicos + 1 " +
                "WHERE id  = " + idUsu + " ";

            

            atualizaRepuEmpresa(idEmp, repuQ, repuA, repuT);

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            new Conn().executar(sql2, conn);
            conn.Close();
        }

        private void atualizaRepuCli(int idU, int repuCli)
        {
            Usuario cliente = new UsuarioDAO().selectUser(idU);
            int qtdServicos = cliente.QtdServicos;
            int repuAtual = cliente.Reputacao;
            double repuCalculada = 0.0;

            repuCalculada = ((repuAtual * qtdServicos) + repuCli) / (qtdServicos+1);
            repuCalculada = Math.Round(repuCalculada,0);
            int repuCalculadaI = (int)repuCalculada;

            string sql = "UPDATE usuario " +
                "SET reputacao = " + repuCalculadaI + " " +
                "WHERE id  = " + idU + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        private void atualizaRepuEmpresa(int idEmp, int rQua, int rAte, int rTem)
        {
            Empresa emp = new EmpresaDAO().selectEmp(idEmp);

            int atualQ = emp.RepQualidade;
            int atualA = emp.RepAtendimento;
            int atualT = emp.RepTempo;

            int qtdServs = emp.QtdServ;
            if (qtdServs == 0) qtdServs = 1;

            double repuCalculadaQ = 0.0;
            repuCalculadaQ = ((atualQ * qtdServs) + rQua) / (qtdServs);
            repuCalculadaQ = Math.Round(repuCalculadaQ, 0);
            int repuCalculadaQI = (int)repuCalculadaQ;

            double repuCalculadaA = 0.0;
            repuCalculadaA = ((atualA * qtdServs) + rAte) / (qtdServs);
            repuCalculadaA = Math.Round(repuCalculadaA, 0);
            int repuCalculadaAI = (int)repuCalculadaA;

            double repuCalculadaT = 0.0;
            repuCalculadaT = ((atualT * qtdServs) + rTem) / (qtdServs);
            repuCalculadaT = Math.Round(repuCalculadaT, 0);
            int repuCalculadaTI = (int)repuCalculadaT;

            string sql = "UPDATE empresa " +
               "SET reputacao_qualidade = " + repuCalculadaQI + ", " +
               "reputacao_atendimento = " + repuCalculadaAI + ", " +
               "reputacao_tempo = " + repuCalculadaTI + ", " +
               "qtd_servicos = qtd_servicos + 1 " +
               "WHERE id  = " + idEmp + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();

        }

        public void updateSit(int sit, int idServ)
        {
            string sql = "UPDATE servico " +
                "SET situacao = " + sit + " " +
                "WHERE id  = " + idServ + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }


        public void updateSitExe(int sit, int idServ)
        {
            string sql = "UPDATE servico " +
                "SET situacao = " + sit + ", " +
                "data_inicio = '" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "' " +
                "WHERE id  = " + idServ + " ";

            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }




        

        public void deleteServico(int id)
        {
            string sql = "UPDATE servico SET situacao = -1 WHERE id = " + id;

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

        public int selectUltimoId()
        {
            string sql = "SELECT * FROM servico order by id desc";
            int serv = 0;
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            if (reader.Read() && reader.HasRows)
            {
                serv = reader.GetInt32(0);
            }
            conn.Close();
            return serv;
        }


        public List<Servico> selectAllServs()
        {
            string sql = "SELECT * FROM servico";
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
            string sql = "SELECT * FROM servico WHERE id_usuario = " + idUser + " ORDER BY id DESC";
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
        
        
     

        public List<Servico> selectAllServsEmpSolic(int idEmp)
        {
            string sql = "SELECT * FROM servico WHERE id_empresa = " + idEmp + " AND situacao in (0) ";
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

        public List<Servico> selectAllServsEmpExe(int idEmp)
        {
            string sql = "SELECT * FROM servico WHERE id_empresa = " + idEmp + " AND situacao in (1,2,3,-2) ";
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

        // teste
        public List<Servico> selectServsEmpExePendFechado(int idEmp)
        {
            string sql = "SELECT * FROM servico WHERE id_empresa = " + idEmp + " AND situacao in (1,2,3,4) ";
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


        public List<Servico> selectAllServsEmpFin(int idEmp)
        {
            string sql = "SELECT * FROM servico WHERE id_empresa = " + idEmp + " AND situacao = 4 ";
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
            string sql = "SELECT * FROM servico WHERE id_usuario = " + idRepEmp;
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
            try
            {
                serv.DataIni = DateTime.Parse(reader.GetMySqlDateTime(4).Value.ToString());
                serv.DataFimEst = DateTime.Parse(reader.GetMySqlDateTime(10).Value.ToString());
                serv.DataFim = DateTime.Parse(reader.GetMySqlDateTime(11).Value.ToString());
            }
            catch (Exception e)
            {
                serv.DataIni = new DateTime();
                serv.DataFimEst = new DateTime();
                serv.DataFim = new DateTime();
            }
            serv.Categoria = new CategoriaDAO().selectCat(reader.GetInt32(5));
            serv.IdEmpSer = reader.GetInt32(6);
            serv.DescUser = reader.GetString(7);
            serv.Prioridade = reader.GetInt32(8);
            serv.Valor = reader.GetDouble(9);
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
