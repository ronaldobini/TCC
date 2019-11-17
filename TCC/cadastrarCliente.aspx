<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrarCliente.aspx.cs" Inherits="TCC.cadastrarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
    <title>Cadastro</title>
</head>
<body>
    <div class="menu_principal">
        <div class="menu_principal_int">
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark">

                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item active">
                            <a class="nav-link" href="index.aspx">Pagina inicial<span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="sobre.aspx">Sobre Nós<span class="sr-only">(página atual)</span></a>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link" href="contato.html">Contato <span class="sr-only">(página atual)</span></a>
                        </li>
                    </ul>
                </div>
            </nav>
        </div>
    </div>

    <div class="conteudo_pagina_cadastro">
        <div class="conteudo_pagina_cadastro_int">
            <img src="logoTeste.png" width="100"><br>
            <%if (id == -1)
                {
            %>
            <h3>Cadastre o Gerente da Empresa</h3>
            <% }
                else
                {

            %>
            <h3>Editar Colaborador</h3>
            <% }
            %>
            <form method="POST" action="#" runat="server">

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="login">Login</label>
                        <asp:TextBox ID="login" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" id="login" placeholder="Login">--%>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="senha">Senha</label>
                        <asp:TextBox ID="senha" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        <%--<input type="password" runat="server" class="form-control" id="senha" placeholder="Senha">--%>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="nomCompleto">Nome Completo</label>
                        <asp:TextBox ID="nomCompleto" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" id="nomCompleto" placeholder="Nome completo">--%>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="email">E-mail</label>
                        <asp:TextBox ID="email" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        <%--<input type="email" runat="server" class="form-control" id="email" placeholder="exemplo@exemplo.com.br">--%>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="cpf">CPF</label>
                        <asp:TextBox ID="cpf" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" id="cpf" placeholder="Apenas números">--%>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="cep">CEP</label>
                        <asp:TextBox ID="cep" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" id="cep" placeholder="Apenas números">--%>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="endereco">Endereço</label>
                        <asp:TextBox ID="endereco" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" id="endereco" placeholder="Endereço">--%>
                    </div>
                    <div class="form-group col-md-2">
                        <label for="complemento">Complemento</label>
                        <asp:TextBox ID="complemento" class="form-control" placeholder="Casa" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" id="complemento" placeholder="Complemento">--%>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="numero">Número</label>
                        <asp:TextBox ID="numero" class="form-control" placeholder="123" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control" id="numero" placeholder="Número">--%>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="tel">Telefone</label>
                        <asp:TextBox ID="tel" class="form-control telefone" placeholder="(XX)x xxxx-xxxx" runat="server"></asp:TextBox>
                        <%--<input type="tel" runat="server" class="form-control" id="tel" placeholder="xxxx-xxxx">--%>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="cel">Celular</label>
                        <asp:TextBox ID="cel" class="form-control telefone" placeholder="(XX)x xxxx-xxxx" runat="server"></asp:TextBox>
                        <%--<input type="text" runat="server" class="form-control telefone" id="cel" placeholder="(XX)x xxxx-xxxx">--%>
                    </div>
                </div>

                 <asp:DropDownList ID="cidadesDD" runat="Server">
                        <asp:ListItem />
                    </asp:DropDownList>

             

               
                <button type="submit" runat="server" onserverclick="cadastrar" class="btn btn-success">Cadastrar</button>
               

                <small id="a" class="form-text text-muted">Sua empresa já é cadastrada? <a href="loginEmpresa.html">Faça Login</a>!</small>
                <small id="b" class="form-text text-muted">Não tem login? Solicite ao seu superior!</small>
            </form>
        </div>
    </div>
    <br>
    <br>
    <br>
    <br>
    <div class="footer-good">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>
