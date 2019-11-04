﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userEmpCadastro.aspx.cs" Inherits="TCC.userEmpCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">

	<title>Cadastro de Gerente</title>
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
			<img src="logoTeste.png" width="100"><br>
			<h3>Cadastre o Gerente da Empresa!</h3>
			
			<form method="POST" action="#" runat="server">

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="login">Login</label>
			      <input type="text" runat="server" class="form-control" id="login" placeholder="Login">
			    </div>
			    <div class="form-group col-md-6">
			      <label for="senha">Senha</label>
			      <input type="password" runat="server" class="form-control" id="senha" placeholder="Senha">
			    </div>
			  </div>

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="nomCompleto">Nome Completo</label>
			      <input type="text" runat="server" class="form-control" id="nomCompleto" placeholder="Nome completo">
			    </div>
			    <div class="form-group col-md-6">
			      <label for="email">E-mail</label>
			      <input type="email" runat="server" class="form-control" id="email" placeholder="exemplo@exemplo.com.br">
			    </div>
			  </div>

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="cpf">CPF</label>
			      <input type="text" runat="server" class="form-control" id="cpf" placeholder="Apenas números">
			    </div>
			    <div class="form-group col-md-6">
			      <label for="cep">CEP</label>
			      <input type="text" runat="server" class="form-control" id="cep" placeholder="Apenas números">
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
			      <label for="numero">Número</label>
			      <input type="text" runat="server" class="form-control" id="numero" placeholder="Número">
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
			  </div> <br>

			  <div class="form-row">
			    <select class="form-control col-md-4">
			    	<option>Cidade...</option>
			    </select>
			    <select class="form-control col-md-4">
			    	<option>Função...</option>
			    </select>
			    <select class="form-control col-md-4">
			    	<option>Formação...</option>
			    </select>
			  </div><br>

			  
			  <button type="submit" class="btn btn-success">Cadastrar Empresa</button>
			  <small id="emailHelp" class="form-text text-muted">Sua empresa já é cadastrada? <a href="loginEmpresa.html">Faça Login</a>!</small>
			  <small id="emailHelp" class="form-text text-muted">Não tem login? Solicite ao seu superior!</small>
			</form>
		</div>		
	</div>
	<br><br><br><br>
    <footer id="myFooter">
        <div class="container">
            <div class="row">
                <div class="col-sm-3">
                    <h2 class="logo"><a href="https://programadorviking.com.br/"> <img src="imgs/logoTeste.png" width="250"> </a></h2>
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
            <p>© 2019 Copyright - Servitiba</p>
        </div>
    </footer>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>