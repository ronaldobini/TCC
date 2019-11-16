using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class cadastrarUsuario : System.Web.UI.Page
    {
        UsuarioDAO banco = new UsuarioDAO();
        Usuario usuario = new Usuario();
        CidadeDAO cidadeDAO = new CidadeDAO();
        List<Cidade> lista = new List<Cidade>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Request["id"] != null)
                //{
                //    int id = Int32.Parse(Request["id"]);
                //    usuario = banco.selectUser(id);
                //    login.Text = usuario.Login;
                //    senha.Text = usuario.Senha;

                //}
                //else
                //{

                //}
                lista = cidadeDAO.selectAllCids();
                foreach (var item in lista)
                {
                    cidade.Items.Add(new ListItem() { Value = item.Id.ToString(), Text = item.Nome });
                }

            }
        }

        public void Cadastrar(object sender, EventArgs e)
        {


            int idCidade = Int32.Parse(cidade.Text);

            usuario = new Usuario()
            {
                Login = login.Text,
                Senha = senha.Text,
                Nome = nome.Text,
                Email = email.Text,
                Cpf = cpf.Text,
                Cep = cep.Text,
                Endereco = endereco.Text,
                Complemento = complemento.Text,
                Numero = Int32.Parse(numero.Text),
                Tel1 = telefone.Text,
                Tel2 = celular.Text,
                Cidade = cidadeDAO.selectCidadePorId(idCidade),
                Reputacao=0

            };
            banco.insertUser(usuario);
            Response.Redirect("loginCliente.aspx");

        }
    }
}