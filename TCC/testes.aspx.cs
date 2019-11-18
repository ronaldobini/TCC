using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;
using MySql.Data.MySqlClient;
using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json.Linq;
using TCC.Classes;

namespace TCC
{
    public partial class testes : System.Web.UI.Page
    {

        //https://viacep.com.br/ws/81580510/json/


        public string mostrar = "";



        protected void Page_Load(object sender, EventArgs e)
        {

            double a = new ApiCoordenadas().pegarLng("RUA FELICIO ZIBARTH");

            mostrar = a.ToString();
        }











    }
}