<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mapao.aspx.cs" Inherits="TCC.mapao" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Legend</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no" />
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">


    <style>
      html, body {
        margin: 0;
        padding: 0;
        height: 100%;
        width: 100%;
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

            var iconBase = 'https://maps.google.com/mapfiles/kml/shapes/';
            var icons = {
                domicilio: {
                    name: 'Servico em domicilio',
                    icon: iconBase + 'library_maps.png'
                },
                local: {
                    name: 'Servico local',
                    icon: iconBase + 'info-i_maps.png'
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
                div.innerHTML = '<img src="' + icon + '"> ' + name;
                legend.appendChild(div);
            }

            map.controls[google.maps.ControlPosition.RIGHT_BOTTOM].push(legend);
        }
    </script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCSbnmsy0j1KVVLOG8FxGELMeha_pqnvYo&callback=initMap">
    </script>

    
     <p><%=mostrar%></p>
</body>
</html>