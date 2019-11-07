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
           
            //Preencher categorias            
            if (categorias.Items.Count == 0)
            {
                listaCats = new CategoriaDAO().selectAllCategorias();
                categorias.Items.Insert(0, new ListItem("Todos", "0"));
                foreach (Categoria cat in listaCats)
                {
                    categorias.Items.Insert(cat.Ordem, new ListItem(cat.Descricao, cat.Id.ToString()));
                }
            }
             


            //IF FILTRO VAZIO MOSTRAR TODOS OS PONTOS
            catPost = Int32.Parse(categorias.SelectedValue); 
            pesqPost = pesq.Value;
            if (pesqPost.Length == 0 && catPost == 0)
            {

                List<Empresa> listaEmpresas = new List<Empresa>();
                listaEmpresas = new EmpresaDAO().selectAllEmps();
                if (listaEmpresas != null) { 
                    foreach (Empresa empresa in listaEmpresas)
                    {
                        string servicosEmp = pegarSevicos(empresa.Id, catPost);
                        int repMedia = (empresa.RepAtendimento + empresa.RepQualidade + empresa.RepTempo) / 3;
                        listaPontos.Add(new MapPoint(empresa.Lat, empresa.Lon, empresa.RazaoSocial, empresa.DescEmpresa + "<br>" + servicosEmp, repMedia, 1, 1));
                    }
                    
                }
            }




        }

        private string pegarSevicos(int id, int catEscolhida)
        {
            int verificaCat = 0;
            string results = "";
            List<EmpresaServico> servs = new List<EmpresaServico>();
            servs = new EmpresaServicoDAO().selectEmpServPorIDEmp(id);

            foreach (EmpresaServico serv in servs)
            {
                results = results + "<br>" + serv.Desc;
                if(serv.IdCat == catEscolhida || catEscolhida == 0)
                {
                    verificaCat = 1;
                }
            }

            if(verificaCat != 1)
            {
                results = "foraDaCategoria";
            }
           

            return results;
        }

      

        public void filtrar(object sender, EventArgs e)
        {
            pesqPost = pesq.Value;
            catPost = Int32.Parse(categorias.SelectedValue);
            List<Empresa> listaEmpresas = new List<Empresa>();
            listaEmpresas = new EmpresaDAO().selectAllEmpsFiltradas(catPost, pesqPost);

            

            if (listaEmpresas != null)
            {
                foreach (Empresa empresa in listaEmpresas)
                {
                    
                    string servicosEmp = pegarSevicos(empresa.Id, catPost);
                    if (servicosEmp != "foraDaCategoria")
                    {
                        int repMedia = (empresa.RepAtendimento + empresa.RepQualidade + empresa.RepTempo) / 3;
                        listaPontos.Add(new MapPoint(empresa.Lat, empresa.Lon, empresa.RazaoSocial, empresa.DescEmpresa + "<br>" + servicosEmp, repMedia, 1, 1));
                    }
                   
                }
            }

        }

    }
}