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
			        <a class="nav-link" href="contato.aspx">Contato <span class="sr-only">(página atual)</span></a>
			      </li>
			    </ul>
			  </div>
			</nav>
		</div>
	</div>

	<div class="conteudo_pagina_cadastro">
		<div class="conteudo_pagina_cadastro_int">
			<img src="imgs/logoSimples.png" width="100" class="logoMenor"><br/>
			<h3>Cadastre sua empresa no Servitiba!</h3>
			<form method="POST" action="#" runat="server">

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="cnpj">CNPJ</label>
			      <input type="text"  runat="server" class="form-control" id="cnpj" placeholder="CNPJ" required/>
			    </div>
			    <div class="form-group col-md-6">
			      <label for="razaoSocial">Razão Social</label>
			      <input type="text"  runat="server" class="form-control" id="razaoSocial" placeholder="Razão Social" required/>
			    </div>
			  </div>

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="tel">Telefone</label>
			      <input type="tel"  runat="server" class="form-control" id="tel" placeholder="xxxx-xxxx" required/>
			    </div>
			    <div class="form-group col-md-6">
			      <label for="cel">Celular</label>
			      <input type="text" runat="server"  class="form-control telefone" id="cel" placeholder="xxxxx-xxxx" required/>
			    </div>
			  </div>
                
			  <div class="form-row">
			    <div class="form-group col-md-12">
			      <label for="cep">CEP</label>
			      <input type="tel" runat="server"  class="form-control" id="cep" placeholder="CEP" required/>
			    </div>
			  </div>

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="endereco">Endereço</label>
			      <input type="text"  runat="server" class="form-control" id="endereco" placeholder="Endereço" required/>
			    </div>
			    <div class="form-group col-md-4">
			      <label for="complemento">Complemento</label>
			      <input type="text" runat="server"  class="form-control" id="complemento" placeholder="Complemento"/>
			    </div>
			    <div class="form-group col-md-2">
			      <label for="numero">Número</label>
			      <input type="text" runat="server"  class="form-control" id="numero" placeholder="Número" required/>
			    </div>
			  </div>
                
			  <div class="form-group col-md-3">
                  <div class="form-group">
                    <label for="categoria">Cidade</label>
                    <asp:DropDownList ID="cidade" runat="server" CssClass="form-control" required></asp:DropDownList>
                </div>
			    <div class="form-row">
			      <label for="zonaA">Zona de Atendimento</label>
			      <input type="text" runat="server"  class="form-control" id="zonaAtendimento" placeholder="Zona Atendimento" required/>
			    </div>
			    <div class="form-row">
			      <label for="funcs">Funcionarios</label>
			      <input type="text" runat="server"  class="form-control" value="1" id="qtdFunc" placeholder="Quantidade de Funcionarios" required/>
			    </div>
			  </div>
			  <div class="form-row">
			   
			    <div class="form-group col-md-8">
			      <label for="descricao">Descrição da Empresa</label> <br/>
			      <textarea runat="server" name="message" rows="5" id="descricao" cols="60" required></textarea>
			    </div>
			  </div>
			  
			  <button type="submit" runat="server" onserverclick="cadastrar" class="btn btn-primary">Próximo</button>
			  
			</form>
		</div>		
	</div>
    <div class="centralizar"><small id="emailHelp" class="form-text text-muted">Sua empresa já é cadastrada? <a href="loginEmpresa.aspx">Faça Login</a>!</small>
			  <small id="emailHelp" class="form-text text-muted">Não tem login? Solicite ao seu superior!</small></div>
	<br><br>
   <div class="footer-good">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
</body>
</html>