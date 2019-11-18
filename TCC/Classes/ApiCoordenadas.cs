using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace TCC.Classes
{
    public class ApiCoordenadas
    {

        public string key;
        public string url = "";

        public double pegatLat(string busca)
        {
            key = "AIzaSyCSbnmsy0j1KVVLOG8FxGELMeha_pqnvYo";
            url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + busca + "&key=" + key;


            WebClient wc = new WebClient();
            var json = wc.DownloadString(url);

            var objeto = JObject.Parse(json); // parse as array  

            JArray vetor = (JArray)objeto["results"];


            double lat = double.Parse(vetor[0]["geometry"]["location"]["lat"].ToString());
            double lng = double.Parse(vetor[0]["geometry"]["location"]["lng"].ToString());

            string endBonito = vetor[0]["formatted_address"].ToString();

            return lat;
        }


        public double pegarLng(string busca)
        {
            key = "AIzaSyCSbnmsy0j1KVVLOG8FxGELMeha_pqnvYo";
            url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + busca + "&key=" + key;


            WebClient wc = new WebClient();
            var json = wc.DownloadString(url);

            var objeto = JObject.Parse(json); // parse as array  

            JArray vetor = (JArray)objeto["results"];


            double lat = double.Parse(vetor[0]["geometry"]["location"]["lat"].ToString());
            double lng = double.Parse(vetor[0]["geometry"]["location"]["lng"].ToString());

            string endBonito = vetor[0]["formatted_address"].ToString();

            return lng;

        }
    }
}