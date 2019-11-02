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
        public List<Categoria> listaCats = new List<Categoria>();
        public int catPost = 0;
        public string pesqPost = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            listaCats = new CategoriaDAO().selectAllCategorias();
            //mostrar = (int)Session["iddd"];
            catPost = Int32.Parse(categoria.Value);
            pesqPost = pesq.Value;
            if (pesqPost.Length == 0 && catPost == 0)
            {
                pesqPost = "";
                catPost = 0;

                List<Empresa> listaEmpresas = new List<Empresa>();
                listaEmpresas = new EmpresaDAO().selectAllEmpsFiltradas(catPost, pesqPost);
                if (listaEmpresas != null) { 
                    foreach (Empresa empresa in listaEmpresas)
                    {
                        string servicosEmp = pegarSevicos(empresa.Id);
                        int repMedia = (empresa.RepAtendimento + empresa.RepQualidade + empresa.RepTempo) / 3;
                        listaPontos.Add(new MapPoint(empresa.Lat, empresa.Lon, empresa.RazaoSocial, empresa.DescEmpresa + "<br>" + servicosEmp, repMedia, 1, 1));
                    }
                    
                }
            }

        }

        private string pegarSevicos(int id)
        {
            string results = "";
            List<EmpresaServico> servs = new List<EmpresaServico>();
            servs = new EmpresaServicoDAO().selectEmpServPorIDEmp(id);

            foreach (EmpresaServico serv in servs)
            {
                results = results + "<br>" + serv.Desc;
            }
            return results;
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