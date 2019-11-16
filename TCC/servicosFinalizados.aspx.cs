﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;
using MySql.Data.Types;
namespace TCC
{
    public partial class servicosFinalizados : System.Web.UI.Page
    {
        public List<Servico> servsDB = new List<Servico>();
        public DateTime datFimR;
        public DateTime datIni;
        public DateTime datFim;

        protected void Page_Load(object sender, EventArgs e)
        {


            //SAFE SESSION

            if (Session["sIdEmp"] != null)
            {
                int SS_empresa = (int)Session["sIdEmp"];
                //puxa lista do banco de dados
                servsDB = new ServicoDAO().selectAllServsEmpFin(SS_empresa);
            }
            else
            {
                Response.Redirect("loginEmpresa.aspx");
            }








        }
    }
}