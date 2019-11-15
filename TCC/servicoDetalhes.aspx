<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servicoDetalhes.aspx.cs" Inherits="TCC.servicoDetalhes" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
  <script type="text/javascript" src="js/bootstrap.js"></script>
  <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
  <link rel="stylesheet" type="text/css" href="css/estilo.css">
  <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
  <title>Chat</title>
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
			        <a class="nav-link" href="indexPrestador.aspx">Lista de Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item ">
			        <a class="nav-link" href="servicoEmExecucao.aspx">Serviços Em Execução <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item">
			        <a class="nav-link" href="servicosFinalizados.aspx">Serviços Finalizados <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="gerenciarServicos.aspx">Gerenciar Serviços <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item">
			        <a class="nav-link" href="empresaColaboradores.aspx">Gerenciar Colaboradores <span class="sr-only">(página atual)</span></a>
			      </li>

                   <li class="nav-item">
			        <a class="nav-link" href="gerenciarFinancas.aspx">Gerenciar Finanças <span class="sr-only">(página atual)</span></a>
			      </li>
                     <li class="nav-item active">
			        <a class="nav-link" >Detalhes Serviço <span class="sr-only">(página atual)</span></a>
			      </li>
			    </ul>
                   <a style="margin-right:30px;" href="minhaConta.aspx"><font color="green"><%=Session["sNome"] %> (<%=Session["sFuncao"] %>)</font></a>
			    <form class="form-inline my-2 my-lg-0" action="index.aspx" method="POST">
			      <button class="btn btn-outline-danger" type="submit">Sair</button>
			    </form>
			  </div>
			</nav>
		</div>
	</div>
  
  <div class="conteudo_relatorio_cliente">
    <div class="conteudo_solicitacao_cliente_int">
      
        <br><br>
        <div class="panel">
          <form runat="server">
            <div class="form-row">
              <div class="form-group col-md-2">
                <label for="inputEmail4">Num. Serviço:</label>
                <font color="blue"><%=servicoget %></font>
              </div>
                <div class="form-group col-md-2">
                <label for="inputEmail4">Desc. Serviço:</label>
                <font color="blue"><%=descServ %></font>
              </div>
              <div class="form-group col-md-2">
                <label for="inputEmail4">Situação:</label>
                <font color="blue"><%=sitS %></font>
              </div>
              <div class="form-group col-md-2">
                <label for="inputEmail4">Empresa:</label>
                <font color="blue"><%=nomeEmpresa %></font>
              </div>
              <div class="form-group col-md-2">
                  <label for="inputPassword4">Cliente:</label>
                  <font color="blue"><%=nomeCliente %></font>
              </div>
              <div class="form-group col-md-2">
                  <label for="inputPassword4">Preço:</label>
                  <asp:textbox id="txValor" runat="server" ></asp:textbox>
              </div>
              <div class="form-group col-md-2">
                  <label for="inputPassword4">Previsão:</label>
                  <asp:textbox id="txDataEstimada" runat="server" ></asp:textbox>
              </div>
            </div>
              <br /><br /><br />
            <div class="form-row">            
              <div class="form-group col-md-6">
                <label for="inputEmail4">Descrição Cliente</label> <br>
                <textarea rows="6" cols="100" <%=disabled %>>
                <%=descUsu %>
                </textarea>
              </div>
              <div class="form-group col-md-4">
                <table id="funcs">
                    <tr><th style="width:100px;">Nome Técnico</th><th style="width:100px;">Formação</th><th style="width:100px;">Cpf</th><th style="width:100px;">Tel</th></tr>
                    <%  
                        foreach (var tec in listaEmpServ)
                        {

                            TCC.Classes.UsuarioEmpresa ue = new TCC.Classes.UsuarioEmpresaDAO().selectUserIdUser(tec.IdTec);
                            TCC.Classes.Usuario uu = new TCC.Classes.UsuarioDAO().selectUser(tec.IdTec);
                    %>
                        <tr><td><%=uu.Nome %></td><td><%=ue.Formacao %></td><td><%=uu.Cpf %></td><td><%=uu.Tel1 %></td></tr>
                    <%
                        }

                     %>
                </table>
              </div>
            </div>
          </form>

          
        </div> <br> <hr> <br>
        
        Chat: <br><br> <br>

        <table class="table table-dark">
          <thead>
            <tr>
              <td scope="row" colspan="2">Chat com o cliente</td>
            </tr>
          </thead>
          <tbody>
              <%
                  foreach (var msg in listaChat) {
                      
                            TCC.Classes.Usuario uum = new TCC.Classes.UsuarioDAO().selectUser(msg.IdUser);
                      TCC.Classes.UsuarioEmpresa uem = new TCC.Classes.UsuarioEmpresaDAO().selectUserIdUser(msg.IdUser);
              %>
            <tr class="chat_cliente">
              <th scope="row"></th>
              <th scope="row"><%=uum.Nome %> (<%=uem.Funcao %>): <%=msg.Mensagem %> </th>
            </tr>     
              <%
                  }
              %>
          </tbody>
        </table>

        <br><br>

        <textarea placeholder="Escreva aqui sua mensagem..." rows="6" cols="100"></textarea>
        <br><br>
        <a href="chat.html"><button class="btn btn-primary">Enviar</button></a>

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
