﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gerenciarFinancas.aspx.cs" Inherits="TCC.gerenciarFinancas" %>

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
    <%
        double liberado = empSaldo.SaldoLiberado;
        double pendente = empSaldo.SaldoPendente;
        double totHist = empSaldo.SaldoTotalHistorico;
    %>
        <table class="table table-dark">
		    <tr>
		        <th scope="row">TOTALIZADORES:</th>
			    <td>Liberado: R$<%=liberado%></td>
			    <td>Pendente: R$<%=pendente %></td>
			    <td>Total histórico: R$<%=totHist %></td>
			</tr>
		</table>

        		<button type="button" class="btn btn-primary" data-toggle="modal" data-target=".bd-example-modal-x1">Sacar Dinheiro</button>

				<div class="modal fade bd-example-modal-x1" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
				  <div class="modal-dialog" role="document">
				    <div class="modal-content">
				      <div class="modal-header">
				        <h5 class="modal-title" id="exampleModalLabel">Sacar Dinheiro</h5>
				        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
				          <span aria-hidden="true">&times;</span>
				        </button>
				      </div>
				      <div class="modal-body">
				        <div>
				        	<form>
				        		Conta: <input type="text" name=""/> <br/><br/>
				        		Agência: <input type="text" name=""/> <br/><br/>
				        		Operação: <input type="text" name=""/> <br/><br/>
				        		Banco: <input type="text" name=""/> <br/><br/>
                                Valor: <input type="text" name=""/> <br/><br/>

				        		<input type="submit" name="" value="Confirmar" class="btn btn-success"/>

				        	</form>
				        </div>
				      </div>
				      <div class="modal-footer">
				        <button type="button" class="btn btn-danger" data-dismiss="modal">Fechar</button>
				      </div>
				    </div>
				  </div>
				</div>

    
        
</body>
</html>