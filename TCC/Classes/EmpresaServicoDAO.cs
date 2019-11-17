using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class EmpresaServicoDAO
    {
        public void insertEmpServ(EmpresaServico empServ)
        {
            string sql = "INSERT INTO empresa_servicos(id, id_empresa, id_categoria, descricao, valor_aprox, tempo_aprox,tags,fl_ativo) " +
                "VALUES (NULL," + empServ.Empresa.Id+ "," + empServ.Categoria.Id+ ", \" "+ empServ.Desc + "\"," +  empServ.ValorAprox + ",\""+empServ.TempoAprox + "\",\""+empServ.Tags+"\",0) ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void updateEmpServ(EmpresaServico empServ)
        {
            string sql = "UPDATE empresa_servicos " +
                "SET id_empresa = " + empServ.Empresa.Id + ",id_categoria = " + empServ.Categoria.Id + ",descricao =\"" + empServ.Desc + "\",valor_aprox = " + empServ.ValorAprox + ",tempo_aprox = \"" + empServ.TempoAprox + "\" ,tags=\""+empServ.Tags+"\" fl_ativo=0 WHERE id = " + empServ.Id ;
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public bool deleteEmpServ(EmpresaServico empServ)
        {
            string sql = "Update  empresa_servicos set fl_ativo=1 WHERE id = " + empServ.Id;
            MySqlConnection conn = new Conn().conectar();
            bool sucesso =new Conn().executar(sql, conn);
            conn.Close();
            return sucesso;

        }
        public bool ReabrirServico(int id)
        {
            string sql = "Update  empresa_servicos set fl_ativo=0 WHERE id = " +id;
            MySqlConnection conn = new Conn().conectar();
            bool sucesso = new Conn().executar(sql, conn);
            conn.Close();
            return sucesso;

        }
        public EmpresaServico selectEmpServ(int idSerivco)
        {
            string sql = "SELECT * FROM empresa_servicos WHERE id = " + idSerivco;
            EmpresaServico servico = new EmpresaServico();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                servico = preencherEmpServ(reader);
            }
            conn.Close();
            return servico;
        }
        public string selectDescPorId(int id)
        {
            string sql = "SELECT * FROM empresa_servicos WHERE id = " + id;
            string desc = "-";
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                desc = reader.GetString(3);
            }
            conn.Close();
            return desc;
        }
        public List<EmpresaServico> selectEmpServPorIDEmp(int id)
        {
            string sql = "SELECT * FROM empresa_servicos where id_empresa = "+id;
            List<EmpresaServico> empServs = new List<EmpresaServico>();
            EmpresaServico empServ = new EmpresaServico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                empServ = preencherEmpServ(reader);
                empServs.Add(empServ);
            }
            conn.Close();
            return empServs;
        }
        public EmpresaServico selectEmpServPorIDCat(int id)
        {
            string sql = "SELECT * FROM empresa_servicos WHERE id_categoria = " + id;
            EmpresaServico empServ = new EmpresaServico();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                empServ = preencherEmpServ(reader);
            }
            conn.Close();
            return empServ;
        }
        public EmpresaServico selectEmpServPorDesc(string desc)
        {
            string sql = "SELECT * FROM empresa_servicos WHERE descricao = " + desc;
            EmpresaServico empServ = new EmpresaServico();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                empServ = preencherEmpServ(reader);
            }
            conn.Close();
            return empServ;
        }
        public List<EmpresaServico> selectAllServicoPorEmpresa(int idEmpresa)
        {
            string sql = "SELECT * FROM empresa_servicos WHERE id_empresa = "+idEmpresa;
            List<EmpresaServico> empServs = new List<EmpresaServico>();
            EmpresaServico empServ = new EmpresaServico();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                empServ = preencherEmpServ(reader);
                empServs.Add(empServ);
            }
            conn.Close();
            return empServs;
        }
        private EmpresaServico preencherEmpServ(MySqlDataReader reader)
        {
            EmpresaServico empServ = new EmpresaServico();
            empServ.Id = reader.GetInt32(0);
            empServ.IdEmp = reader.GetInt32(1);
            empServ.IdCat = reader.GetInt32(2);
            empServ.Desc = reader.GetString(3);
            empServ.ValorAprox = reader.GetDouble(4);
            empServ.TempoAprox = reader.GetString(5);
            empServ.Tags = reader.GetString(6);
            empServ.FlAtivo = reader.GetInt16(7);
            return empServ;
        }
    }
}