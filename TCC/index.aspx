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

			<nav class="navbar navbar-expand-lg navbar-dark navbar-color">
			  
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
                  
                  <div class="menu_teste_2">
			      <a href="loginEmpresa.aspx"><button class="btn btn-primary" type="submit">Sou Empresa</button></a>
                  </div>
			    
			  </div>
			</nav>

    <form runat="server">
	    <div class="conteudo_pagina_principal">
		    <div class="conteudo_pagina_principal_int">
			    <img class="img-fluid" src="imgs/logoComprida.png" width="650">

                <div class="col-sm-4"></div>
                <div class="tamanho_campos col-sm-5">			   
				        <div class="form-group">

					        <input type="text" runat="server" id="cep" placeholder="Digite seu CEP, rua ou bairro..." class="form-control">
					        <small id="emailHelp" class="form-text ">Sem cadastro, sem burocracias! Experimente dar apenas uma espiadinha!</small> <br>
					        <input type="submit" runat="server" onserverclick="espiarClick" id="Espiar" value="Espiar" class="btn btn-primary btn-block">	        
                        </div>
		        </div>		
	    </div>
        </div>
    
	<div class="conteudo_pagina_principal_2">
		<div class="conteudo_pagina_principal_2_int">
			<div>
                <a href="loginCliente.aspx"><button runat="server" onserverclick="loginCliente" class="btn btn-outline-dark col-md-2">Login</button></a>
			</div><br/>
			<div>
                <a href="cadastrarUsuario.aspx"><button runat="server" onserverclick="cadastroCliete" class="btn btn-outline-dark col-md-2">Cadastrar-se</button></a>
			</div>
		</div>
	</div>
    </form>
</body>

      <footer class="py-3 bg-dark footer-good">
            <div class="container">
                <p class="m-0 text-center text-white">© 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/></p>
            </div>
      </footer>

        
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    
</html>