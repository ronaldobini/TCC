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

        //-25.436958
        //-49.19756

        public double pegarLat(string busca)
        {
            key = "AIzaSyCSbnmsy0j1KVVLOG8FxGELMeha_pqnvYo";
            url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + busca + "&key=" + key;


            WebClient wc = new WebClient();
            var json = wc.DownloadString(url);

            var objeto = JObject.Parse(json); // parse as array  

            JArray vetor = (JArray)objeto["results"];
            double lat = -25.436958;

            try
            {
                lat = double.Parse(vetor[0]["geometry"]["location"]["lat"].ToString());
            }
            catch (Exception e)
            {
                lat = -25.436958;
            }

            //string endBonito = vetor[0]["formatted_address"].ToString();

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

            double lng = -49.19756;
            try
            {
                lng = double.Parse(vetor[0]["geometry"]["location"]["lng"].ToString());
            }
            catch (Exception e)
            {

            }
            

            string endBonito = vetor[0]["formatted_address"].ToString();

            return lng;

        }
    }
}