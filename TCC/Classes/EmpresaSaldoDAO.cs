using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class EmpresaSaldoDAO
    {
        public void insertEmpSaldo(EmpresaSaldo empSal)
        {
            string sql = "INSERT INTO empresa_saldo(id, id_empresa, saldo_liberado,saldo_pendente, saldo_total_historico) " +
                "VALUES (NULL," +
                "" + empSal.IdEmp + "," +
                "" + empSal.SaldoLiberado + "," +
                "" + empSal.SaldoPendente + "," +
                "" + empSal.SaldoTotalHistorico + "" +
                ") ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void updateEmpSaldo(EmpresaSaldo empSal)
        {
            string sql = "UPDATE empresa_saldo " +
                "SET id_empresa = " + empSal.IdEmp + "," +
                "saldo_liberado = " + empSal.SaldoLiberado + "," +
                "saldo_pendente = " + empSal.SaldoPendente + "," +
                "saldo_total_historico = " + empSal.SaldoTotalHistorico + "" +
                " WHERE id = " + empSal.Id + " ";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public void deleteEmpSaldo(EmpresaSaldo empSal)
        {
            string sql = "DELETE FROM empresa_saldo WHERE id = " + empSal.Id;
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        
        public List<EmpresaSaldo> selectEmpresaSaldosPorIDEmp(int id)
        {
            string sql = "SELECT * FROM empresa_saldo WHERE id_empresa = " + id;
            List<EmpresaSaldo> empSals = new List<EmpresaSaldo>();
            EmpresaSaldo empSal = new EmpresaSaldo();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                empSal = preencherEmpSaldo(reader);
                empSals.Add(empSal);
            }
            conn.Close();
            return empSals;
        }


        public EmpresaSaldo selectSaldoEmpresa(int idEmp)
        {
            string sql = "SELECT * FROM empresa_saldo WHERE id_empresa = " + idEmp;
            EmpresaSaldo empSal = new EmpresaSaldo();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            if (reader.Read() && reader.HasRows)
            {
                empSal = preencherEmpSaldo(reader);
            }
            conn.Close();
            return empSal;
        }

        public List<EmpresaSaldo> selectAllEmpresaSaldo()
        {
            string sql = "SELECT * FROM empresa_saldo";
            List<EmpresaSaldo> empSals = new List<EmpresaSaldo>();
            EmpresaSaldo empSal = new EmpresaSaldo();
            MySqlDataReader reader = null;
            MySqlConnection conn = new Conn().conectar();
            reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                empSal = preencherEmpSaldo(reader);
                empSals.Add(empSal);
            }
            conn.Close();
            return empSals;
        }
        private EmpresaSaldo preencherEmpSaldo(MySqlDataReader reader)
        {
            EmpresaSaldo empSal = new EmpresaSaldo();
            empSal.Id = reader.GetInt32(0);
            empSal.IdEmp = reader.GetInt32(1);
            empSal.SaldoLiberado = reader.GetDouble(2);
            empSal.SaldoPendente = reader.GetDouble(3);
            empSal.SaldoTotalHistorico = reader.GetDouble(4);
            return empSal;
        }
    }
}