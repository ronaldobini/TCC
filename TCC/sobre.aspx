﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sobre.aspx.cs" Inherits="TCC.sobre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
	<title>Sobre Nós</title>
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
			      <li class="nav-item">
			        <a class="nav-link" href="index.aspx">Pagina inicial<span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item active">
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

	<div class="conteudo_pagina_principal">
		<div class="conteudo_pagina_principal_int">
			<img src="imgs/logoTeste.png" width="150"> <br><br> <h2>Sobre a Servitiba:</h2>
			<br> Nós somos uma empresa focada em agilizar a sua procura de serviços localizados
			próximos a você e proporcionar a intermediação de contato entre você e o fornecedor. 

			<hr>

			<h2>A equipe:</h2>
			<br>

			<img src="imgs/leonardo.jpg" class="equipe"> Leonardo Felipe Comar <br><br>
			<img src="imgs/lucas.jpg" class="equipe"> Lucas Mattei Malfertheiner <br><br>
			<img src="imgs/ronaldo.jpg" class="equipe"> Ronaldo Bini da Silva Jr <br><br>
			<img src="imgs/nicolas.jpg" class="equipe"> Nicolas Chueh Sourient <br><br>
			<img src="imgs/victor.jpg" class="equipe"> Victor Rochadel Gantzel <br><br>

	</div>

	<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
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