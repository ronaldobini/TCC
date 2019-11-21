<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empresaCadastro.aspx.cs" Inherits="TCC.empresaCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">

    <title>Cadastro da Empresa</title>
</head>
<body class="testBody">
    <div class="menu_principal">
        <div class="menu_principal_int">
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark">

                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item">
                            <a class="nav-link" href="index.aspx">Pagina inicial<span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="sobre.aspx">Sobre Nós<span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="contato.aspx">Contato <span class="sr-only">(página atual)</span></a>
                        </li>
                    </ul>
                </div>
            </nav>
        </div>
    </div>

    <div class="conteudo_pagina_cadastro">
        <div class="conteudo_pagina_cadastro_int">
            <img src="imgs/logoSimples.png" width="100" class="logoMenor"><br />
            <%if (id == -1)
                {
            %>
            <h3>Cadastre sua Empresa no Servitiba!</h3>
            <% }
                else
                {

            %>
            <h3>Editar Empresa</h3>
            <% }
            %>

            <%if (mensagem != "")
                { %>
            <div class="alert alert-danger" role="alert">
                <ul>
                    <%foreach (var a in mensagem.Split('&'))
                        {%>
                    <li><%=a %></li>
                    <%}%>
                </ul>
            </div>
            <%} %>
            <form method="POST" action="#" runat="server">

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="cnpj">CNPJ</label>
                        <asp:TextBox ID="cnpj" type class="form-control" placeholder="CNPJ" runat="server"></asp:TextBox>
                        <%--<input type="text"  runat="server" class="form-control" id="cnpj" placeholder="CNPJ" required/>--%>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="razaoSocial">Razão Social</label>
                        <asp:TextBox ID="razaoSocial" class="form-control" placeholder="Razão Social" runat="server"></asp:TextBox>
                        <%--<input type="text"  runat="server" class="form-control" id="razaoSocial" placeholder="Razão Social" required/>--%>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="tel">Telefone</label>
                        <asp:TextBox ID="tel" class="form-control" placeholder="Telefone" runat="server"></asp:TextBox>
                        <%--<input type="tel"  runat="server" class="form-control" id="tel" placeholder="xxxx-xxxx" required/>--%>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="cel">Celular</label>
                        <asp:TextBox ID="cel" class="form-control" placeholder="Celular" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server"  class="form-control telefone" id="cel" placeholder="xxxxx-xxxx" required/>--%>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-12">
                        <label for="cep">CEP</label>
                        <asp:TextBox ID="cep" class="form-control" placeholder="CEP" runat="server"></asp:TextBox>
                        <%--<input type="tel" runat="server"  class="form-control" id="cep" placeholder="CEP" required/>--%>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="endereco">Endereço</label>
                        <asp:TextBox ID="endereco" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        <%--<input type="text"  runat="server" class="form-control" id="endereco" placeholder="Endereço" required/>--%>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="complemento">Complemento</label>
                        <asp:TextBox ID="complemento" class="form-control" placeholder="Complemento" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server"  class="form-control" id="complemento" placeholder="Complemento"/>--%>
                    </div>
                    <div class="form-group col-md-2">
                        <label for="numero">Número</label>
                        <asp:TextBox ID="numero" class="form-control" placeholder="Número" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" id="numero" placeholder="Número" required />--%>
                    </div>
                </div>

                <div class="form-row col-md-12">
                    <div class="form-group col-md-4">
                        <label for="categoria">Cidade</label>
                        <asp:DropDownList ID="cidadesDD" runat="server" CssClass="form-control" required></asp:DropDownList>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="zonaA">Zona de Atendimento</label>
                        <asp:TextBox ID="zonaAtendimento" class="form-control" placeholder="Zona de Atendimento" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" value="Curitiba e Região" class="form-control" id="zonaAtendimento" placeholder="Zona Atendimento" required />--%>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="funcs">Funcionarios</label>
                        <asp:TextBox ID="qtdFunc" class="form-control" placeholder="Quantidade de Funcionarios" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" value="1" id="qtdFunc" placeholder="Quantidade de Funcionarios" required />--%>
                    </div>
                </div>
                <div class="form-row col-md-12">

                    <div class="form-group col-md-12">
                        <label for="descricao">Descrição da Empresa</label>
                        <br />
                        <textarea runat="server" name="message" class="form-control" rows="5" id="descricao" cols="60" required></textarea>
                    </div>
                </div>
                <%if (id == -1)
                    {
                %>
                <button type="submit" runat="server" onserverclick="cadastrar" class="btn btn-primary">Próximo</button>
                <%}
                    else
                    {
                %> 
                <button type="submit" runat="server" onserverclick="editar" class="btn btn-primary">Pronto</button>
                <%} %>
            </form>
        </div>
    </div>
    <div class="centralizar">
        <small id="emailHelp" class="form-text text-muted">Sua empresa já é cadastrada? <a href="loginEmpresa.aspx">Faça Login</a>!</small>
        <small id="emailHelp" class="form-text text-muted">Não tem login? Solicite ao seu superior!</small>
    </div>
    <br>
    <br>
    <div class="footer-good">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba
            <img src="imgs/logoSimples.png" width="30" class="img_rodape" />
        </div>
    </div>
</body>
</html>
