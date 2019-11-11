using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class cadastrarServico : System.Web.UI.Page
    {
        public EmpresaServico servico = new EmpresaServico();
        public EmpresaServicoDAO banco = new EmpresaServicoDAO();
        public CategoriaDAO categoriaDAO = new CategoriaDAO();
        public List<Categoria> categorias = new List<Categoria>();
        public EmpresaDAO empresaDAO = new EmpresaDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sIdEmp"] == null)
            {
                Response.Redirect("loginEmpresa.aspx");
            }
            if (Request["id"] != null)
            {
                int id = Int32.Parse(Request["id"]);
                servico = banco.selectEmpServ(id);
                idServico.Value = id.ToString();
                Tags.Text = servico.Tags;
                categoria.SelectedValue = servico.IdCat.ToString();
                precoMedio.Text = servico.ValorAprox.ToString();
                descricao.Text = servico.Desc;
                tempo.Text = servico.TempoAprox;
            }
            else
            {
                idServico.Value = "0";

            }
            categorias = categoriaDAO.selectAllCategorias();
            foreach (var item in categorias)
            {
                categoria.Items.Add(new ListItem(){ Value = item.Id.ToString(), Text=item.Descricao });
            }
        }
        public void SubmitForm(object sender, EventArgs e)
        {
            string tempovalue = tempo.Text;
            string tags = Tags.Text;
            int categoriaValue = Int32.Parse(categoria.Text);
            string descricaoValue = descricao.Text;
            double precoValue = Double.Parse(precoMedio.Text);
            int idValue = Int32.Parse(idServico.Value);
            servico.Categoria = categoriaDAO.selectCat(categoriaValue);
            servico.TempoAprox = tempovalue;
            servico.Desc = descricaoValue;
            servico.ValorAprox = precoValue;
            servico.Tags = tags;
            int idEmpresa = (int)Session["sIdEmp"];
            servico.Empresa = empresaDAO.selectEmp(idEmpresa);
            if (idValue != 0)
            {
                servico.Id = idValue;
                banco.updateEmpServ(servico);
            }
            else
            {
                banco.insertEmpServ(servico);
            }
            Response.Redirect("gerenciarServicos.aspx");

        }
        public void Editar(object sender, EventArgs e)
        {
            int i = 1;
        }
    }
}