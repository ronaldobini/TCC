using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class ChatMensagemDAO
    {
        public void insertChatM(ChatMensagem chatM)
        {
            string sql = "INSERT INTO chat_mensagens(id, id_chat_contrato, id_usuario,tempo,mensagem,situacao) " +
                "VALUES(NULL," +
                "" + chatM.IdChatC + "," +
                "" + chatM.IdUser + "," +
                " '" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "', " + // Data Agora
                "'" + chatM.Mensagem + "'," +
                "" + chatM.Situacao + "" +
                ")";
            MySqlConnection conn = new Conn().conectar();
            new Conn().executar(sql, conn);
            conn.Close();
        }

        public ChatMensagem selectChatM(ChatMensagem chatM)
        {
            string sql = "SELECT * FROM chat_mensagens WHERE id = " + chatM.Id;

            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                chatM = preencherChatM(reader);
            }
            conn.Close();
            return chatM;
        }
        public List<ChatMensagem> selectChatMIdUser(int id)
        {
            string sql = "SELECT * FROM chat_mensagens WHERE id_usuario = " + id;
            ChatMensagem chatM = new ChatMensagem();
            List<ChatMensagem> chatMs = new List<ChatMensagem>();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                chatM = preencherChatM(reader);
                chatMs.Add(chatM);
            }
            conn.Close();
            return chatMs;
        }
        public List<ChatMensagem> selectChatMIdChatC(int id)
        {
            string sql = "SELECT * FROM chat_mensagens WHERE id_chat_contrato = " + id;
            ChatMensagem chatM = new ChatMensagem();
            List<ChatMensagem> chatMs = new List<ChatMensagem>();
            MySqlConnection conn = new Conn().conectar();
            MySqlDataReader reader = new Conn().consultar(sql, conn);
            while (reader.Read() && reader.HasRows)
            {
                chatM = preencherChatM(reader);
                chatMs.Add(chatM);
            }
            conn.Close();
            return chatMs;
        }
        private ChatMensagem preencherChatM(MySqlDataReader reader)
        {
            ChatMensagem chatM = new ChatMensagem();
            chatM.Id = reader.GetInt32(0);
            chatM.IdChatC = reader.GetInt32(1);
            chatM.IdUser = reader.GetInt32(2);
            chatM.Tempo = reader.GetDateTime(3);
            chatM.Mensagem = reader.GetString(4);
            chatM.Situacao = reader.GetInt32(5);
            return chatM;
        }
    }
}