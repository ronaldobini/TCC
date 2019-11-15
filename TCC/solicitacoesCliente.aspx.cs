using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class solicitacoesCliente : System.Web.UI.Page
    {
        public List<Servico> solicitacoes;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sId"] == null)
            {
                Response.Redirect("loginCliente.aspx");
            }

            int idUser = (int)Session["sId"];
            solicitacoes = new ServicoDAO().selectAllServsUser(idUser);
        }
    }
}