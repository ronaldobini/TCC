using System;
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

        public MapPoint(string lat, string lon, string titulo, string servicos, int reputacaoMedia, int tipo, int idEmpresa)
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

            string notaBarra = "<div class=\"progress\" style=\"width:85px; height: 7px;\">" +
                                  "<div class=\"progress-bar progress-bar-striped progress-bar-animated role=\"progressbar\" style=\"width: " + reputacaoMedia + "%\"; aria-valuenow=\"" + reputacaoMedia + "\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>" +
                                "</div>";



            //mapPoint = "{ position: new google.maps.LatLng("+lat+", "+lon+"),type: '"+tipoS+"',infos: '<b>"+titulo+" </b><br>"+servicos+ "<br> Nota: " + reputacaoMedia + " < br >' }";

            mapPoint = "{ position: new google.maps.LatLng(" + lat + ", " + lon + "),type: '" + tipoS + "'," +
                "infos: '<b>" + titulo + " </b><br>" + servicos + " <br><br> " +
                "Reputacao: " + reputacaoMedia + "<br>" + notaBarra +
                "<br><a href=empresaDetalhes.aspx?idEmpDet=" + idEmpresa + ">Detalhes </a>' }";


        }


        public string MapPointo()
        {
            return mapPoint;
        }




    }
}