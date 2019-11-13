<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testes.aspx.cs" Inherits="TCC.testes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>

   

    <form id="form1" runat="server">
        
         <asp:button id="bt1"
           Text="texto"
           CommandName="comando1"
           CommandArgument='<%=var %>'
           OnCommand="clicou" 
           runat="server"/>

         

    </form>

    <%=url %>
   

  
</body>
</html>
