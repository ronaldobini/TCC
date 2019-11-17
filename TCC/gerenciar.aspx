<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gerenciar.aspx.cs" Inherits="TCC.gerenciar" %>

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
<body class="bodyTeste2">
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

			    </ul>
			    <form class="form-inline my-2 my-lg-0" action="" method="POST">
                  <div class="menu_teste_2">
                  <button class="btn btn-danger" type="submit">Sair</button>
                  </div>
			    </form>
			  </div>
			</nav>
		</div>
	</div>

	<div class="conteudo_pagina_principal">
		<div class="conteudo_pagina_principal_int">
            <br /><h2 class="h2gerente">Empresas cadastradas no Servitiba</h2><br /><br /><hr /><br />
			<table class="table table-dark">
              <thead>
                <tr>
                  <th scope="col">ID</th>
                  <th scope="col">Nome</th>
                  <th scope="col">CNPJ</th>
                  <th scope="col">Remover do Servitiba</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <th scope="row">3</th>
                  <td>Teste</td>
                  <td>555</td>
                  <td><a href=""><img src="imgs/x-button.png"/></a></td>
                </tr>
              </tbody>
            </table>
		</div>		
	</div> <br /><br /><br /><br /><br />
    <div class="footer-good">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
</body>
</html>
