using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class indexPrestador : System.Web.UI.Page
    {
        public List<Servico> servsDB = new List<Servico>();

        protected void Page_Load(object sender, EventArgs e)
        {


            //mudar pra session
            int SS_empresa = (int)Session["sIdEmp"];


            //puxa lista do banco de dados
            servsDB = new ServicoDAO().selectAllServsEmpSolic(SS_empresa);







        }
    }
}