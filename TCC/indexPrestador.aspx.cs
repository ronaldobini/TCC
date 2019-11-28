using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;
using MySql.Data.Types;

namespace TCC
{
    public partial class indexPrestador : System.Web.UI.Page
    {
        public List<Servico> servsDB = new List<Servico>();
        public string dataFimEst;

        protected void Page_Load(object sender, EventArgs e)
        {
            //SAFE SESSION

            if (Session["sIdEmp"] != null)
            {
                int SS_empresa = (int)Session["sIdEmp"];
                //puxa lista do banco de dados
                servsDB = new ServicoDAO().selectAllServsEmpSolic(SS_empresa);
            }
            else
            {
                Response.Redirect("loginEmpresa.aspx?sit=1&msg=sessaoInvalida");
            }
        }
    }
}