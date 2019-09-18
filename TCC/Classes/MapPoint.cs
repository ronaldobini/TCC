using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCC.Classes
{
    public class MapPoint
    {

        private string ponto;


        //-25.436958
        //-49.19756

        public MapPoint(double lat, double lon, string titulo, string servicos, double reputacaoMedia, int tipo)
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
            ponto = "{ position: new google.maps.LatLng(" + lat + ", " + lon + "),type: '" + tipoS + "',name: '<b>" + titulo + " </b><br>" + servicos + "' }";

        }

        public string Ponto { get => ponto; set => ponto = value; }

        //public string getPonto()
        //{
        //    return ponto;
        //}

    }
}