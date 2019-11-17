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

namespace TCC
{
    public partial class testes : System.Web.UI.Page
    {

        //https://viacep.com.br/ws/81580510/json/



        public List<Empresa> lista = new List<Empresa>();
        public string mostrar = "ssss";

        public string url = "";

        public string key = "";
        public string endereco = "";

        protected void Page_Load(object sender, EventArgs e)
        {
           

        }



        public void clicou(object sender, EventArgs e)
        {

            endereco = txEndereco.Value;
            key = "AIzaSyCSbnmsy0j1KVVLOG8FxGELMeha_pqnvYo";
            url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + endereco + "&key=" + key;


            WebClient wc = new WebClient();
            var json = wc.DownloadString(url);

            var objeto = JObject.Parse(json); // parse as array  

            JArray vetor = (JArray)objeto["results"];


            double lat = double.Parse(vetor[0]["geometry"]["location"]["lat"].ToString());
            double lng = double.Parse(vetor[0]["geometry"]["location"]["lng"].ToString());

            string endBonito = vetor[0]["formatted_address"].ToString();

            mostrar = endBonito + " - Coo: " + lat + " " + lng;


        }








    }
}