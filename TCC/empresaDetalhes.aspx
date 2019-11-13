<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empresaDetalhes.aspx.cs" Inherits="TCC.empresaDetalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
	<link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
	<title>Buscar Serviço</title>
</head>
<body>
    <div class="top_cliente">
		<div class="top_int_cliente">
			<img src="logo.png" height="120">
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
			        <a class="nav-link" href="indexCliente.html">Buscar Serviço <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="solicitacoesCliente.html">Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="relatoriosCliente.html">Relatórios <span class="sr-only">(página atual)</span></a>
			      </li>
			    </ul>
			    <form class="form-inline my-2 my-lg-0" action="principal.html" method="POST">
			      <button class="btn btn-outline-danger" type="submit">Sair</button>
			    </form>
			  </div>
			</nav>
		</div>
	</div>
	
	<div class="conteudo_index_cliente">
		<div class="conteudo_index_cliente_int">
			Detalhes da empresa selecionada

            <div class="form-row">
                <div class="form-group col-md-6">
                    <table>
                        <tr><th>Serviço</th><th>Contratar</th></tr>
                        <%foreach (var serv in servs)
                            { %>

                        <tr><td><%=serv.Desc %></td><td>CONTRATAR</td></tr>                        
                        
                        <% } %>
                    </table>
                </div>
            </div>



			  <div class="form-row">
			    <div class="form-group col-md-2">
			      <label for="inputEmail4">CNPJ</label><br>
			      <font color="blue"><%=cnpj %></font>
			    </div>
			    <div class="form-group col-md-2">
			      <label for="inputPassword4">Razão Social</label><br>
			      <font color="blue"><%=razaoSocial %></font>
			    </div>
                 <div class="form-group col-md-2">
			     <label for="inputEmail4">Diretor</label><br>
			     <font color="blue"><%=diretor %></font>
			    </div>
			  </div><br>
              

			  <div class="form-row">                
                  <div class="form-group col-md-2">
			      <label for="inputEmail4">Representante Comercial</label><br>
			      <font color="blue"><%=comercial %></font>
			    </div>
                 <div class="form-group col-md-2">
			      <label for="inputEmail4">Representante Técnico</label><br>
			      <font color="blue"><%=tecnico %></font>
			    </div>
			    <div class="form-group col-md-2">
			      <label for="inputEmail4">Telefone 1</label><br>
			      <font color="blue"><%=telefone1 %></font>
			    </div>
			    
			  </div><br>

			  <div class="form-row">
			    <div class="form-group col-md-2">
			      <label for="inputEmail4">Endereço</label><br>
			      <font color="blue"><%=endereco %>, <%=numero %></font>
			    </div>			   
			    <div class="form-group col-md-2">
			      <label for="inputPassword4">Complemento</label><br>
			      <font color="blue"><%=complemento %></font>
			    </div>
                <div class="form-group col-md-2">
			      <label for="inputPassword4">Telefone 2</label><br>
			      <font color="blue"><%=telefone2 %></font>
			    </div>
			  </div><br>

			  <div class="form-row">
			    <div class="form-group col-md-2">
			      <label for="inputEmail4">CEP</label><br>
			      <font color="blue"><%=cep %></font>
			    </div>
			    <div class="form-group col-md-2">
			      <label for="inputPassword4">Quantidade de Funcionários</label><br>
			      <font color="blue"><%=qtdFunc %></font>
			    </div>
			    <div class="form-group col-md-2">
			      <label for="inputPassword4">Reputação Fiscal</label><br>
			      <font color="blue"><%=repA %></font>
			    </div>
			  </div><br>

			  <div class="form-row">
			    <div class="form-group col-md-2">
			      <label for="inputEmail4">Data do Cadastro</label><br>
			      <font color="blue"><%=cadastro %></font>
			    </div>
			    <div class="form-group col-md-2">
			      <label for="inputEmail4">Serviço Selecionado</label><br>
			      <font color="blue"><%=razaoSocial %></font>
			    </div>
			  </div><br><br>

			  <div class="form-row">
			    <div class="form-group col-md-6">
			      <label for="inputPassword4">Descrição da empresa</label> <br>
			      <textarea rows="6" cols="85" disabled><%=descricao %></textarea>
			    </div>
			  </div>

			
	         
		</div>
	</div>



	<footer id="myFooter">
        <div class="container">
            <div class="row">
                <div class="col-sm-3">
                    <h2 class="logo"><a href="https://programadorviking.com.br/"> <img src="logoMenor.png" width="250" class="logoMenor"> </a></h2>
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
