﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexPrestador.aspx.cs" Inherits="TCC.indexPrestador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
	<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="estilo.css">
	<title>Home Page</title>
</head>
<body>
	<div class="top_cliente">
		<div class="top_int_cliente">
			Nome do Sistema
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
			      <li class="nav-item active">
			        <a class="nav-link" href="indexPrestador.html">Lista de Pedidos <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="PedidosAceitos.html">Pedidos Aceitos <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="pedidosEmExecucao.html">Pedidos Em Execução <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="cadastrarColaborador.html">Cadastrar Colaborador <span class="sr-only">(página atual)</span></a>
			      </li>
			    </ul>
			    <form class="form-inline my-2 my-lg-0" action="index.html" method="POST">
			      <button class="btn btn-outline-danger" type="submit">Sair</button>
			    </form>
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
					</a>Aceitar: <a data-toggle="tooltip" title=""><img src="checked.png"></a> --------- Recusar: <a data-toggle="tooltip" title=""><img src="x-button.png"></a>
					
				</div><br><hr><br>
				Estes são os novos pedidos de serviço: <br>
				 <br><br>
				<table class="table table-dark">
				  <thead>
				    <tr>
				      <th scope="col">Nº</th>
				      <th scope="col">Nome do Cliente</th>
				      <th scope="col">Solicitação</th>
				      <th scope="col">Categoria</th>
				      <th scope="col">Data da Solicitação</th>
				      <th scope="col">Para quando?</th>
				      <th scope="col">Ação</th>
				    </tr>
				  </thead>
				  <tbody>
				    <tr>
				      <th scope="row">1</th>
				      <td>Nicolas</td>
				      <td>Pintura</td>
				      <td>Automóvel</td>
				      <td>12-12-2002</td>
				      <td>13-12-2002</td>
				      <td><a href=""><img src="checked.png"></a> --- <a href=""><img src="x-button.png"></a></td>
				    </tr>
				    <tr>
				      <th scope="row">2</th>
				      <td>Ronaldo</td>
				      <td>Costura</td>
				      <td>Alfaiate</td>
				      <td>12-12-2002</td>
				      <td>16-12-2002</td>
				      <td><a href=""><img src="checked.png"></a> --- <a href=""><img src="x-button.png"></a></td>
				    </tr>
				    <tr>
				      <th scope="row">3</th>
				      <td>Mattei</td>
				      <td>Reparo</td>
				      <td>Sapateiro</td>
				      <td>12-12-2002</td>
				      <td>12-12-2002</td>
				      <td><a href=""><img src="checked.png"></a> --- <a href=""><img src="x-button.png"></a></td>
				    </tr>
				  </tbody>
				</table>
			</div>
		</div>
	</div>


	<div class="footer">
		<div class="footer_int">
			Rodapé teste. Aqui terá um rodapé.
		</div>
	</div>
</body>
</html>