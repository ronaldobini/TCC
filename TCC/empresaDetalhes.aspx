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
    <center>
    <div class="top_cliente">
		<div class="top_int_cliente">
			<img src="imgs/logoComprida.png" width="300"/>
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
			      <li class="nav-item active">
			        <a class="nav-link" href="mapao.aspx">Buscar Serviço <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="solicitacoesCliente.aspx">Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>

			    </ul>
			    
<% if (Session["sId"] == null){ %>
                    <a href="cadastrarUsuario.aspx" style="margin-right:30px;"> <button class="btn btn-primary" type="submit">Cadastre-se para solicitar um serviço</button></a>
			        <a href="loginCliente.aspx"> <button class="btn btn-outline-success" type="submit">Login</button></a>
                    
<% }else{ %>
                    <a style="margin-right:30px;" href="minhaConta.aspx"><font color="green"><%=Session["sNome"] %></font></a>
                    <a href="Logout.aspx"><button class="btn btn-outline-danger">Sair</button></a>
<% } %>
			      
			    
			  </div>
			</nav>
		</div>
	</div>
	
	<div class="conteudo_index_cliente">
		<div class="conteudo_tabelas_centralizar">
             
			   <br /> Contratar:<br /><br />
            

                        <table>
                            <tr><th style="width:200px;">Serviço</th><th style="width:200px;">Preço Médio</th><th style="width:200px;">Tempo Médio</th><th style="width:200px;">Contratar</th></tr>
                            <%foreach (var serv in servs)
                                {
                                    string linkContratar = "servicoContratar.aspx?idEmpEsc="+(getEmpresaMapa)+"&idSerEsc="+(serv.Id);
                                    int i = 0;
                            %>

                        

                            <tr><td><%=serv.Desc %></td><td><%=serv.ValorAprox %></td><td><%=serv.TempoAprox %></td><td><a href="<%=linkContratar %>">Contratar </a></td></tr>                        
                        
                            <% } %>
                        </table>
            <br /><br />

            <hr />
            Detalhes:<br /><br />

            <table class="table table-dark centralizarConteudoTabelas">
              <tr>
                <th>Razão Social</th>
                <th>CNPJ</th>
                <th>Diretor</th>
                <th>Representante Comercial</th>
              </tr>
              <tr>
                <td><%=razaoSocial %></td>
                <td><%=cnpj %></td>
                <td><%=diretor %></td>
                <td><%=comercial %></td>
              </tr>
            </table>

             <table class="table table-dark centralizarConteudoTabelas">
                
                <tr>
                    <td><center><%=repA %></td>
                    <td><center><%=repQ %></td>
                    <td><center><%=repT %></td>
                </tr>
            </table><br /><br />

            <table class="table table-dark centralizarConteudoTabelas">
              <tr>
                <th>Representante Técnico</th>
                <th>Telefone 1</th>
                <th>Endereço</th>
                <th>Complemento</th>
              </tr>
              <tr>
                <td><%=tecnico %></td>
                <td><%=telefone1 %></td>
                <td><%=endereco %>, <%=numero %></td>
                <td><%=complemento %></td>
              </tr>
            </table> <br /><br />

            <table class="table table-dark centralizarConteudoTabelas">
              <tr>
                <th>Telefone 2</th>
                <th>CEP</th>
                <th>Quantidade de Funcionários</th>
                <th>Quantidade de Serviços Executados</th>
                <th>Reputação</th>
              </tr>
              <tr>
                <td><%=telefone2 %></td>
                <td><%=cep %></td>
                <td><%=qtdFunc %></td>
                <td><%=qtdServ %></td>                
              </tr>
                
            </table> <br /><br />

           

            <table class="table table-dark centralizarConteudoTabelas">
              <tr>
                <th>Data do Cadastro</th>
                <th>Zona de atendimento</th>
              </tr>
              <tr>
                <td><%=cadastro %></td>
                <td><%=zona %></td>
              </tr>
            </table>


			      <label for="inputPassword4">Descrição da empresa</label> <br>
			      <textarea rows="6" cols="85" disabled><%=descricao %></textarea>
			
	         
		</div>
	</div>
        <br /><br />


	<div class="footerTest">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
</body>
</html>
