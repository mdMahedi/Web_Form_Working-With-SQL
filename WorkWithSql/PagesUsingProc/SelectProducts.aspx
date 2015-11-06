<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectProducts.aspx.cs" Inherits="WorkWithSql.PagesUsingProc.SelectProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnSearch" runat="server" Text="Products" OnClick="btnSearch_Click" />
    </div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
