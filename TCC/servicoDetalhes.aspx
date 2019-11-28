<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servicoDetalhes.aspx.cs" Inherits="TCC.servicoDetalhes" EnableEventValidation="true" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
    <title>Detalhes do Serviço</title>

 


</head>
<body class="body2">
    <div class="top_cliente">
        <div class="top_int_cliente">
            <img src="imgs/logoComprida.png" width="300" />
        </div>
    </div>

    <div class="menu">
        <div class="menu_int">
            <nav class="navbar navbar-expand-lg navbar-dark navbar-color">

                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
                    <ul class="navbar-nav mr-auto">

                        <% if (Session["sIdEmp"] != null)
                            { %>
                        <% if ((int)Session["sNivelEmp"] > 1)
                            {%>
                        <li class="nav-item">
                            <a class="nav-link" href="indexPrestador.aspx">Lista de Solicitações <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="servicoEmExecucao.aspx">Serviços em Execução <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="servicosFinalizados.aspx">Serviços Finalizados <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="gerenciarServicos.aspx">Gerenciar Serviços <span class="sr-only">(página atual)</span></a>
                        </li>
                        <% }
                            if ((int)Session["sNivelEmp"] > 2)
                            {%>
                        <li class="nav-item">
                            <a class="nav-link" href="empresaColaboradores.aspx">Gerenciar Colaboradores <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="gerenciarFinancas.aspx">Gerenciar Finanças <span class="sr-only">(página atual)</span></a>
                        </li>

                        <% }
                            else
                            { %>

                        <li class="nav-item">
                            <a class="nav-link" href="servicoEmExecucao.aspx">Serviços em Execução <span class="sr-only">(página atual)</span></a>
                        </li>

                        <% } %>
                        <%}
                            else
                            { %>

                        <li class="nav-item ">
                            <a class="nav-link" href="mapao.aspx">Buscar Serviço <span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item ">
                            <a class="nav-link" href="solicitacoesCliente.aspx">Solicitações <span class="sr-only">(página atual)</span></a>
                        </li>

                        <%} %>

                        <li class="nav-item active">
                            <a class="nav-link"><font color="#65e05e">Detalhes Serviço</font><span class="sr-only">(página atual)</span></a>
                        </li>


                    </ul>
                    <a style="margin-right: 30px;" href="minhaConta.aspx"><font color="#65e05e"><%=Session["sNome"] %> (<%=Session["sFuncao"] %>)</font></a>
                    <a href="Logout.aspx">
                        <button class="btn btn-outline-danger">Sair</button></a>
                </div>
            </nav>
        </div>
    </div>

    <div class="conteudo_relatorio_cliente">
        <div class="conteudo_solicitacao_cliente_int">

            <br/>
            <br/>
            <div class="container">
                <form runat="server" action="#">
                    <div class="form-row">
                        <div class="form-group col-md-3 ">
                            <b>Num. Serviço:</b> <%=servicoget %>
                        </div>
                        <div class="form-group col-md-3 ">
                            <b>Descrição:</b> <%=descServ %>
                        </div>
                        <div class="form-group col-md-6 ">
                            <b>Situação:</b> <%=sitS %>
                        </div>

                    </div>
                    <div class="form-row">
                        <div class="form-group col-md-3 ">
                            <b>Empresa:</b> <%=nomeEmpresa %>
                        </div>
                        <div class="form-group col-md-3">
                            <b>Cliente:</b><%=nomeCliente %>
                        </div>
                        <div class="form-group col-md-3 ">
                            <b>Reputação:</b> <%=repCliente %>
                        </div>
                        <div class="form-group col-md-3 ">
                            <b>Endereço:</b> <%=endCliente %>
                        </div>
                    </div>
                    <div class="form-row">

                        <div class="form-group col-md-6">
                            <label for="inputPassword4"><b>Preço:</b></label><br />
                            <asp:TextBox class="form-control" ID="txValor" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6 ">
                            <label for="inputPassword4"><b>Previsão:</b></label><br />
                            <asp:TextBox class="form-control" ID="txDataEstimada" runat="server"></asp:TextBox>
                        </div>


                    </div>
                    <br />
                    <div class="form-row">
                        <div class="form-group col-md-12">
                            <label for="inputEmail4"><b>Descrição Cliente</b></label>
                            <br>
                            <textarea rows="3" disabled class="form-control">
                                        <%=descUsu %>
                                </textarea>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-2" style="display: flex; align-items: center;">
                            Adicionar funcionario:
                        </div>
                        <div class="col-8">
                            <asp:DropDownList ID="servTecsEmp" runat="server" class="form-control">
                            </asp:DropDownList>
                        </div>  
                        <div class="col-2">
                            <button runat="server" onserverclick="addTecServ" id="btAdd" class="btn btn-success" type="submit">Adicionar</button>

                        </div>
                    </div>
                     <br />
                    <div class="table-responsive">
                        <table class="table table-bordered">
                            <thead class="thead-dark">
                                <tr>
                                    <th style="width: 100px;">Nome Técnico</th>
                                    <th style="width: 100px;">Formação</th>
                                    <th style="width: 100px;">Tel</th>
                                </tr>
                            </thead>
                            <%  
                                if (listaServTec != null)
                                {
                                    foreach (var tec in listaServTec)
                                    {

                                        TCC.Classes.UsuarioEmpresa ue = new TCC.Classes.UsuarioEmpresaDAO().selectUserIdUser(tec.IdTec);
                                        TCC.Classes.Usuario uu = new TCC.Classes.UsuarioDAO().selectUser(tec.IdTec);

                            %>
                            <tr>
                                <td><%=uu.Nome %></td>
                                <td><%=ue.Formacao %></td>
                                <td><%=uu.Tel1 %></td>
                            </tr>
                            <%                              
                                    }
                                }

                            %>
                        </table>
                    </div>
            </div>
            <br>
            <hr />



            <% if (sit == 0)
                {
                    if (Session["sIdEmp"] != null)
                    {
            %>

            <input runat="server" onserverclick="empresaUpdate" class="btn btn-success" type="submit" value="Atualizar" />
            <button runat="server" onserverclick="empresaAprove" class="btn btn-success" type="submit">Aprovar</button>
            <button runat="server" onserverclick="empresaReprove" class="btn btn-success" type="submit">Recusar</button>

            <%
                    }
                }
                else if (sit == 1)
                {
                    if (Session["sCliente"] != null)
                    {
            %>

            <button runat="server" onserverclick="clientePay" class="btn btn-success" type="submit">Aprovar e Pagar</button>


            <%
                    }
                }
                else if (sit == 2)
                {
                    if (Session["sIdEmp"] != null)
                    {
            %>

            <button type="button" class="btn btn-success" data-toggle="modal" data-target=".bd-example-modal-xl">Serviço Finalizado</button>
            <button runat="server" onserverclick="anyProblem" class="btn btn-outline-danger" type="submit">Tive problemas com o Cliente</button>

            <div class="modal fade bd-example-modal-xl" tabindex="-1" role="dialog" aria-labelledby="myExtraLargeModalLabel" aria-hidden="true">
                <div class="modal-dialog modal-xl">
                    <div class="modal-content">
                        <div class="conteudo_modal">
                            Reputação do Cliente
                            <br />
                            <br />
                            <select runat="server" class="form-control" id="repCli">
                                <option value="1">1</option>
                                <option value="2">2</option>
                                <option value="3">3</option>
                                <option value="4">4</option>
                                <option value="5">5</option>
                                <option value="6">6</option>
                                <option value="7">7</option>
                                <option value="8">8</option>
                                <option value="9">9</option>
                                <option value="10">10</option>
                            </select><br />
                            <textarea runat="server" id="obsFinaisEmpresa" placeholder="Escreva aqui suas observações sobre o serviço (...)" rows="3" cols="30"></textarea><br />
                            <input type="submit" runat="server" onserverclick="empresaEnd" value="Enviar" class="btn btn-success" />

                        </div>
                    </div>
                </div>
            </div>

            <%
                    }
                }
                else if (sit == 3)
                {
                    if (Session["sCliente"] != null)
                    {
            %>

            <button type="button" class="btn btn-success" data-toggle="modal" data-target=".bd-example-modal-x2">Serviço executado como previsto</button>
            <button runat="server" onserverclick="anyProblem" class="btn btn-outline-danger" type="submit">Tive problemas</button>

            <div class="modal fade bd-example-modal-x2" tabindex="-1" role="dialog" aria-labelledby="myExtraLargeModalLabel" aria-hidden="true">
                <div class="modal-dialog modal-x2">
                    <div class="modal-content">
                        <div class="conteudo_modal">
                            Qualidade do serviço
                            <br />
                            <br />
                            <input type="text" id="repQ" runat="server" placeholder="0-100" />
                            <br />
                            <br />

                            Qualidade do atendimento
                            <br />
                            <br />
                            <input type="text" id="repA" runat="server" placeholder="0-100" /><br />
                            <br />

                            Velocidade do Serviço
                            <br />
                            <br />
                            <input type="text" id="repT" runat="server" placeholder="0-100" /><br />
                            <br />

                            <textarea runat="server" id="obsFinaisCli" placeholder="Escreva aqui suas observações sobre o serviço (...)" rows="3" cols="30"></textarea><br />

                            <input type="submit" runat="server" onserverclick="clienteEnd" value="Enviar" class="btn btn-success" />

                        </div>
                    </div>
                </div>
            </div>

            <%
                    }
                }
                else if (sit == 4)
                {

            %>

            <button runat="server" onserverclick="anyProblem" class="btn btn-outline-danger" type="submit">Tive problemas depois de finalizar</button>

            <%

                }
            %>

            
            <font color="green"><asp:Label ID="mensagem" runat="server"></asp:Label></font>

           

            <br/><hr/><br/>
            <table class="table table-dark">
                <thead>
                    <tr>
                        <% if (Session["sIdEmp"] != null)
                            { %>
                        <td scope="row" colspan="2">Chat com o cliente</td>
                        <% }
                            else
                            {

                        %>
                        <td scope="row" colspan="2">Chat com a empresa</td>

                        <%} %>
                    </tr>
                </thead>
                <tbody>
                    <%
                        if (listaChat != null)
                        {
                            foreach (var msg in listaChat)
                            {

                                TCC.Classes.Usuario uum = new TCC.Classes.UsuarioDAO().selectUser(msg.IdUser);
                                TCC.Classes.UsuarioEmpresa uem = new TCC.Classes.UsuarioEmpresaDAO().selectUserIdUser(msg.IdUser);
                                //if (Session[sIdEmp] != uem.IdEmpresa) { uem.Funcao = "Cliente"; }
                    %>
                    <tr class="chat_cliente">
                        <th scope="row"></th>
                        <th scope="row"><%=uum.Nome %> (<%=msg.Tempo %>): <%=msg.Mensagem %> </th>
                    </tr>
                    <%
                            }
                        }
                    %>
                </tbody>
            </table>

            <br />
            <br />
            <div class="row">
            <div class="col-sm-3"></div>
            <textarea class="form-control col-sm-6" runat="server" id="msgUser" placeholder="Escreva aqui sua mensagem..." rows="6" cols="60"></textarea>
            </div>
            <br />
            <br />
            <input type="submit" runat="server" value="Enviar" onserverclick="enviarMsg" class="btn btn-primary" />
        </div>

        </form>
    </div>
    </div>

    <div class="col-1"></div>
     <footer class="py-3 bg-dark footer-good">
            <div class="container">
                <p class="m-0 text-center text-white">© 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/></p>
            </div>
      </footer>
</body>
</html>
