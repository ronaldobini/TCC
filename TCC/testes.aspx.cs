using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;
using MySql.Data.MySqlClient;
using System.Collections.Specialized;

namespace TCC
{
    public partial class testes : System.Web.UI.Page
    {

        public List<Empresa> lista = new List<Empresa>();
        public string var = "ssss";

        public string url = "-";

        protected void Page_Load(object sender, EventArgs e)
        {

             

        }



        public void clicou(Object sender, CommandEventArgs e)
        {

            url = e.CommandArgument.ToString();
            int i = 9;

        }







        }
}