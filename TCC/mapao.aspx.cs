using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class mapao : System.Web.UI.Page
    {

        public List<MapPoint> listaPontos = new List<MapPoint> { };
        protected void Page_Load(object sender, EventArgs e)
        {
            listaPontos.Add(new MapPoint(-49.19756, -25.436958,  "Bini software", "-Desenvolver soft (4.000,00)<br>-Analisar soft (2.500,00)<br>-Seguranca de soft (1.500,00)<br>-Integracao de soft (3.500,00)<br>-App Mobile (3.200,00)", 85, 1, 1));
            listaPontos.Add(new MapPoint(-25.446958, -49.19756, "Gantzel software", "Desenvolver soft<br>Redes<br>Suporte remoto<br>Conserto de PC", 69, 1, 2));
        }
    }
}