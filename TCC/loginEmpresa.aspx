<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginEmpresa.aspx.cs" Inherits="TCC.loginEmpresa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
	<title>Login Empresa</title>
</head>
<body class="testBody">
   <div class="menu_principal">
		<div class="menu_principal_int">
			<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
			  
			  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
			    <span class="navbar-toggler-icon"></span>
			  </button>

			  <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
			    <ul class="navbar-nav mr-auto">
			      <li class="nav-item">
			        <a class="nav-link" href="index.aspx">Pagina inicial<span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="sobre.aspx">Sobre Nós<span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="contato.html">Contato <span class="sr-only">(página atual)</span></a>
			      </li>
			    </ul>
			    <form class="form-inline my-2 my-lg-0" action="loginCliente.aspx" method="POST">
			      <button class="btn btn-primary" type="submit">Sou Cliente</button>
			    </form>
			  </div>
			</nav>
		</div>
	</div>

	<div class="conteudo_pagina_principal_empresa">
		<div class="conteudo_pagina_principal_int">
			<img src="imgs/logoSimples.png" width="250"> <br>
			<h3>Logue como empresa!</h3>
			<br>
			<form method="POST" action="#" runat="server">
				<div class="form-group">
					<input type="text" id="login" runat="server" placeholder="Login" class="form-control"> <br><br>
					<input type="password" id="senha"  runat="server" placeholder="Senha" class="form-control">
					<br>
					<input type="submit" onserverclick="autenticar" value="Login" class="btn btn-dark" runat="server">
					<br>
					<small id="emailHelp" class="form-text text-muted">Sua empresa não tem login? <a href="empresaCadastro.aspx">Cadastre-a</a>!</small>
                    <font color="red"><%=mensagem %></font>
				</div>
			</form>
		</div>		
	</div><br /><br /><br />
    <div class="footerTest">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
</body>
</html>
