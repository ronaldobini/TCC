﻿using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCC.Classes;

namespace TCC
{
    public partial class userEmpCadastro : System.Web.UI.Page
    {
        private string postLogin;
        private string postSenha;
        private string postNome;
        private string postEmail;
        private string postCpf;
        private string postCep;
        private string postEnd;
        private string postComplemento;
        private int postNum;
        private string postTel;
        private string postCel;
        private string postCidade = "Curitiba";
        private string postFunc = "ainda n";
        private string postFormacao = "ainda n";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void cadastrar(object sender, EventArgs e)
        {
            postLogin = login.Value;
            postSenha = senha.Value;
            postNome = nomCompleto.Value;
            postEmail = email.Value;
            postCpf = cpf.Value;
            postCep = cep.Value;
            postEnd = endereco.Value;
            postComplemento = complemento.Value;
            postNum = Int32.Parse(numero.Value);
            postTel = tel.Value;
            postCel = cel.Value;
            //postCidade = cidade.Value;
            //postFunc = funcao.Value;
            //postFormacao = formacao.Value;
            int idEmp = 2;
            if (Session["empId"] != null)
            {
                idEmp = (int)Session["empId"];
            }
            MySqlDateTime mysqldt = new MySqlDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            
            Usuario user = new Usuario(0,postLogin,postSenha, postNome,postEmail,postCpf,postTel,postCel,postEnd,postNum,postComplemento,
                postCep, new CidadeDAO().selectCidadePorNome(postCidade),"0", mysqldt, new MySqlDateTime(),0,0,0);
            new UsuarioDAO().insertUser(user);
            user = new UsuarioDAO().selectUserLogin(postLogin);
            UsuarioEmpresa userEmp = new UsuarioEmpresa(0, user.Id, idEmp, postFunc, 10, 0, "", postFormacao, 0);

            new UsuarioEmpresaDAO().insertUserEmp(userEmp);

            Response.Redirect("loginEmpresa.aspx");

        }
    }
}