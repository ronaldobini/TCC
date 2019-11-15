<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="solicitacoesCliente.aspx.cs" Inherits="TCC.solicitacoesCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
    <title>Solicitações</title>
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
			        <a class="nav-link" href="mapao.aspx">Buscar Serviço <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item active">
			        <a class="nav-link" href="solicitacoesCliente.aspx">Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>

			    </ul>
			    
<% if (Session["sId"] == null){ %>
                    <a href="cadastroCliente.aspx"> <button class="btn" type="submit">Cadastra-se para solicitar um serviço</button></a>
			        <a href="loginCliente.aspx"> <button class="btn btn-outline-success" type="submit">Login</button></a>
                    
<% }else{ %>
                    <a style="margin-right:30px;" href="minhaConta.aspx"><font color="green"><%=Session["sNome"] %></font></a>
                    <a href="Logout.aspx"><button class="btn btn-outline-danger">Sair</button></a>
<% } %>
			      
			    
			  </div>
			</nav>
		</div>
	</div>

    <div class="conteudo_solicitacoes_cliente">
        <div class="conteudo_solicitacao_cliente_int">
            <div class="solicitacaoCliente_int">
                <br>
                <br>
                <div class="panel">
                    Legenda dos status:
                    <br>
                    <br>
                    Aceite: <a data-toggle="tooltip" title="">
                        <img src="imgs/checked.png" />

                    </a>--------- Pendente: <a data-toggle="tooltip" title="">
                        <img src="imgs/pause.png" />

                    </a>--------- Negada: <a data-toggle="tooltip" title="">
                        <img src="imgs/x-button.png" /></a>

                </div>
                <br>
                <hr>

                <br>
                <br>
                <table class="table table-dark">
                    <thead>
                        <tr>
                            <th scope="col">Nº</th>
                            <th scope="col">Solicitação</th>
                            <th scope="col">Categoria</th>
                            <th scope="col">Data da Solicitação</th>
                            <th scope="col">Status</th>
                            <th scope="col">Chat</th>
                            <th scope="col">Cancelar</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%
                            foreach (var sol in solicitacoes)
                            {
                                if (sol.Id != 0)
                                {
                                    string linkDel = "excluir.aspx?id=" + sol.Id + "&funcao=delSolicUser";
                        %>
                        <tr>
                            <th scope="row"><%=sol.Id %></th>
                            <td><%=sol.DescUser%></td>
                            <td><%=sol.Categoria.Descricao%></td>
                            <td><%=sol.DataIni%></td>
                            <td>
                            <%if (sol.Sit == 0) //Em solicitacao/negociacao para aceite da empresa
                                {
                            %>
                            <img src="imgs/circular-clock.png">
                            <%}
                                else if (sol.Sit == 1) //pendente aceite cliente
                                {
                            %>
                            <img src="imgs/circular-clock.png">
                            <%}
                                else if (sol.Sit == 2) //Executando
                                {
                            %>
                            <img src="imgs/play.png">
                            <%}
                                else if (sol.Sit == 3) //pendente aceite final
                                {
                            %>
                            <img src="imgs/circular-clock.png">
                            <%}
                                else if (sol.Sit == 4) //finalizado
                                {
                            %>
                            <img src="imgs/checked.png">
                            <%}
                                else if (sol.Sit == -1) //Negado
                                {
                            %>
                            <img src="imgs/x-button.png">
                            <%}
                                else if (sol.Sit == -2) //Em discussao/problemas juridicos
                                {
                            %>
                            <img src="imgs/pause.png">
                            <%}
                            %>
                                </td>
                            <td><a href="chatCliente.aspx">
                                <img src="imgs/conversation.png" /></a></td>
                            <td><a href="<%=linkDel %>">
                                <img src="imgs/delete.png" /></a></td>

                        </tr>
                        <%
                                }
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
                    <h2 class="logo"><a href="https://programadorviking.com.br/">
                        <img src="logoMenor.png" width="250" class="logoMenor">
                    </a></h2>
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
