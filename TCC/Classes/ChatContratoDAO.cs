using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class ChatContratoDAO
    {
        public void insertChatContrato(ChatContrato chatC)
        {
            string sql = "INSERT INTO chat_contrato(id,id_servico,id_usuario,id_user_empresa)" +
                "VALUES (NULL, " +
                " " + chatC.IdServ + "," +
                " " + chatC.IdUser + "," +
                " " + chatC.IdUserEmp + "" +
                ")";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }
        public ChatContrato selectChatC(ChatContrato chatC)
        {
            string sql = "SELECT * FROM chat_contrato WHERE id = " + chatC.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                chatC = preencherChatC(reader);
            }
            conn.Close();
            return chatC;
        }
        public List<ChatContrato> selectChatCIdUser(int id)
        {
            string sql = "SELECT * FROM chat_contrato WHERE id_usuario = " + id;
            List<ChatContrato> chatCs = new List<ChatContrato>();
            ChatContrato chatC = new ChatContrato();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                chatC = preencherChatC(reader);
                chatCs.Add(chatC);
            }
            conn.Close();
            return chatCs;
        }
        public List<ChatContrato> selectChatCIdUserEmp(int id)
        {
            string sql = "SELECT * FROM chat_contrato WHERE id_user_empresa = " + id;
            List<ChatContrato> chatCs = new List<ChatContrato>();
            ChatContrato chatC = new ChatContrato();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                chatC = preencherChatC(reader);
                chatCs.Add(chatC);
            }
            conn.Close();
            return chatCs;
        }

        public int selectUltimoId()
        {
            string sql = "SELECT * FROM chat_contrato order by id desc";
            int contrato = 0;
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            if (reader.Read() && reader.HasRows)
            {
                contrato = reader.GetInt32(0);
            }
            conn.Close();
            return contrato;
        }

        public ChatContrato selectChatCIdServ(int id)
        {
            string sql = "SELECT * FROM chat_contrato WHERE id_servico = " + id;
            ChatContrato chatC = new ChatContrato();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            reader.Read();
            chatC = preencherChatC(reader);
              
            conn.Close();
            return chatC;
        }
        private ChatContrato preencherChatC(MySqlDataReader reader)
        {
            ChatContrato chatC = new ChatContrato();
            chatC.Id = reader.GetInt32(0);
            chatC.IdServ = reader.GetInt32(1);
            chatC.IdUser = reader.GetInt32(2);
            chatC.IdUserEmp = reader.GetInt32(3);
            return chatC;
        }
    }
}