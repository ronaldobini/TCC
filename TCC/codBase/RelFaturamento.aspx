<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RelFaturamento.aspx.cs" Inherits="simireports.RelFaturamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="icon" type="image/png" href="img/syss.png">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>SimiWeb - <%=Session["swver"] %></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">

</head>
<body style="background-color:#222;" onload="onload();">
     <div id="logo" style="margin-left:20px; float:left;">
        <a  title="Voltar ao Inicio" href=" Relatorios.aspx"><img style=" width:50px;" src="img/syss.png" /></a>
    </div>
    <center>
    <div id="titulo" style="margin-top:40px; margin-right:70px; color:white; font-size:30px;">007 - Faturamento</div>
    <br />

        <p><%=sqlview %></p>
        <div id="filtros" style="margin-bottom:40px;">
            <form runat="server" id="filtrosFat" action="#" method="post">
                <table style="color:white;">
                    <tr>
                        <th style="width:100px;">Data Inicio<br /> (Min: 2016)</th>
                        <th style="width:100px;">Data Fim</th>
                        <th style="width:100px;">Empresa</th>
                        <th style="width:100px;">Nota</th>
                        <th style="width:130px;">Item</th>
                        <th style="width:100px;">Nome Item</th>
                        <th style="width:100px;">Fam. Item</th>
                    </tr>
                    <tr>
                        <td style="width:140px;"><input class="form-control" style="width:120px; text-align:center;" runat="server" type="text" id="datInicio" autocomplete="off"/></td>
                        <td style="width:140px;"><input class="form-control" style="width:120px; text-align:center;" runat="server" type="text" id="datFim"  autocomplete="off"/></td>
                        <td style="width:120px;">
                            <select class="form-control" style="width:100px;" id="empresa" runat="server">
                                <option value="">Todas</option>
                                <option value="2">02</option>
                                <option value="3">03</option>
                                <option value="4">04</option>
                                <option value="5">05</option>
                                <option value="6">06</option>
                            </select>
                        </td>
                        <td style="width:150px;"><input class="form-control" style="width:130px;" runat="server" type="text" id="nota" autocomplete="off"/></td>
                        <td style="width:120px;"><input class="form-control" style="width:110px;" runat="server" type="text" id="codItem"  autocomplete="off"/></td>
                        <td style="width:120px;"><input class="form-control" style="width:110px;" runat="server" type="text" id="descItem"  autocomplete="off"/></td>
                        <td style="width:140px;">
                            <select class="form-control" style="width:120px;" id="familia" runat="server">
                                <option value="00">Todas</option>
                                <option value="01">SICK</option>
                                <option value="02">LS</option>
                                <option value="03">BRADY</option>
                                <option value="09">BELDEN</option>
                                <option value="34">GREENPROCESS</option>
                                <option value="50">SERVICOS</option>
                                <option value="98">DIVERSOS IMP</option>
                                <option value="99">DIVERSOS</option>
                            </select>
                        </td>
                    </tr>
                    <tr>
                        <th style="width:100px;">CNPJ Cliente</th>
                        <th style="width:100px;">Nome Cliente</th>
                        <th style="width:120px;">Natureza</th>
                        <th style="width:100px;">Pedido</th>
                        <th style="width:100px;">Pedido Cliente</th>
                        <th style="width:100px;">Transportadora</th>
                    </tr>
                    <tr>
                        <td style="width:120px;"><input class="form-control" style="width:110px;" runat="server" type="text" id="cliente"  autocomplete="off"/></td>
                        <td style="width:120px;"><input class="form-control" style="width:110px;" runat="server" type="text" id="nomCli"  autocomplete="off"/></td>
                        <td style="width:120px;">
                            <select class="form-control" style="width:100px;" id="natureza" runat="server">
                                <option value="">Todas</option>
                                <option value="9001">Serviço</option>
                                <option value="1000">Produtos</option>
                            </select>
                        </td>
                        <td style="width:120px;"><input class="form-control" style="width:110px;" runat="server" type="text" id="pedido"  autocomplete="off"/></td>
                        <td style="width:120px;"><input class="form-control" style="width:110px;" runat="server" type="text" id="pedCli"  autocomplete="off"/></td>
                        <td style="width:120px;"><input class="form-control" style="width:110px;" runat="server" type="text" id="trans"  autocomplete="off"/></td>
                    </tr>
                </table>
                <br />
                <input class="btn btn-primary btn-xs" style="background-color:#126DBD" runat="server" type="submit" value="Filtrar" onserverclick="filtrarFat_Click" />
                <input class="btn btn-primary btn-xs" style="background-color:#0a5e03; border-color:#0a5e03;" runat="server" type="submit" value="Exportar" onserverclick="export_Click" />

            </form>
        </div>


        <div id="resultados">
        <div style="color:white; margin-bottom:30px;">Total Faturamentos: R$ <%= m.formatarDecimal(totFaturamento) %></div>
            <font color=white>Mostrando <%=fats.Count%> resultados, de <%=m.configDataBanco2Human(postDatInicio)%> a <%=m.configDataBanco2Human(postDatFim)%></font><br/>
            <table class="table table-striped table-dark" style = "max-width:95%; color:white; font-size: 12px;">
                <%
                    Decimal totFat = 0.0m;
                    string totFatS = "";

                    foreach (var fat in fats) {

                     %> 
                        <thead style="background-color: #070a0e; color:white;">
                            <tr>
                                <th style="width:100px;">Nota</th>
                                <th style="width:100px;">Empresa</th>
                                <th style="width:100px;">Data</th>
                                <th style="width:100px;">CNPJ Cliente</th>
                                <th style="width:100px;">Nome Cliente</th>
                                <th style="width:120px;">Natureza</th>
                                <th style="width:100px;">Pedido</th>
                                <th style="width:100px;">Pedido Cliente</th>
                                <th style="width:100px;">Transportadora</th>
                            </tr>
                        </thead>
                        <tr>
                            <td style="text-align:left;"><b><%= fat.Nota %></b></td>
                            <td style="text-align:left;"><b><%= fat.Empresa %></b></td>
                            <td style="text-align:left;"><b><%= fat.Data %></b></td>
                            <td style="text-align:left;"><b><%= fat.ClienteCPF %></b></td>
                            <td style="text-align:left;"><b><%= fat.NomeCliente %></b></td>
                            <td style="text-align:left;"><b><%= fat.Natureza %></b></td>
                            <td style="text-align:left;"><b><%= fat.Pedido %></b></td>
                            <td style="text-align:left;"><b><%= fat.PedCli %></b></td>
                            <td style="text-align:left;"><b><%= fat.Trans %></b></td>
                        </tr>
                        <tr>
                            <td colspan ="9">
                                <table class="table table-sm table-dark" style="background-color:#3f4142; width:100%; color:white; font-size: 12px;">
                                    <thead>
                                        <tr>
                                            <th style="width: 10%;">Cod. do Item</th>
                                            <th style="width: 35%;">Desc. Item</th>
                                            <th style="width: 5%; text-align:center;"">Quantidade</th>
                                            <th style="text-align:right;width: 10%;">Preço Unit</th>
                                            <th style="text-align:right;width: 10%;">Preço Total</th>
                                        </tr>
                                    </thead>
                                    <%
                                        totFat = 0.0m;
                                        totFatS = m.formatarDecimal(totFat);
                                        foreach (var item in fat.Itens)
                                        {
                                            string codItem = item.CodItem;
                                            string nomeItem = item.NomeItem;
                                            int qtd = Convert.ToInt32(item.QtdAtend);
                                            
                                            String preUnitS = m.formatarDecimal(item.PrecoUnit);

                                            totFat += item.PrecoUnit*Convert.ToInt32(item.QtdAtend);
                                            totFatS = m.formatarDecimal(totFat);
                                            
                                    %>
                                            <tr>
                                                <td><%= codItem %></td>
                                                <td><%= nomeItem %></td>
                                                <td style="text-align:center;"><%= qtd %></td>
                                                <td style="text-align:right;"><%= "R$"+preUnitS %></td>
                                                <td style="text-align:right;"><%= "R$"+m.formatarDecimal(item.PrecoUnit*qtd) %></td>
                                            </tr>
                                                
                                    <% } %>
                                    <tr>
                                        <td colspan="8" style="background-color: #070a0e; color:white;"><b>Total Faturamento: R$ <%= totFatS %></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                                <%
                                    } 
                                %>
            </table>
        </div>
    
</body>
</html>
