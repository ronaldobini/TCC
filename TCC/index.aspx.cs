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
            //UsuarioDAO dao = new UsuarioDAO();
            //user.Id = 2;
            //user = dao.selectUser(user.Id);
            //users = dao.selectAllUsers();
            
        }


        public void espiarClick(object sender, EventArgs e)
        {

            string cepForm = cep.Value+" - Curitiba";

            if(cepForm.Length < 2)
            {
                cepForm = "80010020";
            }

            string lt = new ApiCoordenadas().pegarLat(cepForm).ToString();
            string lg = new ApiCoordenadas().pegarLng(cepForm).ToString();

            string latS = lt.Replace(",", ".");
            string lonS = lg.Replace(",", ".");


            Session["latCentro"] = latS;
            Session["lngCentro"] = lonS;

            Response.Redirect("mapao.aspx");

        }

        public void loginCliente(object sender, EventArgs e)
        {
            Response.Redirect("loginCliente.aspx");
        }
        public void cadastroCliete(object sender, EventArgs e)
        {
            Response.Redirect("cadastrarCliente.aspx");
        }

        }
}