<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empresaCadastro.aspx.cs" Inherits="TCC.empresaCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">

	<title>Cadastro da Empresa</title>
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
			  </div>
			</nav>
		</div>
	</div>

	<div class="conteudo_pagina_cadastro">
		<div class="conteudo_pagina_cadastro_int">
			<img src="imgs/logoTeste.png" width="100"><br>
			<h3>Cadastre sua empresa no Servitiba!</h3>
			<form method="POST" action="userEmpCadastro.aspx" runat="server">

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="cnpj">CNPJ</label>
			      <input type="text" runat="server" class="form-control" id="cnpj" placeholder="CNPJ">
			    </div>
			    <div class="form-group col-md-6">
			      <label for="razaoSocial">Razão Social</label>
			      <input type="text" runat="server" class="form-control" id="razaoSocial" placeholder="Razão Social">
			    </div>
			  </div>

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="tel">Telefone</label>
			      <input type="tel" runat="server" class="form-control" id="tel" placeholder="xxxx-xxxx">
			    </div>
			    <div class="form-group col-md-6">
			      <label for="cel">Celular</label>
			      <input type="text" runat="server" class="form-control telefone" id="cel" placeholder="(XX)x xxxx-xxxx">
			    </div>
			  </div>

			  <div class="form-row">
			    <div class="form-group col-md-12">
			      <label for="cep">CEP</label>
			      <input type="tel" runat="server" class="form-control" id="cep" placeholder="CEP">
			    </div>
			  </div>

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="endereco">Endereço</label>
			      <input type="text" runat="server" class="form-control" id="endereco" placeholder="Endereço">
			    </div>
			    <div class="form-group col-md-2">
			      <label for="complemento">Complemento</label>
			      <input type="text" runat="server" class="form-control" id="complemento" placeholder="Complemento">
			    </div>
			    <div class="form-group col-md-4">
			      <label for="num">Número</label>
			      <input type="text" runat="server" class="form-control" id="num" placeholder="Número">
			    </div>
			  </div>

			  <br>

			  
			  <button type="submit" class="btn btn-primary">Próximo</button>
			  <small id="emailHelp" class="form-text text-muted">Sua empresa já é cadastrada? <a href="loginEmpresa.html">Faça Login</a>!</small>
			  <small id="emailHelp" class="form-text text-muted">Não tem login? Solicite ao seu superior!</small>
			</form>
		</div>		
	</div>
	<br>
    <footer id="myFooter">
        <div class="container">
            <div class="row">
                <div class="col-sm-3">
                    <h2 class="logo"><a href="https://programadorviking.com.br/"> <img src="logoTeste.png" width="250"> </a></h2>
                </div>
                <div class="col-sm-2">
                    <h5>Inicio</h5>
                    <ul>
                        <li><a href="https://programadorviking.com.br/">Home</a></li>
                        <li><a href="https://bit.ly/front-end-curso-completo-promocao-01">Cursos</a></li>
                        <li><a href="https://programadorviking.com.br/">Downloads</a></li>
                    </ul>
                </div>
                <div class="col-sm-2">
                    <h5>Sobre-nós</h5>
                    <ul>
                        <li><a href="https://programadorviking.com.br/">Informações da Empresa</a></li>
                        <li><a href="https://programadorviking.com.br/">Contato</a></li>
                        <li><a href="https://programadorviking.com.br/">Blog</a></li>
                    </ul>
                </div>
                <div class="col-sm-2">
                    <h5>Suporte</h5>
                    <ul>
                        <li><a href="https://programadorviking.com.br/">FAQ</a></li>
                        <li><a href="https://programadorviking.com.br/">Telefones</a></li>
                        <li><a href="https://programadorviking.com.br/">Chat</a></li>
                    </ul>
                </div>
                <div class="col-sm-3">
                    <a href="https://programadorviking.com.br/">
                        <button type="button" class="btn btn-default">Contato</button>
                    </a>
                </div>
            </div>
        </div>
        <div class="footer-copyright">
            <p>© 2019 Copyright - Nome do sistema</p>
        </div>
    </footer>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>