<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prestador.aspx.cs" Inherits="TCC.prestador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css"/>
	<link rel="stylesheet" type="text/css" href="estilo.css"/>
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
				<form>
				  <div class="form-row">
				    <div class="form-group col-md-6">
				      <label for="inputEmail4">Nome Completo</label>
				      <input type="text" class="form-control" id="inputEmail4" placeholder="Nome...">
				    </div>
				    <div class="form-group col-md-6">
				      <label for="inputPassword4">E-mail</label>
				      <input type="email" class="form-control" id="inputPassword4" placeholder="Senha...">
				    </div>
				    <div class="form-group col-md-6">
				      <label for="inputPassword4">Telefone</label>
				      <input type="email" class="form-control" id="inputPassword4" placeholder="Senha...">
				    </div>
				    <div class="form-group col-md-6">
				      <label for="inputPassword4">Celular</label>
				      <input type="email" class="form-control" id="inputPassword4" placeholder="Senha...">
				    </div>
				  </div>
				  <div class="form-group">
				    <label for="inputAddress">CPF</label>
				    <input type="text" class="form-control" id="inputAddress" placeholder="CPF (Apenas números)">
				  </div>
				  <div class="form-group">
				    <label for="inputAddress2">Endereço</label>
				    <input type="text" class="form-control" id="inputAddress2" placeholder="Endereço">
				  </div>
				  <div class="form-row">
				    <div class="form-group col-md-3">
				      <label for="inputCity">Nº</label>
				      <input type="text" class="form-control" id="inputCity">
				    </div>
				    <div class="form-group col-md-3">
				      <label for="inputCity">CEP</label>
				      <input type="text" class="form-control" id="inputCity">
				    </div>
				    <div class="form-group col-md-3">
				      <label for="inputZip">Login</label>
				      <input type="text" class="form-control" id="inputZip">
				    </div>
				    <div class="form-group col-md-3">
				      <label for="inputZip">Senha</label>
				      <input type="text" class="form-control" id="inputZip">
				    </div>
				  </div>
				  <a href=""><button type="submit" class="btn btn-primary">Cadastrar</button></a>
				</form>

			</div>
			<div class="middle_int_r_cliente">
				Já é Prestador? Faça Login! <br><br><br><br>
				<form  runat="server" method="post" action="#">
				  <div class="form-group">
				    <label for="exampleInputEmail1">Login</label>
				    <input runat="server" type="text" class="form-control" name="login" id="login" aria-describedby="emailHelp" placeholder="Insira seu login">
				    <small id="emailHelp" class="form-text text-muted">Nunca divulgue seus dados, por sua segurança.</small>
				  </div>
				  <div class="form-group">
				    <label for="exampleInputPassword1">Senha</label>
				    <input runat="server" type="password" class="form-control" name="senha" id="senha" placeholder="Insira sua senha">
				  </div>
				  <br><br>
				  
				<%--<a href="indexPrestador.html"><button type="submit" class="btn btn-primary">Entrar</button></a>--%>
                   <input runat="server" style="width:100px;" class="btn btn-primary" type="submit" value="Entrar" onserverclick="Logar_Click" /><br />
				</form>
			</div>
            <%if (user != null)
                {
                    
                    %>
            <meta http-equiv="refresh" content="0; URL=indexPrestador.aspx" />
            <%
                }
                    %>
		</div>
	</div>

	<div class="footer">
		<div class="footer_int">
			Rodapé teste. Aqui terá um rodapé.
           <%-- <%if (result) {
                   
                }%>--%>
		</div>
	</div>
</body>
</html>