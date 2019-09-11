using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace teste3
{
    public class MapPoints
    {

        
        private string mapPoint;


        //-25.436958
        //-49.19756

        public MapPoints(double lat, double lon, string titulo, string servicos, double reputacaoMedia, int tipo)
        {
            string tipoS = "-";
            if (tipo == 1)
            {
                tipoS = "local";
            }else if (tipo == 2)
            {
                tipoS = "domicilio";
            }
            mapPoint = "{ position: new google.maps.LatLng("+lat+", "+lon+"),type: '"+tipoS+"',name: '<b>"+titulo+" </b><br>"+servicos+"' }";

        }


        public string MapPoint()
        {
            return mapPoint;
        }
        



    }
}