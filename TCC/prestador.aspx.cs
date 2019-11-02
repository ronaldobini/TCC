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
        public void cadastrar(object sender, EventArgs e)
        {
            //string nomePost = nomeC.Value;
            //string emailPost = emailC.Value;
            //string cpfPost = cpfC.Value;
            //string endPost = endC.Value;
            //int numPost = Int32.Parse(numC.Value);
            //string loginPost = loginC.Value;
            //string senhaPost = senhaC.Value;
            //Usuario user = new Usuario(0, loginPost, senhaPost, nomePost, emailPost, cpfPost, "tel1", "tel2",
            //    endPost, numPost, "complemento", "cep", "cidade", "0.0", DateTime.Now, DateTime.Now, 0, 0, 0);

            //new UsuarioDAO().insertUser(user);
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
                if (user.Block != 1)
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