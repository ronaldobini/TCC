﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gerenciarServicos.aspx.cs" Inherits="TCC.gerenciarServicos" %>

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
        <div class="conteudo_index_cliente_int2">
            <div class="solicitacaoPrestador_int2">
                <br>
                <br>
                <a href="cadastrarServico.aspx">
                    <button class="btn btn-success">
                        Cadastrar Novo Serviço
                    </button>
                </a>
                <br>
                <br>
                <%if (statusOperação == 1)
                    { %>
                <div class="alert alert-success alert-dismissible fade show" role="alert">
                    <strong> Sucesso ao realizar operação.</strong>
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
                    <strong>Erro ao realizar operação.</strong>
                  <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                  </button>
                </div>
                <%
                        }
                    } %>
                
                <form method="POST" action="#" runat="server">
                    <table class="table table-dark">
                        <thead>
                            <tr>
                                <th scope="col">Serviço</th>
                                <th scope="col">Preço</th>
                                <th scope="col">Tempo de conclusão</th>
                                <th scope="col">Editar</th>
                                <th scope="col">Excluir</th>
                            </tr>
                        </thead>
                        <tbody>
                            <%
                                foreach (var servico in listaDeServicos)
                                {
                                    var linkEditar = "cadastrarServico.aspx?Id=" + servico.Id;
                                    var linkExcluir = "excluir.aspx?Id=" + servico.Id + "&funcao=deleteServicoEmpresa";
                            %>
                            <tr>
                                <th><%=servico.Desc %></th>
                                <td><%=servico.ValorAprox %></td>
                                <td><%=servico.TempoAprox %></td>
                                <td>
                                    <a href="<%=linkEditar %>">
                                        <img src="imgs/edit.png" /></a>
                                </td>
                                <td>
                                    <a href="<%=linkExcluir %>">
                                        <img src="imgs/x-button.png" id="btn-confirm" /></a>
                                </td>
                            </tr>
                            <%

                                }
                            %>
                        </tbody>
                    </table>
                </form>
            </div>
        </div>
    </div>


    <div class="modal fade" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true" id="mi-modal">
        <div class="modal-dialog modal-sm">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title" id="myModalLabel">Confirmar a exclusão?</h4>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" id="modal-btn-si">Sim</button>
                    <button type="button" class="btn btn-primary" id="modal-btn-no">Não</button>
                </div>
            </div>
        </div>
    </div>


    <br>
    <footer id="sticky-footer" class="py-4 bg-dark text-white-50 footer-good">
        <div class="container text-center">
            <small>Copyright &copy; Servitiba</small>
        </div>
    </footer>

</body>


</html>
