<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empresaColaboradores.aspx.cs" Inherits="TCC.empresaColaboradores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
    <title>Gerenciar Colaboradores</title>
</head>
    <script>
        $(function () {
            $('[data-toggle="tooltip"]').tooltip()
        })
    </script>
<body>
    <div class="top_cliente">
        <div class="top_int_cliente">
            <img src="imgs/logoComprida.png" width="300" />
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

                        <li class="nav-item">
                            <a class="nav-link" href="gerenciarServicos.aspx">Gerenciar Serviços <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item active">
                            <a class="nav-link" href="empresaColaboradores.aspx">Gerenciar Colaboradores <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="gerenciarFinancas.aspx">Gerenciar Finanças <span class="sr-only">(página atual)</span></a>
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
        <div class="conteudo_index_cliente_int2">
            <div class="solicitacaoPrestador_int2">
                <br>
                <br>
                <a href="userEmpCadastro.aspx">
                    <button class="btn btn-success">
                        Cadastrar Novo Colaborador
                    </button>
                </a>
                <br>
                <hr>
                <br>
                <%if (statusOperação == 1)
                    { %>
                <div class="alert alert-success alert-dismissible fade show" role="alert">
                    <strong><%=msg %></strong>
                  <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                  </button>
                </div>
                <%}
                    else
                    {
                        if (statusOperação == 2)
                        {
                %>

                <div class="alert alert-danger alert-dismissible fade show" role="alert">
                    <strong><%=msg %></strong>
                  <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                  </button>
                </div>
                <%
                        }
                    } %>
                <table class="table table-dark">
                    <thead>
                        <tr>
                            <th scope="col">Nome do Colaborador</th>
                            <th scope="col">Função</th>
                            <th scope="col">Data Cadastro</th>
                            <th scope="col">Visualizar</th>
                            <th scope="col">Editar</th>
                            <th scope="col">Ação</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%
                            foreach (var col in colaboradores)
                            {
                                if (col.Id != 0)
                                {
                                    string linkEdit = "userEmpCadastro.aspx?id=" + col.Id;
                                    string linkDel = "excluir.aspx?id=" + col.Id + "&funcao=deleteUser";
                                    string id = col.Nome;
                        %>
                        <tr>
                            
                            <td><%=col.Nome%></td>
                            <td><%=col.UserEmp.Funcao%></td>
                            <td><%=col.DataCadastro%></td>
                            <td><a href="verDadosColaborador.html">
                                <img src="imgs/binoculars.png" /></a></td>
                            <td><a href="<%=linkEdit %>">
                                <img src="imgs/edit.png" /></a></td>
                            <%if (col.UserEmp.FlAtivo == 0)
                                { %>
                            <td><a data-toggle="tooltip" data-placement="top" title="Desativar colaborador" href="<%=linkDel %>">
                                <img src="imgs/delete.png" /></a></td>
                            <%}
                            else
                            { %>
                            <td><a data-toggle="tooltip" data-placement="top" title="Reativar colaborador" href="empresacolaboradores.aspx?funcao=Reativar&id=<%=col.Id %>">
                                <img src="imgs/nonstop.png" /></a></td>
                            <%} %>
                           
                        </tr>
                        <%
                                }
                            } %>
                    </tbody>
                </table>
            </div>


        </div>
    </div>
    <div class="footer-good">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba
            <img src="imgs/logoSimples.png" width="30" class="img_rodape" />
        </div>
    </div>
</body>
</html>
