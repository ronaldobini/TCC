<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexPrestador.aspx.cs" Inherits="TCC.indexPrestador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
	<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
	<title>Home Page</title>
</head>
<body>
	<div class="top_cliente">
		<div class="top_int_cliente">
			<img src="imgs/logoComprida.png" width="300"/>
		</div>
	</div>

	<div class="menu">
		<div class="menu_int">
			<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
			  
			  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
			    <span class="navbar-toggler-icon"></span>
			  </button>

			  <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
			    <ul class="navbar-nav mr-auto">

                  <% if ((int)Session["sNivelEmp"] > 1)
                      {%>
			      <li class="nav-item active">
			        <a class="nav-link" href="indexPrestador.aspx">Lista de Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="servicoEmExecucao.aspx">Serviços Em Execução <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item">
			        <a class="nav-link" href="servicosFinalizados.aspx">Serviços Finalizados <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="gerenciarServicos.aspx">Gerenciar Serviços <span class="sr-only">(página atual)</span></a>
			      </li>
                     <% }
                if ((int)Session["sNivelEmp"] > 2)
                {%>
                   <li class="nav-item">
			        <a class="nav-link" href="empresaColaboradores.aspx">Gerenciar Colaboradores <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item">
			        <a class="nav-link" href="gerenciarFinancas.aspx">Gerenciar Finanças <span class="sr-only">(página atual)</span></a>
			      </li>

                    <% }
                    else
                    { %>

                    <li class="nav-item">
			            <a class="nav-link" href="servicoEmExecucao.aspx">Serviços Em Execução <span class="sr-only">(página atual)</span></a>
			        </li>

                    <% } %>
			    </ul>
                <a style="margin-right:30px;" href="minhaConta.aspx"><font color="green"><%=Session["sNome"] %> (<%=Session["sFuncao"] %>)</font></a>
			    
			      <a href="Logout.aspx"><button class="btn btn-outline-danger">Sair</button></a>
			    
			  </div>
			</nav>
		</div>
	</div>
	
	<div class="conteudo_solicitacoes_cliente">
		<div class="conteudo_index_cliente_int">
			<div class="solicitacaoCliente_int">
				<br><br>
				<div class="panel">
					Legenda das ações: <br><br>
					</a>Aceitar: <a data-toggle="tooltip" title=""><img src="imgs/checked.png"></a> --------- Recusar: <a data-toggle="tooltip" title=""><img src="imgs/x-button.png"></a>
					
				</div><br><hr><br>
				Estes são os novos pedidos de serviço: <br>
				 <br><br>
				<table class="table table-dark">
				  <thead>
				    <tr>
                      <th scope="col">Nº</th>
				      <th scope="col">Nome do Cliente</th>
				      <th scope="col">Serviço</th>
				      <th scope="col">Resumo</th>
				      <th scope="col">Pra quando?</th>      
				      <th scope="col">Ações</th>
				      <th scope="col">Detalhes</th>                  
				    </tr>
				  </thead>
				  <tbody>

<%

    foreach (var serv in servsDB)
    {

        int idServico = serv.Id;
        int idCliente = serv.IdUser;
        int idEmpSer = serv.IdEmpSer;
        string resumo = serv.DescUser;
        dataFimEst = serv.DataFimEst;
        int sit = serv.Sit;

        string situ = "-";
        if (sit == 1)
        {
            situ = "<font color=orange>Executando</font>";
        }else if (sit == 2)
        {
            situ = "<font color=blue>Aguardando Aceite</font>";
        }else if (sit == -1)
        {
            situ = "<font color=red>Problemas</font>";
        }

        TCC.Classes.Usuario user = new TCC.Classes.UsuarioDAO().selectUser(idCliente);
        string cliente = user.Nome;

        string servico = new TCC.Classes.EmpresaServicoDAO().selectDescPorId(idEmpSer);

        string linkServDet = "servicoDetalhes.aspx?idSerDet="+idServico;

          string di = dataFimEst.ToString();
          if (di  == "01/01/2001 00:00:00") { di = "A definir"; }


%>

				    <tr>
                              

				      <th scope="row"><%=idServico %></th>
				      <td><%=cliente %></td>
				      <td><%=servico %></td>
				      <td><%=resumo %></td>
				      <td><%=di %></td> 
				      <td><a href=""><img src="imgs/checked.png"></a> --- <a href=""><img src="imgs/x-button.png"></a></td>
				      <td><a href="<%=linkServDet %>"><img src="imgs/more.png"></a></td>
				    </tr>	
                      
<%
    }
%>

				  </tbody>
				</table>
			</div>
		</div>
	</div>

    <br /><br /><br /><br /><br /><br /><br /><br />
	<div class="footerTest">
        <div class="footer-good">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
</body>
</html>