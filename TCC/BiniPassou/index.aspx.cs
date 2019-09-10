using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace teste3
{
    public partial class index : System.Web.UI.Page
    {



        public List<MapPoints> listaPontos = new List<MapPoints> { };
        protected void Page_Load(object sender, EventArgs e)
        {
            listaPontos.Add(new MapPoints(-25.436958, -49.19756, "bini software", "desenvolver soft<br>analisar soft", 18.8, 1));
        }
    }
}