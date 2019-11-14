<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empresaColaboradores.aspx.cs" Inherits="TCC.empresaColaboradores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
	<link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
	<title>Gerenciar Colaboradores</title>
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
                        <li class="nav-item ">
                            <a class="nav-link" href="indexPrestador.aspx">Lista de Solicitações <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="servicoEmExecucao.aspx">Serviços Em Execução <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="servicosFinalizados.aspx">Serviços Finalizados <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item active">
                            <a class="nav-link" href="gerenciarServicos.aspx">Gerenciar Serviços <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="empresaColaboradores.aspx">Gerenciar Colaboradores <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="empresaFinancas.aspx">Gerenciar Finanças <span class="sr-only">(página atual)</span></a>
                        </li>
                    </ul>
                    <a style="margin-right: 30px;" href="minhaConta.aspx"><font color="green"><%=Session["sNome"] %> (<%=Session["sFuncao"] %>)</font></a>

                    <a href="Logout.aspx">
                        <button class="btn btn-outline-danger">Sair</button></a>

                </div>
			</nav>
		</div>
	</div>
	
	<div class="conteudo_relatorio_cliente">
		<div class="conteudo_solicitacao_cliente_int">
			
				<br><br>
				<div class="panel">
					Colaboradores

					
				</div> <br> <hr> <br>

				<table class="table table-dark">
				  <thead>
				    <tr>
				      <th scope="col">Nº</th>
				      <th scope="col">Nome do Colaborador</th>
				      <th scope="col">Função</th>
				      <th scope="col">Data Cadastro</th>
				      <th scope="col">Visualizar</th>
				      <th scope="col">Editar</th>
				      <th scope="col">Remover</th>
				    </tr>
				  </thead>
				  <tbody>
                       <%
                           int count = 0;
                           foreach (var col in colaboradores)
                           {
                               string linkEdit = "userEmpCadastro.aspx?id=" + col.Id;
                               string id = col.Nome;
                        %>
				    <tr>
				      <th scope="row"><%=col.Id %></th>
				      <td><%=col.Nome%></td>
				      <td><%=col.UserEmp.Funcao%></td>
				      <td><%=col.DataCadastro%></td>
				      <td><a href="verDadosColaborador.html"><img src="imgs/binoculars.png"/></a></td>
				      <td><a href="<%=linkEdit %>"><img src="imgs/edit.png"/></a></td>
				      <td><a href="deletarColaborador.html"><img src="imgs/delete.png"/></a></td>
                        <%--asp:ImageButton ID='d_<%=id%>'
                            ImageUrl="imgs/delete.png"
                            AlternateText="No Image available"
                            OnClick="ImageButton_Click" runat="server" /> --%>
				    </tr>
                      <%
                          } %>
				  </tbody>
				</table>
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
            <p>© 2019 Copyright - Servitiba</p>
        </div>
    </footer>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>