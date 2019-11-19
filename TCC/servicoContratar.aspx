<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servicoContratar.aspx.cs" Inherits="TCC.servicoContratar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
	<link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
	<title>Contratar Serviço</title>
</head>
<body>
     <center>
    <div class="top_cliente">
		<div class="top_int_cliente">
			<img src="imgs/logoComprida.png" height="120">
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
			      <li class="nav-item">
			        <a class="nav-link" href="mapao.aspx">Buscar Serviço <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="solicitacoesCliente.aspx">Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>
			    </ul>
			    <form class="form-inline my-2 my-lg-0" action="index.aspx" method="POST">
			      <button class="btn btn-outline-danger" type="submit">Sair</button>
			    </form>
			  </div>
			</nav>
		</div>
	</div>

         <br />
         <br />
         <h3>Solicitando Serviço</h3> <br />

    <form id="form1" runat="server">

        <div>
            Serviço: <font color="blue"><%=servicoEscolhido %></font><br />
            Valor Médio / Tempo Médio: <font color="blue"><%=tempoPrecoEstimado %></font><br />
             <br /> <br />
            <div class="form-group ">
                <label for="descricao">O que você espera do serviço?</label>
                <br> 
                
                <textarea runat="server" id="descuserForm" placeholder="Escreva com detalhes o que espera da empresa neste serviço (...)" rows="6" cols="100"></textarea>
            </div>

            <Button runat="server" class="btn btn-primary" onserverclick="cadastrarServ">Solicitar Serviço</Button>

        </div>
    </form>
          <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br />

<div class="footer-good">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>


</body>
</html>
