<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="old_cliente.aspx.cs" Inherits="TCC.cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css"/>
	<link rel="stylesheet" type="text/css" href="css/estilo.css"/>
	<title>Home Page</title>
</head>
<body>
	<div class="top_cliente">
		<div class="top_int_cliente">
			Nome do Sistema
		</div>
	</div>

	<div class="middle">
		<div class="middle_int">
			<div class="middle_int_l_cliente">
				Não tem login? Cadastre-se! <br><br>
				<form runat="server" method="post" action="#">
				  <div class="form-row">
				    <div class="form-group col-md-6">
				      <label for="inputEmail4">Nome Completo</label>
				      <input runat="server" type="text" class="form-control" id="nomeC" placeholder="Nome...">
				    </div>
				    <div class="form-group col-md-6">
				      <label for="inputPassword4">E-mail</label>
				      <input runat="server" type="email" class="form-control" id="emailC" placeholder="Senha...">
				    </div>
				  </div>
				  <div class="form-group">
				    <label for="inputAddress">CPF</label>
				    <input runat="server" type="text" class="form-control" id="cpfC" placeholder="CPF (Apenas números)">
				  </div>
				  <div class="form-group">
				    <label for="inputAddress2">Endereço</label>
				    <input runat="server" type="text" class="form-control" id="endC" placeholder="Endereço">
				  </div>
				  <div class="form-row">
				    <div class="form-group col-md-3">
				      <label for="inputCity">Nº</label>
				      <input runat="server" type="text" class="form-control" id="numC">
				    </div>
				    <div class="form-group col-md-4">
				      <label for="inputState">CEP</label>
				      <select id="inputState" class="form-control">
				        <option selected>Choose...</option>
				        <option>...</option>
				      </select>
				    </div>
				    <div class="form-group col-md-2">
				      <label for="inputZip">Login</label>
				      <input runat="server" type="text" class="form-control" id="loginC">
				    </div>
				    <div class="form-group col-md-2">
				      <label for="inputZip">Senha</label>
				      <input runat="server" type="text" class="form-control" id="senhaC">
				    </div>
				  </div>
				  <input type="submit" id="botCad" class="btn btn-primary" value="Cadastrar" runat="server" onserverclick="cadastrar">
				
<%--                    </form>
				<form runat="server" method="post" action="#">--%>
			</div>
			<div class="middle_int_r_cliente">
				Já é Cliente? Faça Login! <br><br><br><br>
				  <div class="form-group">
				    <label for="exampleInputEmail1">Login</label>
				    <input type="text" class="form-control" id="login" name="login" aria-describedby="emailHelp" placeholder="Insira seu login" runat="server">
				    <small id="emailHelp" class="form-text text-muted">Nunca divulgue seus dados, por sua segurança.</small>
				  </div>
				  <div class="form-group">
				    <label for="exampleInputPassword1">Senha</label>
				    <input type="password" class="form-control" id="senha" name="senha" placeholder="Insira sua senha" runat="server">
				  </div>
				  <br><br>
				  <input type="submit" class="btn btn-primary" value="Entrar" runat="server" onserverclick="autenticar">
				</form>
			</div>
		</div>
	</div>
    <%=mensagem %>
	<div class="footerTest">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>
</body>
</html>