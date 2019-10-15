﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class Conn
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection conectar()
        {

            server = "tccsilence.mysql.dbaas.com.br";
            database = "tccsilence";
            uid = "tccsilence";
            password = "UFPRtcc2019";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;

        }

        public string conectarErros()
        {
            string erro = "sem erros";
            server = "tccsilence.mysql.dbaas.com.br";
            database = "tccsilence";
            uid = "tccsilence";
            password = "UFPRtcc2019";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                connection.Close();

            }
            catch (Exception ee)
            {
                erro = "erro : " + ee;
            }

            return erro;

        }

        public string executar(string sql, MySqlConnection conn)
        {
            string result = "-";
            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                result = "OK comando sql executado com sussesso";
            }
            catch (Exception e)
            {
                result = "ERRO: " + e;
            }
            return result;
        }
        public MySqlDataReader consultar(string sql,MySqlConnection conn)
        {
            string result = "-";
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand command = new MySqlCommand(sql, conn);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                result = "ERRO: " + e;
            }
            return reader;

        }
        public void fechaConn(MySqlConnection conn)
        {
            try
            {
                conn.Close();

            }
            catch (Exception e)
            {
            }
        }
    }
}