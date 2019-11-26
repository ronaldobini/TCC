<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarColaborador.aspx.cs" Inherits="TCC.VisualizarColaborador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css"/>
    <link rel="stylesheet" type="text/css" href="css/estilo.css"/>
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css"/>

   

    <title><%=tituloDaPag %></title>

</head>
<body>
    
    <div class="menu">
        <div class="menu_int">
            <nav class="navbar navbar-expand-lg navbar-dark navbar-color">

                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
                    <ul class="navbar-nav mr-auto">
                        <li class="nav-item ">
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
  

    <div class="conteudo_pagina_cadastro">
        <div class="conteudo_pagina_cadastro_int">
            <img src="imgs/logoSimples.png" width="100"><br>
           
            <h3>Visualizar colaborador</h3>
        
            <form method="POST" action="#" runat="server">

                <div class="row justify-content-md-center">
                    <div class="form-group col-md-6">
                        <label for="login">Login</label>
                        <asp:TextBox ID="login" disabled  class="form-control" placeholder="Login" runat="server"></asp:TextBox>
                    </div>                    
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="nomCompleto">Nome Completo</label>
                        <asp:TextBox ID="nomCompleto" disabled  class="form-control" placeholder="Nome Completo" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="email">E-mail</label>
                        <asp:TextBox ID="email" disabled  class="form-control" type="email" placeholder="E-mail" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="cpf">CPF</label>
                        <asp:TextBox ID="cpf" disabled class="form-control" placeholder="CPF" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="cep">CEP</label>
                        <asp:TextBox ID="cep" disabled   class="form-control" placeholder="CEP" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="endereco">Endereço</label>
                        <asp:TextBox ID="endereco" disabled  class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-2">
                        <label for="complemento">Complemento</label>
                        <asp:TextBox ID="complemento" disabled  class="form-control" placeholder="Complemento" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="numero">Número</label>
                        <asp:TextBox ID="numero" disabled  class="form-control" placeholder="Número da casa" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="tel">Telefone</label>
                        <asp:TextBox ID="tel" disabled  class="form-control telefone" placeholder="Telefone" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="cel">Celular</label>
                        <asp:TextBox ID="cel" disabled  class="form-control telefone" placeholder="Telefone" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="cidadesDD">Cidade</label>
                        <asp:DropDownList Enabled="false"  CssClass="form-control"  ID="cidadesDD" runat="Server">
                            <asp:ListItem />
                        </asp:DropDownList>
                    </div>                    
                    <div class="form-group col-md-6">
                        <label for="CargoFixo">Cargo</label>
                        <asp:DropDownList Enabled="false" CssClass="form-control" ID="Cargo" runat="Server">
                            <asp:ListItem />
                        </asp:DropDownList>
                    </div>    
                </div>
                <div class="form-row">
                    <div class="form-group col-md-4">
                        <label for="funcao">Funçao</label>
                        <asp:TextBox ID="funcao" disabled  class="form-control" placeholder="Função" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="Escolaridade">Escolaridade</label>
                        <asp:DropDownList CssClass="form-control" Enabled="false" ID="Escolaridade" runat="Server">
                            <asp:ListItem />
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="formacao">Formaçao</label>
                        <asp:TextBox ID="formacao" class="form-control" disabled placeholder="Formaçao" runat="server"></asp:TextBox>
                    </div>

                    <br />
                    <br />

                </div>
                <br />

             

                <button type="submit" runat="server" onserverclick="Voltar" class="btn btn-primary">Voltar</button>
            </form>
        </div>
    </div>

         <footer class="py-3 bg-dark footer-good">
            <div class="container">
                <p class="m-0 text-center text-white">© 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/></p>
            </div>
      </footer>
</body>
</html>
