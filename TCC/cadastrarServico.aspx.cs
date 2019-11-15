﻿using System;
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
        public EmpresaServico Novoservico = new EmpresaServico();
        public EmpresaServicoDAO banco = new EmpresaServicoDAO();
        public CategoriaDAO categoriaDAO = new CategoriaDAO();
        public List<Categoria> categorias = new List<Categoria>();
        public EmpresaDAO empresaDAO = new EmpresaDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["sIdEmp"] == null)
            //{
            //    Response.Redirect("loginEmpresa.aspx");
            //}
            if (!IsPostBack)
            {
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
                    servico.Id = 0;

                }
                categorias = categoriaDAO.selectAllCategorias();
                foreach (var item in categorias)
                {
                    categoria.Items.Add(new ListItem() { Value = item.Id.ToString(), Text = item.Descricao });
                }
            }
        }
        public void Cadastrar(object sender, EventArgs e)
        {

            int idEmpresa = (int)Session["sIdEmp"];
            int categoriaValue = Int32.Parse(categoria.Text);

            Novoservico = new EmpresaServico()
            {
                TempoAprox = tempo.Text,
                Tags = Tags.Text,
                IdCat = Int32.Parse(categoria.Text),
                Desc = descricao.Text,
                ValorAprox = Double.Parse(precoMedio.Text),
                IdEmp = idEmpresa,
                Empresa = empresaDAO.selectEmp(idEmpresa),
                Categoria = categoriaDAO.selectCat(categoriaValue)
            };
                banco.insertEmpServ(Novoservico);
            
            Response.Redirect("gerenciarServicos.aspx");

        }
        public void Editar(object sender, EventArgs e)
        {
            int idEmpresa = (int)Session["sIdEmp"];
            int categoriaValue = Int32.Parse(categoria.Text);

            Novoservico = new EmpresaServico()
            {
                TempoAprox = tempo.Text,
                Tags = Tags.Text,
                IdCat = Int32.Parse(categoria.Text),
                Desc = descricao.Text,
                ValorAprox = Double.Parse(precoMedio.Text),
                IdEmp = idEmpresa,
                Empresa = empresaDAO.selectEmp(idEmpresa),
                Categoria = categoriaDAO.selectCat(categoriaValue),
                Id = Int32.Parse(idServico.Value)
            };
            banco.updateEmpServ(Novoservico);
            Response.Redirect("gerenciarServicos.aspx");

        }
    }
}