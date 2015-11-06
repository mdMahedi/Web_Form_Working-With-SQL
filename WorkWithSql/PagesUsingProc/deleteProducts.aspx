<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deleteProducts.aspx.cs" Inherits="WorkWithSql.PagesUsingProc.deleteProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="82px" OnClick="btnDelete_Click" /><br />
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
