<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrarUsuario.aspx.cs" Inherits="TCC.cadastrarUsuario" %>

<!DOCTYPE html>
<html>
<head>
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
    <link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">

    <title>Cadastro de Cliente</title>
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
            <img src="imgs/logoSimples.png" width="100"><br>
            <h3>Cadastre-se!</h3>            
                <form method="post" action="#" runat="server">
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4">Login</label>
                        <asp:TextBox type="text" runat="server" class="form-control " ID="login" placeholder="Login" required></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4">Senha</label>
                        <asp:TextBox type="password" runat="server" Rows="6" cols="85" class="form-control  " required ID="senha" placeholder="Senha"></asp:TextBox>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4">Nome Completo</label>
                        <asp:TextBox type="text" runat="server" Rows="6" cols="85" class="form-control  "  required ID="nome" placeholder="Nome"></asp:TextBox>

                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4">E-mail</label>
                        <asp:TextBox type="email" runat="server" Rows="6" cols="85" class="form-control " required ID="email" placeholder="Email"></asp:TextBox>

                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4">CPF</label>
                        <asp:TextBox type="text" runat="server" Rows="6" cols="85" class="form-control " required ID="cpf" placeholder="CPF"></asp:TextBox>

                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4">CEP</label>
                        <asp:TextBox type="text" runat="server" Rows="6" cols="85" class="form-control " required ID="cep" placeholder="CEP"></asp:TextBox>

                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4">Endereço</label>
                        <asp:TextBox type="text" runat="server" Rows="6" cols="85" class="form-control " required ID="endereco" placeholder="Endereco"></asp:TextBox>

                    </div>
                    <div class="form-group col-md-2">
                        <label for="inputPassword4">Complemento</label>
                        <asp:TextBox type="text" runat="server" Rows="6" cols="85" class="form-control " required  ID="complemento" placeholder="Complemento"></asp:TextBox>

                    </div>
                    <div class="form-group col-md-4">
                        <label for="inputPassword4">Número</label>
                        <asp:TextBox type="text" runat="server" Rows="6" cols="85" class="form-control  " required ID="numero" placeholder="Numero"></asp:TextBox>

                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4">Telefone</label>
                        <asp:TextBox type="text" runat="server" Rows="6" cols="85" class="form-control  " required ID="telefone" placeholder="Telefone"></asp:TextBox>

                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4">Celular</label>
                        <asp:TextBox type="text" runat="server" Rows="6" cols="85" class="form-control" required ID="celular" placeholder="Celular"></asp:TextBox>

                    </div>
                </div>

                <div class="form-group">
                    <label for="categoria">Cidade</label>
                    <asp:DropDownList ID="cidade" runat="server" CssClass="form-control" required></asp:DropDownList>
                </div>


                 <button type="submit" runat="server" onserverclick="Cadastrar" class="btn btn-primary">Cadastrar</button>
            </form>
        </div>
    </div><br /><br />
    <div class="centralizar"><small id="emailHelp" class="form-text text-muted">Já tem cadastro? <a href="loginCliente.aspx">Faça Login</a>! ou <a href="index.aspx">de uma Espiadinha</a>!</small></div>
    <br><br />
    <br>
    <br>
    <div class="footerTest">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</body>
</html>
