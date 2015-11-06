<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertNUpdate.aspx.cs" Inherits="WorkWithSql.PagesUsingProc.InsertNUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td><asp:Label ID="Label4" runat="server" Text="Product Name  "></asp:Label></td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>          
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Product Price  "></asp:Label></td>
            <td><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Product Quantity  "></asp:Label></td>
            <td><asp:TextBox ID="txtQty" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Suppliyer"></asp:Label></td>
            <td><asp:TextBox ID="txtSupl" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" Width="80px" /></td>
        </tr>
    </table>
        
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
