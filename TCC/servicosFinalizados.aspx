<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servicosFinalizados.aspx.cs" Inherits="TCC.servicosFinalizados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Serviços Finalizados</title>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css"/>
	<link rel="stylesheet" type="text/css" href="css/estilo.css"/>
	<link rel="stylesheet" href="assets/css/Footer-with-button-logo.css"/>
</head>
<body class="body2">
    <div class="top_cliente">
		<div class="top_int_cliente">
			<img src="imgs/logoComprida.png" width="300"/>
		</div>
	</div>

	<div class="menu">
		<div class="menu_int">
			<nav class="navbar navbar-expand-lg navbar-dark navbar-color">
			  
			  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
			    <span class="navbar-toggler-icon"></span>
			  </button>

			  <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
			    <ul class="navbar-nav mr-auto">
			        <% if ((int)Session["sNivelEmp"] > 1)
                      {%>
			      <li class="nav-item">
			        <a class="nav-link" href="indexPrestador.aspx">Lista de Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="servicoEmExecucao.aspx">Serviços em Execução <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item active">
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
			            <a class="nav-link" href="servicoEmExecucao.aspx">Serviços em Execução <span class="sr-only">(página atual)</span></a>
			        </li>

                    <% } %>
			    </ul><%if ((int)Session["sNivelEmp"] > 2)
                         {%>
                   <a style="margin-right:30px;" href="empresaCadastro.aspx?id=<%=(int)Session["sIdEmp"] %>"><font color="#65e05e"><%=Session["sNome"] %> (<%=Session["sFuncao"] %>)</font></a>
                  <%} else{%>
                  <a style="margin-right:30px;"><font color="#65e05e"><%=Session["sNome"] %> (<%=Session["sFuncao"] %>)</font></a>
                  <%}%>
                  <a href="Logout.aspx"><button class="btn btn-outline-danger">Sair</button></a>
			  </div>
			</nav>
		</div>
	</div>
	
        <div class="conteudo_index_cliente_int2">
            <div class="solicitacaoPrestador_int2">
			
				<br/>
				<div class="panel">
		
				<hr/>
				 <br/>
				<h4>Serviços Finalizados <img src="imgs/checked.png"/></h4> 
                <div class="table-responsive">
				<table class="table table-bordered">
				  <thead class="thead-dark">
				    <tr>
				      <th scope="col">Nº</th>
				      <th scope="col">Nome do Cliente</th>
				      <th scope="col">Serviço</th>
				      <th scope="col">Resumo</th>
				      <th scope="col">Data do início</th>
				      <th scope="col">Data Fim Prev</th>
                      <th scope="col">Data Fim Real</th>
                      <th scope="col">Nota Media</th>
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
        datIni = serv.DataIni;
        datFim = serv.DataFimEst;
        datFimR = serv.DataFim;
        double notaMedia = (serv.RepQualidade + serv.RepAtendimento + serv.RepTempo)/3;

        TCC.Classes.Usuario user = new TCC.Classes.UsuarioDAO().selectUser(idCliente);
        string cliente = user.Nome;

        string servico = new TCC.Classes.EmpresaServicoDAO().selectDescPorId(idEmpSer);
        
        string linkServDet = "servicoDetalhes.aspx?idSerDet="+idServico;

        string mediabonita = notaMedia.ToString().Substring(0,2) + "%";

%>
				    <tr>
				      <th scope="row"><%=idServico %></th>
				      <td><%=cliente %></td>
				      <td><%=servico %></td>
				      <td><%=resumo %></td>
				      <td><%=datIni %></td>
				      <td><%=datFim %></td>                        
				      <td><%=datFimR %></td>                        
				      <td><%=mediabonita %></td>
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
     <footer class="py-3 bg-dark footer-good">
            <div class="container">
                <p class="m-0 text-center text-white">© 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/></p>
            </div>
      </footer>
</body>
