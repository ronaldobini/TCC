<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginSimples.aspx.cs" Inherits="TCC.loginSimples" %>

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
			<div class="interior_simples">
				<form>
				  <div class="form-group">
				    <label for="inputAddress">Nome</label>
				    <input type="text" class="form-control" id="inputAddress" placeholder="Nome Completo">
				  </div>
				  <div class="form-group">
				    <label for="inputAddress">CEP</label>
				    <input type="text" class="form-control" id="inputAddress" placeholder="CEP (Apenas Números)">
				  </div>
				  
				</form>
				<a href="indexSimples.aspx"><button type="submit" class="btn btn-primary">Entrar</button></a>
			</div>
		</div>
	</div>

	<div class="footer">
		<div class="footer_int">
			Rodapé teste. Aqui terá um rodapé.
		</div>
	</div>
</body>
</html>