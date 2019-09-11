using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace tcc3
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
               


            }
            catch (Exception ee)
            {
                erro = "erro : " + ee;
            }

            return erro;

        }

    }
}