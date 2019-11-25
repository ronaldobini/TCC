<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sobre.aspx.cs" Inherits="TCC.sobre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="css/estilo.css" />
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css" />
    <title>Sobre Nós</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark navbar-color">

        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item">
                    <a class="nav-link" href="index.aspx">Pagina inicial<span class="sr-only">(página atual)</span></a>
                </li>

                <li class="nav-item active">
                    <a class="nav-link" href="sobre.aspx">Sobre Nós<span class="sr-only">(página atual)</span></a>
                </li>

                <li class="nav-item">
                    <a class="nav-link" href="contato.aspx">Contato <span class="sr-only">(página atual)</span></a>
                </li>
            </ul>
        </div>
    </nav>


    <div class="conteudo_pagina_principal">
        <div class="conteudo_pagina_principal_int">
            <img src="imgs/logoSimples.png" width="200" />
            <br />
            <br />
            <h2>Sobre a Servitiba:</h2>
            <br />
            Nós somos uma empresa focada em agilizar a sua busca de serviços localizados
			próximos e proporcionar a intermediação entre você e o prestador de serviço.

			<hr />

            <h2>A equipe:</h2>
            <br />
            <div class="row">
                <div class="col-4">
                    <img src="imgs/leo.png" class="equipe" />
                    <br />
                    <h6>Leonardo Felipe Comar</h6>
                    <br />
                    <br />

                </div>
                <div class="col-4">
                    <img src="imgs/lucas.jpg" class="equipe" />
                    <br />
                    <h6>Lucas Mattei Malfertheiner</h6>
                    <br />
                    <br />

                </div>
                <div class="col-4">
                    <img src="imgs/ronaldo.jpg" class="equipe" />
                    <br />
                    <h6>Ronaldo Bini da Silva Jr</h6>
                    <br />
                    <br />

                </div>
            </div>
            <div class="row">
                <div class="col-8">
                    <img src="imgs/nicolas.png" class="equipe" />
                    <br />
                    <h6>Nicolas Chueh Sourient</h6>
                    <br />
                    <br />

                </div>
                <div class="col-1">
                    <img src="imgs/victor.png" class="equipe" />
                    <br />
                    <h6>Victor Rochadel Gantzel</h6>
                    <br />
                    <br />

                </div>
            </div>
        </div>
    </div>
    <footer class="py-3 bg-dark footer-good">
        <div class="container">
            <p class="m-0 text-center text-white">© 2019 Copyright - Servitiba
                <img src="imgs/logoSimples.png" width="30" class="img_rodape" /></p>
        </div>
    </footer>


</body>
</html>
