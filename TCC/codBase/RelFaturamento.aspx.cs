using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IBM.Data.Informix;
using simireports.simireports.Classes;

namespace simireports
{
    public partial class RelFaturamento : System.Web.UI.Page
    {

        public string postDatInicio = "";
        public string postDatFim = "";
        public string postUnidade = "";
        public string postNota = "";
        public string postItem = "";
        public string postDesc = "";
        public string postCliente = "";
        public string postNomCli = "";
        public string postNatur = "";
        public string postPed = "";
        public string postPedCli = "";
        public string postTrans = "";
        public string postFam = "";
        public string sqlview = "";

        public string getPedido = "";

        public Metodos m = new Metodos();
        public String hoje = DateTime.Today.ToString("d");
        public string represChange = "nao";




        public static Decimal totFaturamento = 0.0M;
        public static String totFaturamentoS = "";
        public String erro = " ";


        public List<Faturamento> fats = new List<Faturamento> { };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["key"] != null)
            {
                //VERIFICACAO DE SESSAO E NIVEL
                if ((int)Session["key"] <= 0)
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    //VERFICA NIVEL
                    if ((int)Session["key"] >= 1)
                    {
                        if ((int)Session["key"] >= 5)
                        {
                            represChange = "sim";
                        }
                    }
                    else
                    {
                        erro = "Você não tem permissão para esta pagina";
                        Response.Redirect("index.aspx");
                    }
                }

            }
            else
            {

                Response.Redirect("login.aspx");
            }

            //PEDIDO GET
            getPedido = Request.QueryString["getPedido"];
            if(getPedido != null)
            {
                if (getPedido.Length > 0)
                {
                    postPed = " AND nfi.pedido = " + getPedido + "";
                    postDatInicio = "2016-01-01";
                    postDatFim = hoje;
                    postDatFim = m.configDataHuman2Banco(postDatFim);
                    executarRelatorio();
                }
            }
            

        }

        protected void detalhes_Click(object sender, EventArgs e)
        {

        }

        protected void filtrarFat_Click(object sender, EventArgs e)
        {
            
            postDatInicio = datInicio.Value;
            if (postDatInicio == "") postDatInicio = hoje;

            postDatFim = datFim.Value;
            if (postDatFim == "") postDatFim = hoje;

            postDatInicio = m.configDataHuman2Banco(postDatInicio);
            postDatFim = m.configDataHuman2Banco(postDatFim);
            postUnidade = empresa.Value;
            postNota = nota.Value;
            if (!postNota.Equals(""))
            {
                postNota = " AND nota_fiscal = " + postNota + " ";
            }
            postItem = codItem.Value;
            postItem = postItem.ToUpper();
            postDesc = descItem.Value;
            postDesc = postDesc.ToUpper();
            postCliente = cliente.Value;
            postCliente = postCliente.ToUpper();
            postNomCli = nomCli.Value;
            postNomCli = postNomCli.ToUpper();
            postNatur = natureza.Value;
           
            
            if (postNatur.Equals("1000"))
            {
                postNatur = " AND nfi.natureza_operacao <> 9001 ";
            }
            else if (postNatur.Equals(""))
            {
                postNatur = " AND nfi.natureza_operacao > 1000 "; //todas
            }
            else
            {
                postNatur = " AND nfi.natureza_operacao = " + postNatur + " ";
            }

            postPed = pedido.Value;
            if (!postPed.Equals(""))
            {
                postPed = " AND nfi.pedido = " + postPed + "";
            }

            postFam = familia.Value;
            if (postFam == "00")
            {
                postFam = "";
            }
            else if (postFam == "01")
            {
                postFam = " AND it.cod_familia = '01'";
            }
            else if (postFam == "02")
            {
                postFam = " AND it.cod_familia = '02'";
            }
            else if (postFam == "03")
            {
                postFam = " AND (it.cod_familia = '03' or it.cod_familia = '30' or it.cod_familia = '31' or " +
                                "it.cod_familia = '32' or it.cod_familia = '33' or it.cod_familia = '97')";
            }
            else if (postFam == "09")
            {
                postFam = " AND it.cod_familia = '09'";
            }
            else if (postFam == "34")
            {
                postFam = " AND it.cod_familia = '34'";
            }
            else if (postFam == "50")
            {
                postFam = " AND it.cod_familia = '50'";
            }
            else if (postFam == "98")
            {
                postFam = " AND it.cod_familia = '98'";
            }
            else if (postFam == "99")
            {
                postFam = " AND it.cod_familia = '99'";
            }
            else
            {
                postFam = "";
            }



            postPedCli = pedCli.Value;
            postTrans = trans.Value;

            executarRelatorio();

        }

        protected void executarRelatorio()
        {
            Session["firstJ"] = "0";
            postNota = m.configCoringas(postNota);
            postItem = m.configCoringas(postItem);
            postDesc = m.configCoringas(postDesc);
            postCliente = m.configCoringas(postCliente);
            postNomCli = m.configCoringas(postNomCli);

            IfxConnection conn = new BancoLogix().abrir();
            string sql = "select nf.dat_hor_emissao," +
                " nfi.empresa," +
                " nf.nota_fiscal," +
                " nfi.item," +
                " it.den_item_reduz," +
                " cli.cod_cliente, " +
                " cli.nom_cliente, " +
                " nfi.preco_unit_liquido as valor_unit," +
                " nfi.qtd_item," +
                " nfi.val_bruto_item as valor_total," +
                " nfi.natureza_operacao," +
                " nfi.pedido," +
                " ped.num_pedido_cli," +
                " cli2.nom_cliente" +
                " from fat_nf_mestre nf" +
                "  JOIN fat_nf_item nfi ON (nf.trans_nota_fiscal = nfi.trans_nota_fiscal and nfi.empresa = nf.empresa)" +
                "  JOIN item it ON(nfi.item = it.cod_item and nfi.empresa = it.cod_empresa)" +
                "  JOIN pedidos ped ON(nfi.pedido = ped.num_pedido and nfi.empresa = ped.cod_empresa)" +
                "  JOIN clientes cli on(nf.cliente = cli.cod_cliente)" +
                "  JOIN clientes cli2 on(nf.transportadora = cli2.cod_cliente)" +
                " where nf.dat_hor_emissao >= '" + postDatInicio + " 00:00:00' " +
                " AND nf.dat_hor_emissao <= '" + postDatFim + " 23:59:59' " +
                " AND nf.dat_hor_emissao >= '2016-01-01 00:00:00'" +
                " AND nf.sit_nota_fiscal = 'N'" +
                " AND nfi.empresa like '%" + postUnidade + "%' " +
                " AND nfi.item like '%" + postItem + "%' " +
                " AND it.den_item_reduz like '%" + postDesc + "%' " +
                " AND cli.cod_cliente like '%" + postCliente + "%' " +
                " AND cli.nom_cliente like '%" + postNomCli + "%' " +
                " " + postNota + " " +
                " " + postNatur + " " +
                " " + postPed + " " +
                " " + postFam + " " +
                " AND ped.num_pedido_cli like '%" + postPedCli + "%' " +
                " AND nf.transportadora like '%" + postTrans + "%' " +
                " ORDER BY nota_fiscal ";

            //sqlview = sql; //ativa a exibicao do sql na tela
            IfxDataReader reader = new BancoLogix().consultar(sql, conn);

            totFaturamento = 0.0M;

            DateTime dat = new DateTime();
            string empresa = "";
            string nota = "";
            string codItem = "";
            string descItem = "";
            string cpfCli = "";
            string cliente = "";
            string preUnitS = "";
            int qtdItem = 0;
            string totalS = "";
            string nat = "";
            string pedido = "";
            string pedCli = "";
            string trans = "";

            List<Item> itens = new List<Item>();
            Item item = null;
            Faturamento fat = null;
            bool primeiro = true;
            string notAnt = "";
            string errosql = new BancoLogix().consultarErros(sql,conn);

            if (reader != null && reader.HasRows)
            {
                string resultLog = Metodos.inserirLog((int)Session["idd"], "Executou Rel Faturamento", (string)Session["nome"], postDatInicio + " | " + postCliente);
                while (reader.Read())
                {

                    nota = reader.GetString(2);

                    if (primeiro)
                    {
                        notAnt = reader.GetString(2);
                        primeiro = false;
                    }
                    else
                    {
                        if (nota.Equals(notAnt))
                        {
                            itens.Add(item);
                        }
                        else
                        {
                            itens.Add(item);
                            fat = new Faturamento(dat, empresa, notAnt, cpfCli, cliente, itens, nat, pedido, pedCli, trans);
                            fats.Add(fat);
                            itens = new List<Item>();
                            notAnt = nota;
                        }
                    }
                    dat = new DateTime();
                    dat = reader.GetDateTime(0);
                    empresa = reader.GetString(1);
                    codItem = reader.GetString(3);
                    descItem = reader.GetString(4);
                    cpfCli = reader.GetString(5);
                    cliente = reader.GetString(6);
                    preUnitS = reader.GetString(7);
                    preUnitS = m.pontoPorVirgula(preUnitS);
                    Decimal preUnit = Decimal.Round(Decimal.Parse(preUnitS), 2);
                    qtdItem = m.qtdLogixToInt(reader.GetString(8));
                    //qtdItem = m.pontoPorVirgula(qtdItem);
                    //qtdItem = Convert.ToString(Decimal.Round(Decimal.Parse(qtdItem), 0));
                    totalS = reader.GetString(9);
                    totalS = m.pontoPorVirgula(totalS);
                    Decimal total = Decimal.Round(Decimal.Parse(totalS), 2);
                    nat = reader.GetString(10);
                    pedido = reader.GetString(11);
                    pedCli = reader.GetString(12);
                    trans = reader.GetString(13);
                    //item = new Item(qtdItem, descItem, codItem, preUnit);
                    item = new Item(codItem,0,0,qtdItem,descItem,preUnit,"",0,0,0,0,0,0);

                    totFaturamento += total;
                }
                totFaturamentoS = m.formatarDecimal(totFaturamento);

                itens.Add(item);
                fat = new Faturamento(dat,empresa, nota, cpfCli,cliente, itens, nat, pedido, pedCli, trans);
                fats.Add(fat);
            }
            else
            {
                String erro = "null";
                try
                {
                    erro = new BancoLogix().abrirErros();
                    if (!erro.Equals("sem erros"))
                    {
                        Comissao comissao = new Comissao("NULL", erro, "-", "-", "-", 0, 0, 0, "-", new DateTime(), new DateTime(), new DateTime(), 'T', "-");
                        //comissoes.Add(comissao);
                    }
                }
                catch (Exception ex)
                {
                    erro = "---" + ex;
                    Comissao comissao = new Comissao("NULL", erro, "-", "-", "-", 0, 0, 0, "-", new DateTime(), new DateTime(), new DateTime(), 'T', "-");
                    //comissoes.Add(comissao);
                }

            }
            new BancoLogix().fechar(conn);
        }



        protected void export_Click(object sender, EventArgs e)
        {
            Response.Redirect("RelFaturamentosEx.aspx");
        }








    }
}