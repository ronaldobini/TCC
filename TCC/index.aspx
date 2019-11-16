<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TCC.Index" %>
<!DOCTYPE html>
<html>
<head>
	<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
	<title>Servitiba</title>
</head>
<body>
	<div class="menu_principal">
		<div class="menu_principal_int">
			<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
			  
			  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
			    <span class="navbar-toggler-icon"></span>
			  </button>

			  <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
			    <ul class="navbar-nav mr-auto">
			      <li class="nav-item active">
			        <a class="nav-link" href="index.aspx">Pagina inicial<span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="sobre.aspx">Sobre Nós<span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="contato.aspx">Contato <span class="sr-only">(página atual)</span></a>
			      </li>
			    </ul>
			    <form class="form-inline my-2 my-lg-0" action="loginEmpresa.aspx" method="POST">
			      <button class="btn btn-outline-primary" type="submit">Sou Empresa</button>
			    </form>
			  </div>
			</nav>
		</div>
	</div>

	<div class="conteudo_pagina_principal">
		<div class="conteudo_pagina_principal_int">
			<img src="imgs/logoComprida.png" width="650"> <br><br>
			<form method="POST" action="mapao.aspx">
				<div class="form-group">
					<input type="" name="" placeholder="Nome Completo" class="form-control"> <br><br>
					<input type="" name="" placeholder="CEP" class="form-control">
					<small id="emailHelp" class="form-text text-muted">Sem cadastro, sem burocracias! Experimente dar apenas uma espiadinha!</small> <br>
					<input type="submit" name="" value="Espiar" class="btn btn-primary">
				</div>
			</form>
		</div>		
	</div>

	<div class="conteudo_pagina_principal_2">
		<div class="conteudo_pagina_principal_2_int">
			<div class="botao_esq"><a href="loginCliente.aspx"><button class="btn btn-success">Login</button></a></div>
			<div class="botao_dir"><a href="cadastrarUsuario.aspx"><button class="btn btn-success">Cadastrar-se</button></a></div>
		</div>
	</div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <br /><br /><br />

    <div class="footerTest">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
    
</body>
</html>