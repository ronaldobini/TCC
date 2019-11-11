<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrarServico.aspx.cs" Inherits="TCC.cadastrarServico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <title>Home Page</title>
</head>
<body>

    <div class="top_cliente">
        <div class="top_int_cliente">
            Servitiba
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

    <div class="conteudo_solicitacoes_cliente">
        <div class="conteudo_index_cliente_int">
            <div class="solicitacaoPrestador_int">
                <br />
                <br />
                <form runat="server">
                    <div class="container ">

                        <div class="form-group ">
                            <label for="descricao">Descrição</label>
                            <br>
                            
                            <asp:TextBox type="text" runat="server" rows="6" cols="85" class="form-control col-md-6 " style="margin-left: 25%;" id="descricao" placeholder="Descrição"></asp:TextBox>

                        </div>
                         <div class="form-group ">
                            <label for="precoMedio">Preço Médio</label>
                            <asp:TextBox type="text" runat="server" class="form-control money col-md-6 "  Style="margin-left: 25%;" ID="precoMedio" placeholder="R$"></asp:TextBox>

                        </div>
                        <label for="categoria">Categoria</label>

                        <asp:DropDownList ID="categoria" runat="server" CssClass="form-control col-md-6 " Style="margin-left: 25%;">
                        </asp:DropDownList>

                        <div class="form-group ">
                            <label for="tempo">Tempo previsto</label>
                            <asp:TextBox type="text" runat="server" class="form-control col-md-6" Style="margin-left: 25%;" ID="tempo" placeholder="Tempo previsto para o serviço"></asp:TextBox>

                            <asp:HiddenField Id="idServico" runat="server" />
                        </div>

                         <div class="form-group ">
                            <label for="tempo">Tags para busca</label>
                            <asp:TextBox type="text" runat="server" class="form-control col-md-6" Style="margin-left: 25%;" value ID="Tags" placeholder="Tags..."></asp:TextBox>
                        </div>
                    </div>

                    <% if (Session["editando"] != null && (int)Session["editando"] == 0)
                             { %>
                        <button type="submit" runat="server" onserverclick="SubmitForm" class="btn btn-primary">Cadastrar</button>
                     <% }
                             else
                             { %>
                        <button type="submit" runat="server" onserverclick="Editar" class="btn btn-primary">Editar</button>
                    <%} %>
                </form>
                <br />
                <br />


            </div>
        </div>
    </div>

    <br>
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
</body>


</html>
