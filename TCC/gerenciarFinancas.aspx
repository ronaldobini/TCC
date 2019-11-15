<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gerenciarFinancas.aspx.cs" Inherits="TCC.gerenciarFinancas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
    <title>Gerenciamento Finanças</title>
</head>
<body>
    <div class="top_cliente">
		<div class="top_int_cliente">
			Servitiba
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
			      <li class="nav-item">
			        <a class="nav-link" href="indexPrestador.aspx">Lista de Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="servicoEmExecucao.aspx">Serviços Em Execução <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item active">
			        <a class="nav-link" href="servicosFinalizados.aspx">Serviços Finalizados <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="gerenciarServicos.aspx">Gerenciar Serviços <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item">
			        <a class="nav-link" href="empresaColaboradores.aspx">Gerenciar Colaboradores <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item">
			        <a class="nav-link" href="empresaFinancas.aspx">Gerenciar Finanças <span class="sr-only">(página atual)</span></a>
			      </li>
			    </ul>
                   <a style="margin-right:30px;" href="minhaConta.aspx"><font color="green"><%=Session["sNome"] %> (<%=Session["sFuncao"] %>)</font></a>
			    <form class="form-inline my-2 my-lg-0" action="index.aspx" method="POST">
			      <button class="btn btn-outline-danger" type="submit">Sair</button>
			    </form>
			  </div>
			</nav>
		</div>
	</div>

    <div class="conteudo_relatorio_cliente">
		<div class="conteudo_solicitacao_cliente_int">
			
				<br/><br/>
			    <div class="panel">	
				</div> <br/> <hr/> <br/>

                <img src="imgs/circular-clock.png"/> Saldo de serviços: <br/><br/> <br/>

				<table class="table table-dark">
				  <thead>
				    <tr>
				      <th scope="col">Nº</th>
				      <th scope="col">Solicitação</th>
				      <th scope="col">Nome do Cliente</th>
				      <th scope="col">Valor cobrado</th>
				      <th scope="col">Data de início</th>
				      <th scope="col">Status</th>
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
        DateTime datIni = serv.DataIni;
        DateTime datFim = serv.DataFim;
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



%>
				    <tr>
				      <th scope="row"><%=idServico %></th>
				      <td><%=cliente %></td>
				      <td><%=servico %></td>
				      <td><%=resumo %></td>
				      <td><%=datIni %></td>
				      <td><%=datFim %></td>                        
				      <td><%=situ %></td>
				      <td><a href="servicoDetalhes.aspx"><img src="imgs/more.png"></a></td>
				    </tr>

<%
    }
%>
				    
				  </tbody>
				</table>
        </div>
    </div>
        <table class="table table-dark">
		    <tr>
		        <th scope="row">TOTALIZADORES:</th>
			    <td>Liberado: R$3000</td>
			    <td>Pendente: R$1500</td>
			    <td>Total histórico: R$4500</td>
			</tr>
		</table>
</body>
</html>
