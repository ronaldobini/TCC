<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginCliente.aspx.cs" Inherits="TCC.loginCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
	<title>Login</title>
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
			        <a class="nav-link" href="contato.html">Contato <span class="sr-only">(página atual)</span></a>
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
			<img src="imgs/logoSimples.png" width="250"> <br><br>
			<form runat="server" method="post" action="#">
				<div class="form-group">
					<input type="text" name="" placeholder="Login" class="form-control" id="login" runat="server"> <br><br>
					<input type="password" name="" placeholder="Senha" class="form-control" id="senha" runat="server">
					<br>
					<input type="submit" onserverclick="autenticar" value="Login" class="btn btn-success" runat="server">
					<br>
					<small id="emailHelp" class="form-text text-muted">Não tem login? <a href="cadastrarUsuario.aspx">Cadastre-se!</a></small>
                    <font color="red"><%=mensagem %></font>
				</div>
			</form>
		</div>		
	</div> <br /><br /><br /><br /><br />
    <div class="footerTest">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
</body>
</html>
