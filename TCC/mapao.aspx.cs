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
            listaPontos.Add(new MapPoint(-25.436958, -49.19756, "bini software", "desenvolver soft<br>analisar soft", 18.8, 1));
        }
    }
}