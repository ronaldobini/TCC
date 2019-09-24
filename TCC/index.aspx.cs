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
    public partial class Index : System.Web.UI.Page
    {
        public string results = "-";
        public Usuario user = new Usuario();
        public List<Usuario> users = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioDAO dao = new UsuarioDAO();
            user.Id = 2;
            user = dao.selectUser(user);
            users = dao.selectAllUsers();
        }
    }
}