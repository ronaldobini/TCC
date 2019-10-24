<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexSimples.aspx.cs" Inherits="TCC.indexSimples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css"/>
	<link rel="stylesheet" type="text/css" href="css/estilo.css"/>
	<title>Index Simples</title>
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
			        <a class="nav-link" href="indexSimples.html">Buscar Serviço <span class="sr-only">(página atual)</span></a>
			      </li>

			      
			    </ul>
			    <form class="form-inline my-2 my-lg-0" action="cliente.aspx" method="POST">
			      <button class="btn btn-outline-success" type="submit">Logue para solicitar um serviço</button>
			    </form>
			  </div>
			</nav>
		</div>
	</div>
	
	<div class="conteudo_index_cliente">
		<div class="conteudo_index_cliente_int">
			<div class="conteudo_index_cliente_int_l">
				Qual serviço você deseja hoje? <br><br>
				<form>
					<select class="form-control form-control-lg">
					  <option>Categoria</option>
					  <option>Automóvel</option>
					  <option>Roupa</option>
					  <option>Geladeira</option>
					</select>
					<br><br>
					<select class="form-control form-control-lg">
					  <option>O que fazer com a cat. (Automovel)</option>
					  <option>Pneu</option>
					  <option>Revisão</option>
					  <option>Pintura</option>
					</select>

				</form>
				<br><br>
				<a href=""><button class="btn btn-success">Buscar</button></a> <br><br>
				Aqui você pode digitar o serviço desejado e o mapa mostrará a listagem de serviços deste tipo localizados próximos a você! <br><br><br>

				

			</div>
			<div class="conteudo_index_cliente_int_r">
				<img src="maps.png" width="900" class="img_map">
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