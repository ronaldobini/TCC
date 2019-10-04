using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class prestador : System.Web.UI.Page
    {

        private string loginPost;
        private string senhaPost;
        private string erro;
        private int contaErros = 0;
        public Usuario user = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Logar_Click(object sender, EventArgs e) {

            senhaPost = (senha.Value);
            loginPost = (login.Value);

            //ANTI INJECTION
            int lenS = senhaPost.Length; if (lenS >= 10) lenS = 10;
            int lenL = loginPost.Length; if (lenL >= 12) lenS = 12;

            senhaPost = senhaPost.Substring(0, lenS);
            loginPost = loginPost.Substring(0, lenL);

            senhaPost = senhaPost.Replace("'", "0");
            loginPost = loginPost.Replace("'", "0");
            senhaPost = senhaPost.Replace('"', '0');
            loginPost = loginPost.Replace('"', '0');
            senhaPost = senhaPost.Replace("/", "0");
            loginPost = loginPost.Replace("/", "0");
            senhaPost = senhaPost.Replace("=", "0");
            loginPost = loginPost.Replace("=", "0");
            loginPost = loginPost.Replace(" OR ", "0");

            MySqlConnection conn = new Conn().conectar();
            string sql = "SELECT * FROM usuario WHERE login = '" + loginPost +"' ";
            MySqlDataReader reader = new Conn().consultar(sql,conn);


            if (reader.Read() && reader.HasRows)
            {
                user = new UsuarioDAO().selectUser(reader.GetInt32(0));
                conn.Close();
                if (user.Block != 0)
                {
                    String senha = reader.GetString(2);
                    if (senha.Equals(senhaPost))
                    {

                    }
                    else
                    {
                        ++contaErros;
                        user = null;
                        if (contaErros >= 5)
                        {

                        }
                    }
                }
                else
                {
                    erro = "Usuario Bloqueado";
                }
            }
        }
    }
}