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
        public int mostrar = 0;
        public List<MapPoint> listaPontos = new List<MapPoint> { };
        public string catPost = "";
        public string pesqPost = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //mostrar = (int)Session["iddd"];
            pesqPost = pesq.Value;
            if (pesqPost.Length == 0)
            {
                pesqPost = "";

                List<Empresa> listaEmpresas = new List<Empresa>();
                listaEmpresas = new EmpresaDAO().selectAllEmpsFiltradas(catPost, pesqPost);
                foreach (Empresa empresa in listaEmpresas)
                {
                    //mostrar = empresa.RazaoSocial;
                    int repMedia = (empresa.RepAtendimento + empresa.RepQualidade + empresa.RepTempo) / 3;
                    listaPontos.Add(new MapPoint(empresa.Lat, empresa.Lon, empresa.RazaoSocial, empresa.DescEmpresa, repMedia, 1, 1));
                }
                listaPontos.Add(new MapPoint("-25.45", "-49.27", "Gantzel software", "Desenvolver soft<br>Redes<br>Suporte remoto<br>Conserto de PC", 69, 2, 2));
            }

        }


        public void filtrar(object sender, EventArgs e)
        {
            pesqPost = pesq.Value;
            List<Empresa> listaEmpresas = new List<Empresa>();
            listaEmpresas = new EmpresaDAO().selectAllEmpsFiltradas(catPost, pesqPost);


            if (listaEmpresas != null)
            {
                foreach (Empresa empresa in listaEmpresas)
                {
                    //mostrar = empresa.RazaoSocial;

                    int repMedia = (empresa.RepAtendimento + empresa.RepQualidade + empresa.RepTempo) / 3;

                    listaPontos.Add(new MapPoint(empresa.Lat, empresa.Lon, empresa.RazaoSocial, empresa.DescEmpresa, repMedia, 1, 1));
                }
            }

        }

    }
}