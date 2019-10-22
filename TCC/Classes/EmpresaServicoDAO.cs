﻿using MySql.Data.MySqlClient;
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
            string sql = "INSERT INTO empresa_servicos(id, id_empresa, id_categoria, descricao, valor_aprox, tempo_aprox) " +
                "VALUES (NULL," +
                "" + empServ.IdEmp + "," +
                "" + empServ.IdCat + "," +
                "" + empServ.Desc + "," +
                "" + empServ.ValorAprox + "," +
                "" + empServ.TempoAprox + "" +
                ") ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void updateEmpServ(EmpresaServico empServ)
        {
            string sql = "UPDATE empresa_servicos " +
                "SET id_empresa = " + empServ.IdEmp + "," +
                "id_categoria = " + empServ.IdCat + "," +
                "descricao = " + empServ.Desc + "," +
                "valor_aprox = " + empServ.ValorAprox + "," +
                "tempo_aprox = " + empServ.TempoAprox + "" +
                " WHERE id = " + empServ.Id + " ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void deleteEmpServ(EmpresaServico empServ)
        {
            string sql = "DELETE FROM empresa_servicos WHERE id = " + empServ.Id;
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public EmpresaServico selectEmpServ(EmpresaServico empServ)
        {
            string sql = "SELECT * FROM empresa_servicos WHERE id = " + empServ.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                empServ = preencherEmpServ(reader);
            }
            conn.Close();
            return empServ;
        }
        public EmpresaServico selectEmpServPorIDEmp(int id)
        {
            string sql = "SELECT * FROM empresa_servicos WHERE id_empresa = " + id;
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
        public List<EmpresaServico> selectAllEmpresaSaldo()
        {
            string sql = "SELECT * FROM empresa_servicos";
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
            return empServ;
        }
    }
}