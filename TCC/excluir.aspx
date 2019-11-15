<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="excluir.aspx.cs" Inherits="TCC.excluir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                if (funcao.Equals("delUser"))
                {

                %>

            <button type="submit" runat="server" onserverclick="deleteUser"  class ="btn btn-success">Excluir</button>
            <%}
                %>
            <%--<button type="submit" runat="server" onserverclick="voltar"  class ="btn btn-success">Voltar</button>--%>
        </div>
    </form>
</body>
</html>
