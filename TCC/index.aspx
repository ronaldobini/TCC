<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TCC.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><%=results %></h3>
            <h3>Usuario 2:<%=user.Id %></h3>
            <h3><%=user.Login %></h3>
            <h3><%=user.Nome %></h3>
            <h1>----------------</h1>
            <%foreach (var usu in users)
                {
                    %><h3>Usuario <%=usu.Id %></h3>
            <h3>Login<%=usu.Login %></h3>
            <h3>Nome<%=usu.Nome %></h3><%
                } %>
        </div>
    </form>
</body>
</html>
