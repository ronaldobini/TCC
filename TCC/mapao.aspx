﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mapao.aspx.cs" Inherits="TCC.mapao" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Legend</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" />
    <meta charset="utf-8" />
    <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="assets/css/Footer-with-button-logo.css">
	<link rel="stylesheet" type="text/css" href="css/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="css/estilo.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">


    <style>
      html, body {
        margin: 0;
        padding: 0;
      }
      #map {
        height: 400px;
        width: 100%;
      }
      #legend {
        font-family: Arial, sans-serif;
        background: #fff;
        padding: 10px;
        margin: 10px;
        border: 3px solid #000;
      }
      #legend h3 {
        margin-top: 0;
      }
      #legend img {
        vertical-align: middle;
      }
    </style>



</head>
<body>
    


    	<div class="top_cliente">
		<div class="top_int_cliente">
			<img src="imgs/logoComprida.png" width="300"/>
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
			      <li class="nav-item active">
			        <a class="nav-link" href="mapao.aspx">Buscar Serviço <span class="sr-only">(página atual)</span></a>
			      </li>

			      <li class="nav-item">
			        <a class="nav-link" href="solicitacoesCliente.aspx">Solicitações <span class="sr-only">(página atual)</span></a>
			      </li>

			    </ul>
			    
<% if (Session["sId"] == null){ %>
                    <a href="cadastrarUsuario.aspx" style="margin-right:30px;"> <button class="btn btn-primary" type="submit">Cadastre-se para solicitar um serviço</button></a>
			        <a href="loginCliente.aspx"> <button class="btn btn-outline-success" type="submit">Login</button></a>
                    
<% }else{ %>
                    <a style="margin-right:30px;" href="minhaConta.aspx"><font color="green"><%=Session["sNome"] %></font></a>
                    <a href="Logout.aspx"><button class="btn btn-outline-danger">Sair</button></a>
<% } %>
			      
			    
			  </div>
			</nav>
		</div>
	</div>

	
	
	<div class="conteudo_index_cliente">
		<div class="conteudo_index_cliente_int">
			<div class="conteudo_index_cliente_int_l">
				Qual serviço você deseja hoje? <br><br>
				<form id="mapao" runat="server" method="post" action="#">
					
                    <asp:DropDownList ID="categorias" runat="server" class="form-control form-control-lg"></asp:DropDownList>
					<br><br>
					
                    <input type="text" class="form-control" id="pesq" name="pesq" runat="server"/>
                    <br><br>
				    <button class="btn btn-success" runat="server"  onserverclick="filtrar">Buscar</button> <br><br>

				</form>
				
				Aqui você pode digitar o serviço desejado e o mapa mostrará a listagem de serviços deste tipo localizados próximos a você! <br><br><br>

				

			</div>
			<div class="conteudo_index_cliente_int_r">
				    <div id="map"></div>
                    <div id="legend"><h3>Legend</h3></div>
                    <script>
                        var map;
                        function initMap() {
                            map = new google.maps.Map(document.getElementById('map'), {
                                center: { lat: -25.436958, lng: -49.279756 },
                                zoom: 12,
                                mapTypeId: 'roadmap'
                            });

                            var iconBase = '/imgs/';
                            var icons = {
                                domicilio: {
                                    name: 'Servico em domicilio',
                                    icon: iconBase + 'house.png'
                                },
                                local: {
                                    name: 'Servico local',
                                    icon: iconBase + 'local.png'
                                }
                            };

                            var features = [
                                    <%
                                        foreach(var ponto in listaPontos)
                                        {
                                            string pontoJavaScript = ponto.MapPointo();
                                    %>

                                        <%=pontoJavaScript%>,

                                    <%
                                        }
                                    %>
                            ];

                            var infoWindow = new google.maps.InfoWindow;
                            var infowincontent = document.createElement('div');
                            var strong = document.createElement('strong');
                            strong.textContent = "test4";
                            infowincontent.appendChild(strong);
                            infowincontent.appendChild(document.createElement('br'));

                            // Create markers.
                            features.forEach(function (feature) {
                                var marker = new google.maps.Marker({
                                    position: feature.position,
                                    icon: icons[feature.type].icon,
                                    map: map
                                });
                                marker.addListener('click', function () {
                                    infoWindow.setContent(feature.infos);
                                    infoWindow.open(map, marker);
                                });
                            });

                            var legend = document.getElementById('legend');
                            for (var key in icons) {
                                var type = icons[key];
                                var name = type.name;
                                var icon = type.icon;
                                var div = document.createElement('div');
                                div.innerHTML = '<img src="' + icon + '" width=24 hight=24> ' + name;
                                legend.appendChild(div);
                            }

                            map.controls[google.maps.ControlPosition.RIGHT_BOTTOM].push(legend);
                        }
                    </script>
                    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCSbnmsy0j1KVVLOG8FxGELMeha_pqnvYo&callback=initMap">
                    </script>
			</div>
		</div>
	</div>

    <br /><br />
	<div class="footerTest">
        <div class="footerTest_int">
            © 2019 Copyright - Servitiba <img src="imgs/logoSimples.png"  width="30" class="img_rodape"/>
        </div>
    </div>

    
     
</body>
</html>