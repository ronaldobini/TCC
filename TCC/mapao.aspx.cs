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
        public string mostrar = " ";
        public List<MapPoint> listaPontos = new List<MapPoint> { };
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Empresa> listaEmpresas = new List<Empresa>();

            listaEmpresas = new EmpresaDAO().selectAllEmps();
            

            foreach(Empresa empresa in listaEmpresas)
            {
                //mostrar = empresa.RazaoSocial;

                int repMedia = (empresa.RepAtendimento + empresa.RepQualidade + empresa.RepTempo)/3;

                listaPontos.Add(new MapPoint(empresa.Lat, empresa.Lon, empresa.RazaoSocial, empresa.DescEmpresa, repMedia, 1, 1));


            }


            listaPontos.Add(new MapPoint("-25.45", "-49.27", "Gantzel software", "Desenvolver soft<br>Redes<br>Suporte remoto<br>Conserto de PC", 69, 1, 2));
            
        }
    }
}