﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class MapPoint
    {


        private string mapPoint;


        //-25.436958
        //-49.19756

        public MapPoint(double lat, double lon, string titulo, string servicos, int reputacaoMedia, int tipo, int idEmpresa)
        {
            string tipoS = "-";
            if (tipo == 1)
            {
                tipoS = "local";
            }
            else if (tipo == 2)
            {
                tipoS = "domicilio";
            }

            
                

            string notaBarra = "<center><div class=\"progress\" style=\"width:85px; height: 7px;\">" +
                                  "<div class=\"progress-bar progress-bar-striped progress-bar-animated role=\"progressbar\" style=\"width: " + reputacaoMedia + "%\"; aria-valuenow=\"" + reputacaoMedia + "\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>" +
                                "</div>";

            if (reputacaoMedia < 2)
            {
                notaBarra = "Sem reputação";
            }



            //mapPoint = "{ position: new google.maps.LatLng("+lat+", "+lon+"),type: '"+tipoS+"',infos: '<b>"+titulo+" </b><br>"+servicos+ "<br> Nota: " + reputacaoMedia + " < br >' }";

            string latS = lat.ToString();
            string lonS = lon.ToString();

            latS = latS.Replace(",",".");
            lonS = lonS.Replace(",", ".");

            if (reputacaoMedia < 2)
            {
                mapPoint = "{ position: new google.maps.LatLng(" + latS + ", " + lonS + "),type: '" + tipoS + "'," +
                "infos: '<b>" + titulo + " </b><br>" + servicos + " <br><br> " +
                "Sem reputação definida"+
                "<br><a href=empresaDetalhes.aspx?idEmpDet=" + idEmpresa + ">Detalhes </a>' }";
            }
            else
            {
                mapPoint = "{ position: new google.maps.LatLng(" + latS + ", " + lonS + "),type: '" + tipoS + "'," +
                "infos: '<b>" + titulo + " </b><br>" + servicos + " <br><br> " +
                "Reputacao: " + reputacaoMedia + "<br>" + notaBarra +
                "<br><a href=empresaDetalhes.aspx?idEmpDet=" + idEmpresa + ">Detalhes </a>' }";
            }

           

            
        }


        public string MapPointo()
        {
            return mapPoint;
        }




    }
}